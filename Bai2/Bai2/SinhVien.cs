using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class SinhVien
    {
        public string MSSV { get; set; }
        public string TenSV { get; set; }

        public SinhVien (string mssv, string tensv)
        {
            MSSV = mssv;
            TenSV = tensv;
        }
        public void XuatSinhVien()
        {
            Console.WriteLine($"MSSV : {MSSV}   TenSV : {TenSV}");
        }
    }
}
