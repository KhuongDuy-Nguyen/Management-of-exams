using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDT;

namespace QLDT
{
    public class serverConnection
    {
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
