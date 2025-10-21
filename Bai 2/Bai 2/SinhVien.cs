using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class SinhVien
    {
        public string MSSV
        {
            get;
            set;
        }

        public string TenSV
        {
            get;
            set;
        }

        public string DiemSV
        {
            get;
            set;
        }

        public SinhVien(string mssv, string tensv, string diemsv)
        {
            MSSV = mssv;
            TenSV = tensv;
            DiemSV = diemsv;
        }

        public override string ToString()
        {
            return $"MSSV: {MSSV} - Ten SV: {TenSV} - Diem SV: {DiemSV}";
        }
    }
    class Node
    {
        public SinhVien Value;
        public Node Next;
        public Node()
        {
            Value = null;
            Next = null;
        }
        public Node(SinhVien val)
        {
            Value = val;
            Next = null;
        }
    }
}
