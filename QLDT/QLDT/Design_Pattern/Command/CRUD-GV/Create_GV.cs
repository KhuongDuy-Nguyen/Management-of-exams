using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class Create_GV : Command
    {
        private CRUD_GV crud;

        public Create_GV(CRUD_GV cruid)
        {
            this.crud = cruid;
        }

        public String excute()
        {
            return crud.insertGV();
        }
    }
}
