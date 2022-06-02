using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.Design_Pattern.Bridge
{
    public class BridgeQLKhoa : HeThong
    {

        public BridgeQLKhoa(CRUD crud) : base(crud) { }
        

        public override String delete()
        {
            return  crud.run();
        }

        public override String insert()
        {
            return crud.run();
        }

        public override String select()
        {
            return crud.run();
        }

        public override String update()
        {
            return crud.run();
        }
    }
}
