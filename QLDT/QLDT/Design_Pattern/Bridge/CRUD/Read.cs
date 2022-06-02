using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.Design_Pattern.Bridge
{
    public class Read : CRUD
    {
        String table;
        String value;

        public Read(String table, String value)
        {
            this.table = table;
            this.value = value;
        }

        public string run()
        {
            return "select * from " + table + " where " + value;
        }
    }
}
