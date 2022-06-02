using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    class QL_QLMH : IManager
    {
        String basis;
        public QL_QLMH(String basis)
        {
            this.basis = basis;
        }

        public override Form Run()
        {
            return new QLMonHoc(basis);
        }
    }
}
