using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class Create_SV : Command
    {
        private CRUD_SV cruid;

        public Create_SV(CRUD_SV cruid)
        {
            this.cruid = cruid;
        }

        public String excute()
        {
            return cruid.insertSV();
        }
    }
}
