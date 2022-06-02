using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.Design_Pattern.Bridge
{
    public class Delete : CRUD
    {
        String table;
        String value;

        public Delete(String table, String value)
        {
            this.table = table;
            this.value = value;
        }

        public string run()
        {
            return "DELETE FROM " + table + " WHERE " + value;
        }
    }
}
