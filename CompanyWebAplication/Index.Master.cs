using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyWebAplication
{
    public partial class Index : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var isMobile = Request.Browser.IsMobileDevice;
            if (isMobile)
            {

            }
        }

        protected void txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}