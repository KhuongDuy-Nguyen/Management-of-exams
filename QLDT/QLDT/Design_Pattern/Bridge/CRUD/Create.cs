using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.Design_Pattern.Bridge
{
    public class Create : CRUD
    {
        String table;
        String value;
        String listColumn;
        public Create(String table, String listColumn ,String value)
        {
            this.table = table;
            this.value = value;
            this.listColumn = listColumn;
        }
        
        public String run()
        {
            return "INSERT INTO " + table + " (" + listColumn + ")"   + " values('" + value + "')";
        }
    }
}
