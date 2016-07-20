using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Configuration;

namespace MVCWebApp_MyExp.DAL
{
    public class DataAccess
    {
        protected Database DbDAL = new SqlDatabase(ConfigurationManager.ConnectionStrings["MVCWebAppExp"].ConnectionString);
    }
}