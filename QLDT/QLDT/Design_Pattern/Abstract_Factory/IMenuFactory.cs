using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    class IMenuFactory
    {
        public static MenuAbstractFactory GetFactory(Factory_Type FactoryType) {
            switch (FactoryType) {
                case Factory_Type.QUANLY:
                    return new IFactory_QuanLy();
                case Factory_Type.HETHONG:
                    return new IFactory_HeThong();
                default:
                    return null;
            }
        }
    }
}
