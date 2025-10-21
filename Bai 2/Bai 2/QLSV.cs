using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class QLSV
    {
        protected Node First;
        public QLSV()
        {
            First = null;
        }
        public void AddFirst(SinhVien X) //Them vao phia truoc, nhung phai co gia tri dau
        {
            if (X == null)
                return;
            Node newNode = new Node(X);
            if (First == null)
                First = newNode;
            else
            {
                newNode.Next = First;
                First = newNode;
            }
        }
        public void AddLast(SinhVien X)//Them vao phia sau
        {
            if (X == null)
                return;
            Node newNode = new Node(X);
            if (First == null)
                First = newNode;
            else
            {
                Node curNode = First;
                while (curNode.Next != null)
                    curNode = curNode.Next;
                curNode.Next = newNode;
            }
        }
        public Node AddAfter(Node node, SinhVien X)
        {
            if (node == null || X == null)
                return null;
            else
            {
                Node newNode = new Node(X);
                newNode.Next = node.Next;
                node.Next = newNode;
            }

        }
        public void PrintList()
        {
            if (First == null)
            {
                Console.WriteLine("Danh sach rong ");
                return;
            }
            Node curNode = First;
            while (curNode != null)
            {
                Console.WriteLine(curNode.Value);
                if (curNode.Next != null)
                    Console.Write("");
                curNode = curNode.Next;
            }
        }
        public Node Find(string mssv)
        {
            if (First == null || string.IsNullOrEmpty(mssv))
                return null;

            Node curNode = First;
            while (curNode != null)
            {
                if (curNode.Value.MSSV == mssv)
                    return curNode;
                curNode = curNode.Next;
            }
            return null;  // Nếu không tìm thấy
        }

    }
}
