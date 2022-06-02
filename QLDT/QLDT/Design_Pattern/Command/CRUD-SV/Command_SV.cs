using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class Command_SV
    {
        private Command insertSV;
        private Command updateSV;
        private Command deleteSV;
        private Command searchSV;

        public Command_SV(Command insertSV, Command updateSV, Command deleteSV, Command searchSV)
        {
            this.insertSV = insertSV;
            this.updateSV = updateSV;
            this.deleteSV = deleteSV;
            this.searchSV = searchSV;
        }
        
        public String insert()
        {
            return insertSV.excute();
        }

        public String update()
        {
            return updateSV.excute();
        }

        public String delete()
        {
            return deleteSV.excute();
        }

        public String search()
        {
            return searchSV.excute();
        }
    }
}
