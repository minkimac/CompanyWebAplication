﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyWebAplication.ResetPassword
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!IsPasswordResetLinkValid())
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Password Reset link has expired or is invalid.Please try to reset again!";
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ChangeUserPassword())
            {
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Password Changed Successfully!";
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Password Reset link has expired or is invalid";
            }
        }

        private bool ExecuteSP(string SPName, List<SqlParameter> SPParameters)
        {
            string CS = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand(SPName, con);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter parameter in SPParameters)
                {
                    cmd.Parameters.Add(parameter);
                }

                con.Open();
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }

        private bool IsPasswordResetLinkValid()
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
    {
        new SqlParameter()
        {
            ParameterName = "@GUID",
            Value = Request.QueryString["uid"]
        },
        new SqlParameter()
        {
            ParameterName = "@UserName",
            Value = FormsAuthentication.HashPasswordForStoringInConfigFile(txtConfirmNewPassword.Text,"SHA1")
        }
    };

            return ExecuteSP("sp_IsPasswordResetLinkValid", paramList);
        }

        private bool ChangeUserPassword()
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
    {
        new SqlParameter()
        {
            ParameterName = "@GUID",
            Value = Request.QueryString["uid"]
        },
        new SqlParameter()
        {
            ParameterName = "@Password",
            Value = txtNewPassword.Text
        }
    };

            return ExecuteSP("sp_ChangePassword", paramList);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ResetPassword/ResetPassword.aspx");
        }
    }
}