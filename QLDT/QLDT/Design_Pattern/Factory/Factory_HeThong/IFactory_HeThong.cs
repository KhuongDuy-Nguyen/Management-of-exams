using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    class IFactory_HeThong : MenuAbstractFactory
    {
        
        public override IMenuSystem LoadSystem(Menu_Type type, String auth, String name, String basis)
        {
            switch (type)
            {
                case Menu_Type.LAMBAITHI:
                    return new HT_ChuanBiThi(auth, basis, name);
                case Menu_Type.CHUANBITHI:
                    return new HT_ChuanBiThi(auth, basis, name);
                case Menu_Type.LICHSUTHI:
                    return new HT_LichSuThi(auth, basis, name);
                case Menu_Type.INPHIEUDIEM:
                    return new HT_InPhieuDiem(auth, basis, name);
                default:
                    return null;
            }
        }
    }
}
