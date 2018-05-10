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
            ds=dal.FillDropdownsViaXMLs(whichxml);
            return ds;
        }
    }
}
