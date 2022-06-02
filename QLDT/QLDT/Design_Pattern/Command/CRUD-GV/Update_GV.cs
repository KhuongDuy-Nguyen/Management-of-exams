using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class Update_GV : Command
    {
        private CRUD_GV crud;

        public Update_GV(CRUD_GV cruid)
        {
            this.crud = cruid;
        }


        public String excute()
        {
            return crud.updateGV();
        }
    }
}
