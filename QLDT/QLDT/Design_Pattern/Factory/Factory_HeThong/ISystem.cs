using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    abstract class ISystem : IMenuSystem
    {
        public abstract Form Run();
    }
}
