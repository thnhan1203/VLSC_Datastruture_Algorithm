using System;

// Lop dai dien cho 1 sinh vien
public class Student
{
    // ma sinh vien, ten sinh vien 2500115586 LeThanhNhan
    public string Id { get; set; }
    public string Name { get; set; }

    public Student(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"Student(Id: {Id}, Name: {Name})";
    }
}

// Lop dai dien cho 1 phan tu (Node)
public class DoubleNode
{
    public Student student;
    public DoubleNode Prev;
    public DoubleNode Next;

    public DoubleNode(Student student)
    {
        this.student = student;
        Prev = null;
        Next = null;
    }
}

// Lop quan ly danh sach lien ket doi
public class DoubleLinkedList
{
    public DoubleNode Head;
    public DoubleNode Tail;

    public DoubleLinkedList()
    {
        Head = null;
        Tail = null;
    }

    // Them phan tu vao cuoi (Add Last)
    public void AddLast(Student student)
    {
        DoubleNode newNode = new DoubleNode(student);

        if (Head == null)
        {
            Head = Tail = newNode;
            return;
        }

        Tail.Next = newNode;     // Moc tail hien tai voi node moi
        newNode.Prev = Tail;     // Moc node moi quay nguoc lai tail cu
        Tail = newNode;          // Cap nhat Tail la node moi
    }

    // Duyet danh sach tu dau den cuoi
    public void PrintForward()
    {
        DoubleNode current = Head;
        Console.Write("Tien: null <-> ");

        while (current != null)
        {
            Console.Write($"{current.student} <-> ");
            current = current.Next;
        }

        Console.WriteLine("null");
    }

    // Duyet danh sach tu cuoi ve dau (uu the cua DLL)
    public void PrintBackward()
    {
        DoubleNode current = Tail;
        Console.Write("Lui: null <-> ");

        while (current != null)
        {
            Console.Write($"{current.student} <-> ");
            current = current.Prev;
        }

        Console.WriteLine("null");
    }
}

// Chuong trinh chinh
class Program
{
    static void Main()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.AddLast(new Student("250011459", "Hai"));
        list.AddLast(new Student("250011460", "Hoang"));
        list.AddLast(new Student("250011461", "Duy"));

        list.PrintForward();
        list.PrintBackward();
    }
}
