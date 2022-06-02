using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class Search_SV : Command
    {
        private CRUD_SV crud;

        public Search_SV(CRUD_SV crud)
        {
            this.crud = crud;
        }

        public String excute()
        {
            return crud.searchSV();
        }
    }
}
