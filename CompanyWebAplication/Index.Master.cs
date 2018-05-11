using BodyObject;
using BodyObject.BaseClass;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyWebAplication
{
    public partial class Index : System.Web.UI.MasterPage
    {
        MasterBLL bll = new MasterBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                //Fill all the dropdowns via XMLs
              
            }
        }


        protected void BtnSignupModalSubmit_Click(Object sender, EventArgs e)
        {
            string encryptedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Value, "SHA1");
            EndUserDetails eu = new EndUserDetails() {
                EmailId = txtEmailAddress.Value,
                LoginID_Username = txtLoginID_Username.Value.ToString(),
                Password = encryptedPwd,
                Personfirstname = txtFirstName.Value,
                PersonMiddleName = txtMiddleName.Value,
                PersonLastName = txtLastName.Value,
                PersonGender = ddlGender.Value,
                AddressEntity = new AddressEntity()
                {
                    Flat_House_Number = txtFlat_House_no.Value,
                    Locality_Street = ddlStreet_Locality.Value,
                    LocalityId = ddlStreet_Locality.DataValueField,
                    City = ddlCities.DataTextField,
                    CityId = ddlCities.DataValueField,
                    State = "UP",
                    StateId = "1",
                    Country = ddlCountry.DataValueField,
                    Zipcode = txtZipcode.Value,
                    LandMark = txtLandmark.Value
                },
                PersonContactNumber = txtMobileNumber.Value,
                LandLine = txtLandlineNumber.Value,
                UserType = "EU"
                };
            string UIDGenerated=bll.GetUIDGenerated(eu.LoginID_Username);
            int status=bll.CreateMyAccountSignup(eu);
            SendActivateAccountEmail(eu.EmailId,eu.LoginID_Username, UIDGenerated);
            Response.Write("<script>alert('Called');</script>");
        }

        private void SendActivateAccountEmail(string ToEmail, string LoginID_Username, string UniqueId)
        {
            try
            {
                string s = HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority + "/";
                MailMessage mailMessage = new MailMessage("modi.akashbusinesss007@gmail.com", ToEmail);
                StringBuilder sbEmailBody = new StringBuilder();
                sbEmailBody.Append("Dear " + LoginID_Username + ",<br/><br/>");
                sbEmailBody.Append("Please click on the following link to Activate Your Account");
                sbEmailBody.Append("<br/>");
                sbEmailBody.Append(s + "WebForm1.aspx?uid=" + UniqueId);
                sbEmailBody.Append("<br/><br/>");
                sbEmailBody.Append("<b>Nut'Screw Pvt. Ltd</b>");

                mailMessage.IsBodyHtml = true;

                mailMessage.Body = sbEmailBody.ToString();
                mailMessage.Subject = "Activate Your Account";
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.Credentials = new System.Net.NetworkCredential()
                {
                    UserName = "modi.akashbusinesss007@gmail.com",
                    Password = "Password@1234567"
                };

                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
            }          
           
            catch (Exception)
            {
                Response.Write("<script>alert('MailNotSent');</script>");
                HddnMailVerificationStatus.Value = "0";
                throw;
            }
            
        }
    }
}