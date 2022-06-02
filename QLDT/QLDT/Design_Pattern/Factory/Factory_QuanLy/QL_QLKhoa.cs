using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    class QL_QLKhoa : IManager
    {
        String basis;
        public QL_QLKhoa(String basis)
        {
            this.basis = basis;
        }

        public override Form Run()
        {
            return new QLKhoa(basis);
        }

    }
}
