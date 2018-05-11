using BodyObject;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class MasterBLL
    {
        public DataSet FillDropdownsViaXMLs(string whichxml)
        {
            DataSet ds = new DataSet();
            MasterDAL dal = new MasterDAL();
            ds = dal.FillDropdownsViaXMLs(whichxml);
            return ds;
        }
        public int CreateMyAccountSignup(EndUserDetails eu)
        {
            int status = -1;
            MasterDAL dal = new MasterDAL();
            dal.CreateMyAccountSignup(eu);
            return status;
        }
        public string GetUIDGenerated(string LoginId_UserName)
        {
            string UIDGenerated = null;
            MasterDAL dal = new MasterDAL();
            UIDGenerated = dal.GetUIDGenerated(LoginId_UserName);
            return UIDGenerated;
        }
    }
}
