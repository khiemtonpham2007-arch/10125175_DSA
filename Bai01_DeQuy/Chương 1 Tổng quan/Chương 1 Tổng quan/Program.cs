using System;
class Program
{
    static void Bai1_1()
    {
        Console.Write("Nhập số phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0) { Console.WriteLine("Số phần tử phải lớn hơn 0."); return; }

        int[] mang = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phần tử thứ {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Các phần tử trong mảng: ");
        foreach (int x in mang) Console.Write(x + " ");

        int max = mang[0], min = mang[0];
        for (int i = 1; i < n; i++)
        {
            if (mang[i] > max) max = mang[i];
            if (mang[i] < min) min = mang[i];
        }
        Console.WriteLine("\nPhần tử lớn nhất: " + max);
        Console.WriteLine("Phần tử nhỏ nhất: " + min);
    }
    static void Bai1_2()
    {
        int n;
        do
        {
            Console.Write("Nhập một số từ 1 đến 100: ");
            n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 100) Console.WriteLine("Số không hợp lệ, nhập lại!");
        } while (n < 1 || n > 100);

        if (n % 3 == 0 && n % 5 == 0)
            Console.WriteLine("Kết quả: FizzBuzz");
        else if (n % 5 == 0)
            Console.WriteLine("Kết quả: Buzz");
        else if (n % 3 == 0)
            Console.WriteLine("Kết quả: Fizz");
        else
            Console.WriteLine("Kết quả: " + n);
    }
    static void Bai1_3()
    {
        Console.Write("Nhập một chuỗi để đảo ngược: ");
        string s = Console.ReadLine();
        char[] dayChuoi = s.ToCharArray();
        Array.Reverse(dayChuoi);
        Console.WriteLine("Chuỗi sau khi đảo: " + new string(dayChuoi));
    }
    static void Bai1_4()
    {
        Console.Write("Nhập số phần tử trong mảng: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0) { Console.WriteLine("Số phần tử phải lớn hơn 0."); return; }

        int i, j;
        int[] mang = new int[n];
        for (i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Mảng ban đầu: ");
        foreach (int x in mang) Console.Write(x + " ");
        for (i = 0; i < n - 1; i++)
            for (j = 0; j < n - i - 1; j++)
                if (mang[j] > mang[j + 1])
                {
                    int temp = mang[j];
                    mang[j] = mang[j + 1];
                    mang[j + 1] = temp;
                }

        Console.Write("\nMảng sau khi sắp xếp tăng dần: ");
        foreach (int x in mang) Console.Write(x + " ");
        Console.WriteLine();
    }
    static void Bai1_5()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0) { Console.WriteLine("Vui lòng nhập n > 0."); return; }

        Console.Write("Dãy Fibonacci đầu tiên: ");
        int a = 0, b = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }

        Console.WriteLine();
        Console.WriteLine($"Giá trị Fibonacci ở vị trí {n} là: {FibonacciThuN(n)}");
    }

    static int FibonacciThuN(int n)
    {
        if (n == 1) return 0;
        if (n == 2) return 1;
        int a = 0, b = 1, temp = 0;
        for (int i = 3; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }
        return temp;
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("--------------- CHƯƠNG 1: Tổng quan về CTDL và GT ---------------");
        Console.WriteLine("---------- Bài 1 ----------");
        Bai1_1();
        Console.WriteLine("\n---------- Bài 2 ----------");
        Bai1_2();
        Console.WriteLine("\n---------- Bài 3 ----------");
        Bai1_3();
        Console.WriteLine("\n---------- Bài 4 ----------");
        Bai1_4();
        Console.WriteLine("\n---------- Bài 5 ----------");
        Bai1_5();
    }
}