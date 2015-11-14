using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TWMe.DAO
{
    public class BaseDAO
    {
        private static string connectionString = @"Data Source=(DESCRIPTION=
                                            (ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost )(PORT=1521)))
                                            (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));
                                            User Id=system ;Password=@cesso";

        public static OracleConnection GetConnection()
        {
            return new OracleConnection(BaseDAO.connectionString);
        }

    }
}


