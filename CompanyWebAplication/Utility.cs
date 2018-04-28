using System;
using System.Data;
using System.Data.Sql;
using System.Configuration;

namespace MyConnection
{
    public static class Utility
    {

        //For connection string configuration.
       public static string ConnectionString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
    }
}