using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchtree
{
    public class Node
    {
        public int key;  // Giá trị của nút (giá trị khóa dùng để tìm kiếm, so sánh trong BST)
        public Node left; // Con trỏ trỏ đến nút con trái (left child) của nút hiện tại
        public Node right; // Con trỏ trỏ đến nút con phải (right child) của nút hiện tại

        // Hàm tạo không tham số – khởi tạo nút không có giá trị, chỉ có con trái và phải là null
        public Node()
        {
            left = null;  // Con trái mặc định là null
            right = null; // Con phải mặc định là null
        }

        // Hàm tạo có tham số – khởi tạo nút với một giá trị khóa (aKey)
        // Cây con trái và phải mặc định là null
        public Node(int aKey)
        {
            left = null;  // Con trái mặc định là null
            right = null; // Con phải mặc định là null
            key = aKey;   // Gán giá trị khóa cho nút
        }
    }
}
