using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        DanhSachSinhVien dssv = new DanhSachSinhVien();
        public void nhapSinhVien()
        {
            Console.Write("Nhap so luong Sinh Vien: ");
            int n = int.Parse(Console.ReadLine()); // Nhập số lượng sinh viên

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap MSSV cho Sinh Vien {i + 1}: ");
                string mssv = Console.ReadLine(); // Nhập MSSV

                Console.Write($"Nhap Ten Sinh Vien {i + 1}: ");
                string tenSV = Console.ReadLine(); // Nhập tên sinh viên

                // Tạo đối tượng SinhVien và thêm vào danh sách
                SinhVien sv = new SinhVien(mssv, tenSV);
                dssv.ThemSinhVien(sv);
            }
        }
        public  void XuatSinhVien()
        {
            Console.WriteLine("Danh Sach Sinh Vien:");
            dssv.HienThiSinhVien();
        }
        static void Main(string[] args)
        {
            int choice;
            Program program = new Program();
            program.nhapSinhVien();
            program.XuatSinhVien();
            Console.WriteLine("\nChọn thao tác:");
            Console.WriteLine("1. Tim Ten ");
            Console.WriteLine("2. Xóa điểm");
            Console.Write("Lựa chọn của bạn: ");
            int choose = int.Parse(Console.ReadLine());
            SearchSort search = new SearchSort();
            if (choose == 1)
            {
                Console.Write("Nhap Ten Can Tim : ");
                int X = int.Parse(Console.ReadLine());
                search.SeqSearch(dssv, )
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
            }
            Console.WriteLine("Nhan phim bat ky de thoat...");// Dừng màn hình console trước khi thoát
            Console.ReadKey();//Nhấn 1 phím bất kì để thoát màn hình
        }
    }
}
