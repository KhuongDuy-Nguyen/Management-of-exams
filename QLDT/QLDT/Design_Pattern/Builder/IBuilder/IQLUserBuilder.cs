using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public interface IQLUserBuilder
    {
        //Constructor thêm parameter cho Object sinh viên.
        QLUserBuilder AddMasv(String masv);
        QLUserBuilder AddMagv(String magv);

        QLUserBuilder AddHo(String ho);
        QLUserBuilder AddTen(String ten);
        QLUserBuilder AddHocvi(String hocvi);
        QLUserBuilder AddMakh(String makh);
        QLUserBuilder AddNgaysinh(String ngaysinh);
        QLUserBuilder AddDiachi(String diachi);
        QLUserBuilder AddMalop(String malop);


        Giaovien BuildGiaovien();
        Sinhvien BuildSinhvien();



    }
}
