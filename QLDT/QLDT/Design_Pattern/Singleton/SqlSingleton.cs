using System;
using System.Data;
using System.Data.SqlClient;

namespace QLDT
{
    class SqlSingleton
    {
        private static SqlSingleton uniqueInstance;
        private static readonly object lockObject = new object();

        SqlConnection cnn;
        private SqlSingleton(SqlConnection cnn)
        {
            this.cnn = cnn;
        }

        public static SqlSingleton GetInstance(String cs)
        {
            lock (lockObject)
            {
                if (uniqueInstance == null)
                {
                    SqlConnection cn = new SqlConnection(connectServer(cs));
                    uniqueInstance = new SqlSingleton(cn);
                }
                return uniqueInstance;
            }
        }
        public SqlConnection ConnectionInstance()
        {
            if (cnn.State == ConnectionState.Closed)
            {
                return cnn;
            }
            cnn.Close();
            return cnn;
        }

        public static string connectServer(string basis)
        {
            if (basis == "CS1")         //server phan tan 1
            {
                basis = @"Data Source = NATSUI\SERVER1; Initial Catalog=THI_TN;Persist Security Info=True;User ID=sa;Password=123";
            }
            else if (basis == "CS2")    //server phan tan 2
            {
                basis = @"Data Source = NATSUI\SERVER2; Initial Catalog=THI_TN;Persist Security Info=True;User ID=sa;Password=123";
            }
            else                        //server goc
            {
                basis = @"Data Source = NATSUI\SERVERMAIN; Initial Catalog = THI_TN; Persist Security Info = True; User ID = sa; Password = 123";
            }
            return basis;
        }

    }
}
