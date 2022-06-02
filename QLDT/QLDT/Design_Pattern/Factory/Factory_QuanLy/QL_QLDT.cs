using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
     class QL_QLDT : IManager
    {
        String basis;
        String name;
        public QL_QLDT(String basis, String name)
        {
            this.basis = basis;
            this.name = name;
        }
        
        public override Form Run()
        {
            return new QLDeThi(basis, name);
        }
    }
}
