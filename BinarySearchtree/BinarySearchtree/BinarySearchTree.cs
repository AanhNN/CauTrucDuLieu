using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchtree
{
    public class BinarySearchTree
    {
        public Node root; // nút gốc của cây BST

        public BinarySearchTree() // hàm tạo, khởi tạo cây rỗng
        {
            root = null;
        }

        public void Display(Node node)
        {
            // Hiển thị giá trị của 1 nút, nếu null thì in "null"
            if (node != null)
                Console.Write(node.key.ToString() + " ");
            else
                Console.Write("null" + " ");
        }

        public void Process(Node node)
        {
            // Hàm xử lý 1 nút – ở đây chỉ in ra giá trị của nút
            Display(node);
        }

        public void PreOrder(Node aRoot) // Duyệt cây theo thứ tự NLR
        {
            // N: thăm nút hiện tại
            // L: duyệt cây con trái
            // R: duyệt cây con phải
            if (aRoot != null)
            {
                Process(aRoot);
                PreOrder(aRoot.left);
                PreOrder(aRoot.right);
            }

        }

        public void InOrder(Node aRoot) // Duyệt cây theo thứ tự LNR
        {
            // L: duyệt trái
            // N: xử lý nút
            // R: duyệt phải
            // Kết quả là dãy số tăng dần đối với BST
            if (aRoot != null)
            {
                InOrder(aRoot.left);
                Process(aRoot); // xử lý nút giữa
                InOrder(aRoot.right);
            }
        }

        public void PostOrder(Node aRoot) // Duyệt cây theo thứ tự LRN
        {
            // L: duyệt trái
            // R: duyệt phải
            // N: xử lý sau cùng
            if (aRoot != null)
            {
                PostOrder(aRoot.left);
                PostOrder(aRoot.right);
                Process(aRoot); // xử lý sau cùng
            }
        }

        // Đếm và tính tổng tất cả nút của cây bằng duyệt trước
        public void CountAndSumAllNodes(Node aRoot, ref int count, ref int sum)
        {
            if (aRoot != null)
            {
                count++;              // tăng số lượng nút
                sum += aRoot.key;    // cộng giá trị nút
                CountAndSumAllNodes(aRoot.left, ref count, ref sum);
                CountAndSumAllNodes(aRoot.right, ref count, ref sum);
            }
        }

        // Tính chiều cao cây
        // Áp dụng duyệt sau (tính chiều cao con trái, phải trước)
        public int CalTreeHeight(Node aRoot)
        {
            // Quy ước: cây rỗng có chiều cao -1
            if (aRoot == null)
                return -1;

            int h_left = CalTreeHeight(aRoot.left);    // chiều cao cây con trái
            int h_right = CalTreeHeight(aRoot.right);  // chiều cao cây con phải

            // Chiều cao = max(chều cao trái, phải) + 1
            return ((h_left > h_right) ? h_left : h_right) + 1;
        }

        // Cài đặt tìm kiếm trong BST (phương pháp lặp)
        public Node Search(int X)
        {
            Node curNode = root;
            // Tìm cho đến khi trùng khóa hoặc gặp null
            while (X != curNode.key)
            {
                if (X < curNode.key)
                    curNode = curNode.left;   // đi sang nhánh trái
                else
                    curNode = curNode.right;  // đi sang nhánh phải

                if (curNode == null)  // không tìm thấy
                    return null;
            }
            return curNode; // tìm thấy nút X
        }

        // Tìm giá trị lớn nhất trong cây (đi hết nhánh phải)
        public int FindMax(Node aRoot)
        {
            int Max = aRoot.key;
            if (aRoot.right == null)
                return Max;
            else
                return FindMax(aRoot.right);
        }

        // Tìm giá trị nhỏ nhất trong cây (đi hết nhánh trái)
        public int FindMin(Node aRoot)
        {
            int Min = aRoot.key;
            if (aRoot.left == null)
                return Min;
            else
                return FindMin(aRoot.left);
        }

        // Thêm nút vào cây BST
        public bool Add(int X)
        {
            bool result = true;
            Node newNode = new Node(X); // tạo nút mới

            // Nếu cây rỗng → đặt làm root
            if (root == null)
            {
                root = newNode;
                return result;
            }

            Node curNode = root;
            Node parentNode;

            // Tìm vị trí thích hợp để chèn
            while (true)
            {
                parentNode = curNode;

                // Nếu trùng khóa → không chèn
                if (X == curNode.key)
                {
                    result = false;
                    break;
                }

                if (X < curNode.key) // đi trái
                {
                    curNode = curNode.left;
                    if (curNode == null)
                    {
                        parentNode.left = newNode; // chèn vào trái
                        break;
                    }
                }
                else // đi phải
                {
                    curNode = curNode.right;
                    if (curNode == null)
                    {
                        parentNode.right = newNode; // chèn vào phải
                        break;
                    }
                }
            }
            return result;
        }

        // Tìm nút thế mạng khi xóa nút có 2 con
        // Nút thế mạng là nút nhỏ nhất của nhánh phải (in-order successor)
        public Node GetSubsNode(Node removeNode)
        {
            Node subsParent = removeNode;
            Node subsNode = removeNode;
            Node curNode = removeNode.right;

            // Tìm phần tử nhỏ nhất bên cây con phải → đi hết nhánh trái
            while (curNode != null)
            {
                subsParent = subsNode;
                subsNode = curNode;
                curNode = curNode.left;
            }

            // Nếu node thế mạng không phải con phải trực tiếp của node bị xóa:
            // Điều chỉnh lại liên kết
            if (subsNode != removeNode.right)
            {
                subsParent.left = subsNode.right;
                subsNode.right = removeNode.right;
            }

            return subsNode;
        }

        // Xóa một nút ra khỏi BST
        public bool Remove(int X)
        {
            Node curNode = root;      // nút hiện tại
            Node parentNode = root;   // nút cha
            bool isLeftChild = true;  // đánh dấu curNode là con trái hay phải

            // Tìm nút cần xóa
            while (curNode.key != X)
            {
                parentNode = curNode;

                if (X < curNode.key)
                {
                    isLeftChild = true;
                    curNode = curNode.left;
                }
                else
                {
                    isLeftChild = false;
                    curNode = curNode.right;
                }

                if (curNode == null) // không tìm thấy
                    return false;
            }

            // Trường hợp 1: Nút cần xóa là lá (không có con)
            if ((curNode.left == null) && (curNode.right == null))
            {
                if (curNode == root)
                    root = null; // xóa nút gốc
                else if (isLeftChild)
                    parentNode.left = null;
                else
                    parentNode.right = null;
            }
            // Trường hợp 2: Nút có 1 con trái
            else if (curNode.right == null)
            {
                if (curNode == root)
                    root = curNode.left;
                else if (isLeftChild)
                    parentNode.left = curNode.left;
                else
                    parentNode.right = curNode.left;
            }
            // Trường hợp 3: Nút có 1 con phải
            else if (curNode.left == null)
            {
                if (curNode == root)
                    root = curNode.right;
                else if (isLeftChild)
                    parentNode.left = curNode.right;
                else
                    parentNode.right = curNode.right;
            }
            // Trường hợp 4: Nút có 2 con → tìm nút thế mạng
            else
            {
                Node subsNode = GetSubsNode(curNode); // node thế mạng (in-order successor)

                if (curNode == root)
                    root = subsNode;
                else if (isLeftChild)
                    parentNode.left = subsNode;
                else
                    parentNode.right = subsNode;

                // Gắn lại cây con trái của nút bị xóa vào node thế mạng
                subsNode.left = curNode.left;
            }
            return true;
        }
    }
}
