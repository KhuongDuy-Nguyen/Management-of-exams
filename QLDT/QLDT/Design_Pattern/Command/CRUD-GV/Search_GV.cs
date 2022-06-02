using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class Search_GV : Command
    {
        private CRUD_GV crud;

        public Search_GV(CRUD_GV crud)
        {
            this.crud = crud;
        }

        public String excute()
        {
            return crud.searchGV();
        }
    }
}
