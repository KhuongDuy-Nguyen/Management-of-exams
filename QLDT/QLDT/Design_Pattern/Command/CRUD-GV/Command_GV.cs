using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class Command_GV
    {
        private Command insertGV;
        private Command updateGV;
        private Command deleteGV;
        private Command searchGV;

        public Command_GV(Command insertGV, Command updateGV, Command deleteGV, Command searchGV)
        {
            this.insertGV = insertGV;
            this.updateGV = updateGV;
            this.deleteGV = deleteGV;
            this.searchGV = searchGV;
        }
        
        public String insert()
        {
            return insertGV.excute();
        }

        public String update()
        {
            return updateGV.excute();
        }

        public String delete()
        {
            return deleteGV.excute();
        }

        public String search()
        {
            return searchGV.excute();
        }
    }
}
