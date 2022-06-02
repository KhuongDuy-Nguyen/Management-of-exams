using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    abstract class MenuAbstractFactory
    {
        public abstract IMenuSystem LoadSystem(Menu_Type type, String auth, String name, String basis);
        
    }
}
