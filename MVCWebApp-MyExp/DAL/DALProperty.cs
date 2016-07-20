using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace MVCWebApp_MyExp.DAL
{
    public class DALProperty : DataAccess
    {
        public DataSet functionName()
        {
            using (DbCommand ObjCmd = DbDAL.GetStoredProcCommand("YourStoredProcName"))
            {
                //DbDAL.AddInParameter(ObjCmd, "@Parameter", DbType.Int32, variable);
                    return DbDAL.ExecuteDataSet(ObjCmd);
            }
        }
    }
}