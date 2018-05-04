using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GlobalConnection
    {
        public static string getConnectionString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
    }
}
