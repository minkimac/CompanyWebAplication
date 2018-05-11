using BodyObject;
using BodyObject.BaseClass;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyWebAplication
{
    public partial class Index : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                //Fill all the dropdowns via XMLs
              
            }
        }


        protected void BtnSignupModalSubmit_Click(Object sender, EventArgs e)
        {
           
            string encryptedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Value,"SHA1");
            EndUserDetails endUser = new EndUserDetails();
            endUser.EmailId = txtEmailAddress.Value;
            endUser.LoginId = txtLoginID_Username.Value.ToString();
            endUser.Password = encryptedPwd;
            endUser.Personfirstname = txtFirstName.Value;
            endUser.PersonMiddleName = txtMiddleName.Value;
            endUser.PersonLastName = txtLastName.Value;
            endUser.PersonGender = ddlGender.Value;
            endUser.AddressEntity = new AddressEntity()
            {
                Flat_House_Number= txtFlat_House_no.Value,
                Locality_Street= ddlStreet_Locality.Value,
                
                
                   

                };
            Response.Write("<script>alert('Called');</script>");
        }
    }
}