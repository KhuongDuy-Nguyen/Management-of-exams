using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.Design_Pattern.Bridge
{
    public class Update : CRUD
    {
        String table;
        String value;

        public Update(string table, string value)
        {
            this.table = table;
            this.value = value;
        }

        public string run()
        {
            return "Update " + table + " set " + value;
        }
    }
}
