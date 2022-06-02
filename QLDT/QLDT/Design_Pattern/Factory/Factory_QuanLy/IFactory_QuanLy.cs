using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    class IFactory_QuanLy : MenuAbstractFactory
    {
        public override IMenuSystem LoadSystem(Menu_Type type, String auth, String name, String basis)
        {
            switch (type)
            {
                case Menu_Type.QLSV:
                    return new QL_QLSV(basis);
                case Menu_Type.QLGV:
                    return new QL_QLGV(basis);
                case Menu_Type.QLKHOA:
                    return new QL_QLKhoa(basis);
                case Menu_Type.QLMH:
                    return new QL_QLMH(basis);
                case Menu_Type.QLLOP:
                    return new QL_QLLop(basis);
                case Menu_Type.QLDT:
                    return new QL_QLDT(basis, name);

                default:
                    return null;
            }
        }
    }
}
