using System;

namespace DSA_Session07_SingleLinkedList
{
    // 1. DINH NGHIA CLASS NODE: MOT MAT XICH TRONG DANH SACH
    public class Node
    {
        public int Data;    // Du lieu cua mat xich
        public Node Next;   // "Soi day" tro den mat xich tiep theo

        // Constructor: Khoi tao gia tri khi tao Node moi
        public Node(int data)
        {
            Data = data;
            Next = null;    // Mac dinh sinh ra chua noi voi ai ca
        }
    }

    // 2. DINH NGHIA CLASS SINGLE LINKED LIST: DANH SACH LIEN KET DON
    public class SingleLinkedList
    {
        private Node head;  // "Cai dau" cua danh sach, noi bat dau

        // Constructor: Khoi tao danh sach rong
        public SingleLinkedList()
        {
            head = null;    // Ban dau chua co mat xich nao
        }

        // 3. PHUONG THUC THEM MAT XICH VAO CUOI DANH SACH
        public void AddLast(int data)
        {
            Node newNode = new Node(data); // Tao mat xich moi voi du lieu

            if (head == null) // O(1)
            {
                head = newNode; // Neu danh sach rong, newNode tro thanh head
                return;
            }

            Node current = head; // Bat dau tu head
            while (current.Next != null) // O(n)
            {
                current = current.Next; // Di tiep den mat xich cuoi cung
            }
            current.Next = newNode; // Noi mat xich cuoi cung voi newNode
        }

        // 4. PHUONG THUC IN RA DANH SACH
        public void PrintList()
        {
            Node current = head; // Bat dau tu head
            while (current != null) // O(n)
            {
                Console.Write(current.Data + " -> "); // In du lieu cua mat xich
                current = current.Next; // Di tiep den mat xich tiep theo
            }
            Console.WriteLine("null"); // Ket thuc danh sach
        }
    }

    // 5. CHUONG TRINH CHINH: TEST DANH SACH LIEN KET DON
    class Program
    {
        static void Main(string[] args)
        {
            // Tao mot instance cua SingleLinkedList de quan ly danh sach
            SingleLinkedList list = new SingleLinkedList();
            Console.WriteLine("Chao mung den voi danh sach lien ket don!");

            // Tao menu de nguoi dung chon thao tac
            while (true)
            {
                Console.WriteLine("\nVui long chon thao tac:");
                Console.WriteLine("1. Them mat xich vao cuoi danh sach");
                Console.WriteLine("2. In ra danh sach hien tai");
                Console.WriteLine("3. Xoa danh sach");
                Console.WriteLine("4. Thoat");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": // Them mat xich vao cuoi danh sach
                        Console.Write("Nhap du lieu cho mat xich moi: ");
                        int data = int.Parse(Console.ReadLine());
                        list.AddLast(data);
                        break;

                    case "2": // In ra danh sach hien tai
                        list.PrintList();
                        break;

                    case "3": // Xoa danh sach bang cach tao mot instance moi, "danh roi" instance cu
                        list = new SingleLinkedList();
                        Console.WriteLine("Danh sach da duoc xoa.");
                        break;

                    case "4": // Thoat khoi chuong trinh
                        return; // Ket thuc ham Main

                    default: // Neu nguoi dung nhap lua chon khong hop le
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }
}
