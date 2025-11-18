using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchtree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree(); // Khởi tạo cây tìm kiếm nhị phân rỗng
            Console.Write("Cay Tim Kiem Nhi Phan"); // In ra thông báo về loại cây
            Console.Write("\nNhap so nut: "); // Yêu cầu người dùng nhập số lượng nút sẽ thêm vào cây

            int N = Convert.ToInt32(Console.ReadLine()); // Đọc số lượng nút cần thêm vào cây
            int x; // Biến dùng để lưu giá trị của từng nút

            // Thêm N nút vào cây, mỗi nút có một giá trị khóa
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap Gia tri khoa thu {0}: ", i + 1); // Yêu cầu người dùng nhập giá trị cho nút thứ i+1
                x = Convert.ToInt32(Console.ReadLine()); // Đọc giá trị nút
                tree.Add(x); // Thêm nút vào cây
            }

            // Duyệt cây theo thứ tự trước (PreOrder) và in ra
            Console.Write("\n\nDuyet Thu Tu Truoc: ");
            tree.PreOrder(tree.root); // Duyệt theo thứ tự PreOrder (NLR)

            // Duyệt cây theo thứ tự giữa (InOrder) và in ra
            Console.Write("\n\nDuyet thu tu giua: ");
            tree.InOrder(tree.root); // Duyệt theo thứ tự InOrder (LNR)

            // Duyệt cây theo thứ tự sau (PostOrder) và in ra
            Console.Write("\n\nDuyet thu tu sau: ");
            tree.PostOrder(tree.root); // Duyệt theo thứ tự PostOrder (LRN)

            // Tính và in chiều cao của cây
            Console.Write("\nChieu cao cay: {0} ", tree.CalTreeHeight(tree.root)); // Tính chiều cao cây

            // Tìm giá trị lớn nhất trong cây và in ra
            Console.Write("\nGia tri nut Max: {0} ", tree.FindMax(tree.root)); // Tìm giá trị lớn nhất

            // Tìm giá trị nhỏ nhất trong cây và in ra
            Console.Write("\nGia tri nut Min: {0} ", tree.FindMin(tree.root)); // Tìm giá trị nhỏ nhất

            int countAll = 0; // Biến đếm số lượng nút trong cây
            int sumAll = 0;   // Biến tính tổng các giá trị khóa của các nút

            // Tính tổng và đếm tất cả các nút trong cây
            tree.CountAndSumAllNodes(tree.root, ref countAll, ref sumAll);

            // In ra giá trị trung bình của tất cả các nút
            Console.Write("\nGia tri trung binh cua tat ca cac nut = {0}", (float)sumAll / countAll); // Tính trung bình các nút

            // Yêu cầu người dùng nhập giá trị nút muốn tìm kiếm
            Console.Write("\nNhap Gia tri nut muon tim: ");
            int X = Convert.ToInt32(Console.ReadLine()); // Đọc giá trị khóa của nút cần tìm

            // Tìm kiếm nút trong cây và in kết quả
            if (tree.Search(X) != null) // Nếu nút tìm thấy
                Console.Write("Nut {0} tim thay", X); // In ra thông báo nút tìm thấy
            else
                Console.Write("Nut {0} khong tim thay", X); // Nếu không tìm thấy, in ra thông báo không tìm thấy

            // Yêu cầu người dùng nhập giá trị nút muốn xóa
            Console.Write("\nNhap gia tri nut muon huy: ");
            int x1 = Convert.ToInt32(Console.ReadLine()); // Đọc giá trị nút cần xóa

            // Xóa nút khỏi cây
            tree.Remove(x1);

            // Duyệt cây theo thứ tự trước (PreOrder) sau khi xóa xong
            Console.Write("duyet thu tu truoc sau huy {0}\t", x1); // In ra thông báo trước khi duyệt cây
            tree.PreOrder(tree.root); // Duyệt cây sau khi xóa nút

            // Yêu cầu người dùng nhập giá trị nút muốn xóa tiếp
            Console.Write("\nNhap gia tri nut muon huy: ");
            int x2 = Convert.ToInt32(Console.ReadLine()); // Đọc giá trị nút cần xóa tiếp

            // Xóa nút thứ hai khỏi cây
            tree.Remove(x2);

            // Duyệt cây theo thứ tự trước (PreOrder) sau khi xóa xong nút thứ hai
            Console.Write("duyet thu tu truoc sau huy {0}\t", x2); // In ra thông báo trước khi duyệt cây
            tree.PreOrder(tree.root); // Duyệt cây sau khi xóa nút thứ hai

            Console.Read(); // Dừng màn hình để người dùng xem kết quả
        }
    }
}
