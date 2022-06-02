using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    class HT_InPhieuDiem : ISystem
    {
        String auth;
        String name;
        String basis;

        public HT_InPhieuDiem(String auth, String basis, String name)
        {
            this.auth = auth;
            this.name = name;
            this.basis = basis;
        }
        public override Form Run()
        {
            return new InPhieuDiem(basis, name);
        }
    }
}
