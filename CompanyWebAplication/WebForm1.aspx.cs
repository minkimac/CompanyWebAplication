using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using MyConnection;

namespace CompanyWebAplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = Utility.ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
            }
            
            



        }
    }
}