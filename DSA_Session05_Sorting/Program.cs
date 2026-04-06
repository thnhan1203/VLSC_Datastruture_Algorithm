using System;
namespace DSA_Session05_Sortings;
class Program
{
    static void Main(string[] args)
    {
        // Nhập mảng từ người dùng
        int[] arr = InputArray();
        /// Tạo bản sao của mảng để sử dụng cho thuật toán khác
        int[] arrCopy = (int[])arr.Clone();
        Console.WriteLine("Mảng ban đầu:");
        PrintArray(arr);
        BubbleSort(arr);
        Console.WriteLine("Mảng sau khi sắp xếp (Bubble Sort):");
        PrintArray(arr);
        InsertionSort(arrCopy);
        Console.WriteLine("Mảng sau khi sắp xếp (Insertion Sort):");
        PrintArray(arrCopy);
    }
    // Hàm để nhập mảng từ người dùng
    private static int[] InputArray()
    {
        Console.WriteLine("Nhập số lượng phần tử:");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("nhập một số nguyên hợp lệ:");
        }
        int[] arr = new int[n];
        Console.WriteLine("Nhập các phần tử:");
        for (int i = 0; i < n; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("nhập một số nguyên hợp lệ:");
            }
        }
        return arr;
    }
    // Hàm để in mảng
    private static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    // 3.1 Bubble Sort(Sắp xếp nổi bọt)
    // Nguyen ly: So sanh tung cap phan tu lien ke va hoan doi neu chung khong theo thu tu dung
    // Qua trinh: nay lap lai cho den khi khong con cap nao can hoan doi nua
    // Cach hoat dong: Bat dau tu phan tu dau tien
    // So sanh no voi phan tu tiep theo va hoan doi neu can
    // Do phuc tap: 0(n ^ 2) trong truong hop xau nhat
    // 0(n) trong truong hop tot nhat (khi mang da duoc sap xep)
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        int swapCount = 0;
        for (int i = 0;i < n - 1;i++)
        // Duyet qa tat ca cac phan tu,tru phan tu cuoi cung
        {
        for (int j = 0;j < n - 1;j++)
        // So sanh phan tu hien tai voi phan tu tiep theo
        {
        if(arr[j] > arr[j + 1])
        // Neu phan tu hien tai lon hon phan tu tiep theo thi hoan doi
        {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
            swapCount++;
                }
            }
        }
        Console.WriteLine($"Bubble Sort ton (swapCount) lan hoan doi");
    }
    // 3.2 Insertion Sort(Sắp xếp chèn)
    // Nguyen ly: Xay dung mang da sap xep bang cach chen tung phan tu vao vi tri dung cua no
    // Cach hoat dong: Bat dau tu phan tu thu hai
    // so sanh no voi phan tu truoc do va chen no vao vi tri dung
    // Do phuc tap: 0(n ^ 2) trong truong hop xau nhat
    // 0(n) trong truong hop tot nhat (khi mang da duoc sap xep)
    static void InsertionSort(int[] arr)
    {
        int swapCount = 0;
        int n = arr.Length;
        for (int i = 1;i < n;i++) // bat dau tu phan tu thu hai
        {
            int key = arr[i]; // luu gia tri cua phan tu hien tai
            int j = i - 1; // bat dau so sanh tu phan tu truoc do
            // Di chuyen cac phan tu lon hon key sang phai
            while (j >= 0 && arr[j] > key) // so sanh key voi cac phan tu truoc do
            // Neu phan tu truoc do lon hon key thi di chuyen no sang phai
            {
                arr[j + 1] = arr[j]; // di chuyen phan tu sang phai
                j--; // di chuyen chi so sang trai
                swapCount++;
            }
            arr[j + 1] = key; // chen key vao vi tri dung
        }
        Console.WriteLine($"Insertion Sort ton (swapCount) lan hoan doi");
    }
}

