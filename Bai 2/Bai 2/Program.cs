using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string maso, ten, diem, timkiemsv;
            QLSV qlsv = new QLSV();
            Console.Write("So Luong SV = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap MSSV = ");
                maso = Console.ReadLine();
                Console.Write("Nhap Ten = ");
                ten = Console.ReadLine();
                Console.Write("Nhap Diem = ");
                diem = Console.ReadLine();
                SinhVien sv = new SinhVien(maso, ten, diem);
                qlsv.AddLast(sv);
            }
            qlsv.PrintList();
            Console.WriteLine("0.Them dau");
            Console.WriteLine("1.Them cuoi");
            Console.WriteLine("1.Them sau Y");
            Console.Write("choose = ");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    {
                        Console.Write("Nhap MSSV = ");
                        maso = Console.ReadLine();
                        Console.Write("Nhap Ten = ");
                        ten = Console.ReadLine();
                        Console.Write("Nhap Diem = ");
                        diem = Console.ReadLine();
                        SinhVien sv = new SinhVien(maso, ten, diem);
                        qlsv.AddFirst(sv);
                    }
                    break;
                case 1:
                    {
                        Console.Write("Nhap MSSV = ");
                        maso = Console.ReadLine();
                           Console.Write("Nhap Ten = ");
                        ten = Console.ReadLine();
                        Console.Write("Nhap Diem = ");
                        diem = Console.ReadLine();
                        SinhVien sv = new SinhVien(maso, ten, diem);
                        qlsv.AddLast(sv);
                    }

                    break;
                case 2:
                    {
                        Console.Write("Tim MSSV = ");
                        timkiemsv = Console.ReadLine();

                        // Tìm sinh viên theo MSSV
                            Node FindStudent = qlsv.Find(timkiemsv);

                        if (FindStudent != null)
                            Console.WriteLine("sinh vien: " + FindStudent.Value);
                        else
                            Console.WriteLine("khong thay" + timkiemsv);

                        Console.Write("Nhap MSSV = ");
                        maso = Console.ReadLine();
                        Console.Write("Nhap Ten = ");
                        ten = Console.ReadLine();
                        Console.Write("Nhap Diem = ");
                        diem = Console.ReadLine();
                        SinhVien sv = new SinhVien(maso, ten, diem);
                        qlsv.AddAfter(FindStudent,sv);
                    }
                    break;
                case 3:
                    {
                        Console.Write("Tim MSSV = ");
                        timkiemsv = Console.ReadLine();

                        // Tìm sinh viên theo MSSV
                        Node FindStudent = qlsv.Find(timkiemsv);

                        if (FindStudent != null)
                            Console.WriteLine("sinh vien: " + FindStudent.Value);
                        else
                            Console.WriteLine("khong thay" + timkiemsv);

                        Console.Write("Nhap MSSV = ");
                        maso = Console.ReadLine();
                        Console.Write("Nhap Ten = ");
                        ten = Console.ReadLine();
                        Console.Write("Nhap Diem = ");
                        diem = Console.ReadLine();
                        SinhVien sv = new SinhVien(maso, ten, diem);
                        qlsv.AddAfter2(FindStudent, sv);
                    }
                    break;

            }
            qlsv.PrintList();
            Console.Read();
        }
    }
}
