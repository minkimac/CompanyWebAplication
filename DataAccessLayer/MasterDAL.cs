using System.Data;

namespace DataAccessLayer
{
    public class MasterDAL: GlobalConnection
    {
        public DataSet FillDropdownsViaXMLs(string whichxml)
        {
            DataSet ds = new DataSet();
            //
            whichxml=whichxml.Remove(71);
            string x = whichxml + "Assets\\GlobalXMLs\\Cities.xml";
               // C: \Users\Akash\Source\Repos\CompanyWebAplication2\CompanyWebAplication\Cities.xml\Assets\GlobalXMLs
            ds.ReadXml(x);
            
            return ds;
        }
    }
}
