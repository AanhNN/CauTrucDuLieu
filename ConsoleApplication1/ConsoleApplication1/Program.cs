using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        SinhVien sv;
        QuanLySinhVien qlsv;
        static void NhapDiem(ref int[] arrDiem, ref int n)
        {
            arrDiem = new int[n];//Khởi tạo mảng 
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap Diem = ");//Hàm xuất
                arrDiem[i] = int.Parse(Console.ReadLine());//int.Parse là chuyển đỗi chuỗi dữ liệu đã nhập thành số nguyên
                                                           //Hàm nhập
            }
            XuatDiem(ref arrDiem, ref n);
        }

        static void XuatDiem(ref int[] arrDiem,ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Diem = {arrDiem[i]}");
            }

        }
        static void ThemDiem(ref int[] arrDiem, ref int n)
        {
            Console.Write("Nhap K = ");
            int k = int.Parse(Console.ReadLine());
            int[] arrMoi = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                arrMoi[i] = arrDiem[i];
            }
            arrMoi[n] = k;
            n++;//tăng kích thước mảng. 
            arrDiem = arrMoi;
            XuatDiem(ref arrDiem, ref n);
        }
        static void XoaDiem(ref int[] arrDiem, ref int n)
        {
            Console.Write("Nhap K = ");
            int k = int.Parse(Console.ReadLine());
            int[] arrMoi = new int[n - 1];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == k) continue; // Bỏ qua vị trí k (xóa phần tử tại k)
                arrMoi[j] = arrDiem[i];
                j++;
            }
            n--; // giảm kích thước mảng
            arrDiem = arrMoi; // cập nhật mảng
            XuatDiem(ref arrDiem, ref n);
        }
        static void Main(string[] args)
        {
            int n;
            int[] arrDiem = null;
            Console.Write("Nhap n = ");
            n = int.Parse(Console.ReadLine());
            NhapDiem(ref arrDiem, ref n);
            ThemDiem(ref arrDiem, ref n);
            XoaDiem(ref arrDiem, ref n);
            Console.WriteLine("Nhan phim bat ky de thoat...");// Dừng màn hình console trước khi thoát
            Console.ReadKey();//Nhấn 1 phím bất kì để thoát màn hình
        }
    }
}
