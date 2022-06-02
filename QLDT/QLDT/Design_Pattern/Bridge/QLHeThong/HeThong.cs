using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.Design_Pattern.Bridge
{
    public abstract class HeThong
    {
        protected CRUD crud;
        
        public HeThong(CRUD crud)
        {
            this.crud = crud;
        }
        
        public abstract String insert();
        public abstract String update();
        public abstract String delete();
        public abstract String select();
        
    }
}
