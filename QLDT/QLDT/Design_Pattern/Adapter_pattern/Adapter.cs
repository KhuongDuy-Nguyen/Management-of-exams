using QLDT.Design_Pattern.Adapter_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT.Adapter_pattern
{
    public class Adapter
    {
        private AdapteeSv adaptee;

        public Adapter(AdapteeSv adaptee)
        {
            this.adaptee = adaptee;
        }

        public DataSet_SV ReadDataSV(String cs, Sinhvien sv)
        {
            return adaptee.ConvertToDataSetSinhvien(cs, sv);
        }

    }
}
