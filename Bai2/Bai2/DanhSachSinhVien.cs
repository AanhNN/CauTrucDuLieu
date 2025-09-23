using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class DanhSachSinhVien
    {
        private List<SinhVien> dssv = new List<SinhVien>();
        public void ThemSinhVien(SinhVien sv)
        {
            dssv.Add(sv);
        }

        public void HienThiSinhVien()
        {
            foreach (var sv in dssv)
            {
                sv.XuatSinhVien();
            }
        }

    }
}
