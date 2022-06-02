using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    class QL_QLSV : IManager
    {
        String basis;
        public QL_QLSV(String basis)
        {
            this.basis = basis;
        }

        public override Form Run() {
            return new QLSV(basis);
        }
    }
}
