using System;
using System.Data;
using System.Data.SqlClient;
using BodyObject;

namespace DataAccessLayer
{
    public class MasterDAL : GlobalConnection
    {

        public DataSet FillDropdownsViaXMLs(string whichxml)
        {
            DataSet ds = new DataSet();
            //
            whichxml = whichxml.Remove(71);
            string x = whichxml + "Assets\\GlobalXMLs\\Cities.xml";
            // C: \Users\Akash\Source\Repos\CompanyWebAplication2\CompanyWebAplication\Cities.xml\Assets\GlobalXMLs
            ds.ReadXml(x);

            return ds;
        }
        public int CreateMyAccountSignup(EndUserDetails eu)
        {
            int status = -1;
            try
            {
                SqlParameter[] sqlPara = new SqlParameter[20];
                sqlPara[0] = new SqlParameter("@LoginId_UserName", eu.LoginID_Username);
                sqlPara[1] = new SqlParameter("@Password", eu.Password);
                sqlPara[2] = new SqlParameter("@FirstName", eu.Personfirstname);
                sqlPara[3] = new SqlParameter("@MiddleName", eu.PersonMiddleName);
                sqlPara[4] = new SqlParameter("@LastName", eu.PersonLastName);
                sqlPara[5] = new SqlParameter("@ContactNumberCSV", eu.PersonContactNumber);
                sqlPara[6] = new SqlParameter("@Flat_House_Number", eu.PersonContactNumber);
                sqlPara[7] = new SqlParameter("@Locality_Street", eu.addressEntity.Locality_Street);
                sqlPara[8] = new SqlParameter("@City", eu.addressEntity.City);
                sqlPara[9] = new SqlParameter("@CityCode", eu.addressEntity.CityId);
                sqlPara[10] = new SqlParameter("@LocalityCode", eu.addressEntity.LocalityId);
                sqlPara[11] = new SqlParameter("@LandMark", eu.addressEntity.LandMark);
                sqlPara[12] = new SqlParameter("@Zipcode", eu.addressEntity.Zipcode);
                sqlPara[13] = new SqlParameter("@State", eu.addressEntity.State);
                sqlPara[14] = new SqlParameter("@StateCode", eu.addressEntity.StateId);
                sqlPara[15] = new SqlParameter("@Country", eu.addressEntity.Country);
                sqlPara[16] = new SqlParameter("@Gender", eu.PersonGender);
                sqlPara[17] = new SqlParameter("@EmailId", eu.EmailId);
                sqlPara[18] = new SqlParameter("@UserCreatedWhen", DateTime.Now);
                sqlPara[19] = new SqlParameter("@CountryId", "19000");
                status = DataAccess.ExecuteNonQuery("sp_EndUser_Insert__SignUp_createAccount", sqlPara);
            }
            catch (Exception)
            {
                throw;
            }
            //ExecuteNonQuery(string commandText, params SqlParameter[] sqlParameters);
            return status;
        }
        public string GetUIDGenerated(string LoginId_UserName)
        {
            string UIDGenerated = null;
            DataAccess.GetUIDGenerated(LoginId_UserName);
            return UIDGenerated;
        }
    }
}
