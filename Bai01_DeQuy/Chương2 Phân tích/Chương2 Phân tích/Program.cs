using System;
using System.Diagnostics;
class Program
{
    static int demThapHaNoi;
    static void Bai2_1()
    {
        Console.Write("Nhập số đĩa: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0) { Console.WriteLine("Số đĩa phải lớn hơn 0."); return; }
        demThapHaNoi = 0;
        HaNoi(n, 'A', 'B', 'C');
        Console.WriteLine("Tổng số lần chuyển: " + demThapHaNoi);
    }

    static void HaNoi(int n, char A, char B, char C)
    {
        if (n == 1)
        {
            demThapHaNoi++;
            Console.WriteLine($"Chuyển đĩa 1 từ {A} sang {C}");
            return;
        }
        HaNoi(n - 1, A, C, B);
        demThapHaNoi++;
        Console.WriteLine($"Chuyển đĩa {n} từ {A} sang {C}");
        HaNoi(n - 1, B, A, C);
    }
    static void Bai2_2()
    {
        int[] kichThuoc = { 1000, 100000, 1000000, 10000000 };
        foreach (int n in kichThuoc)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++) a[i] = i * 2;
            int canTim = -1;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int lan = 0; lan < 10; lan++) TimTuanTu(a, canTim);
            sw.Stop();
            long tick1 = sw.ElapsedTicks;

            sw.Restart();
            for (int lan = 0; lan < 10; lan++) TimNhiPhan(a, canTim);
            sw.Stop();
            long tick2 = sw.ElapsedTicks;

            Console.WriteLine($"n = {n}: Tuần tự = {tick1} ticks, Nhị phân = {tick2} ticks");
        }
    }

    static int TimTuanTu(int[] a, int x)
    {
        for (int i = 0; i < a.Length; i++)
            if (a[i] == x) return i;
        return -1;
    }

    static int TimNhiPhan(int[] a, int x)
    {
        int dau = 0, cuoi = a.Length - 1;
        while (dau <= cuoi)
        {
            int giua = dau + (cuoi - dau) / 2;
            if (a[giua] == x) return giua;
            else if (a[giua] < x) dau = giua + 1;
            else cuoi = giua - 1;
        }
        return -1;
    }
    static void Bai2_3()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập một số n để kiểm tra: ");
        int n = int.Parse(Console.ReadLine());
        bool KT = true;
        if (n < 2)
            KT = false;
        else
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    KT = false;
                    break;
                }
            }
        }
        if (KT)
            Console.WriteLine($"{n} là số nguyên tố");
        else
            Console.WriteLine($"{n} không là số nguyên tố");
    }
    static void Bai2_4()
    {
        Console.Write("Nhập số nguyên dương N: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 1) { Console.WriteLine("Vui lòng nhập N > 1."); return; }

        Console.Write("Các số hoàn hảo nhỏ hơn N là: ");
        for (int i = 2; i < n; i++)
        {
            int tong = 0;
            for (int j = 1; j < i; j++)
                if (i % j == 0) tong += j;
            if (tong == i) Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    static void Bai2_5()
    {
        Console.Write("Nhập vị trí n: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0) { Console.WriteLine("Vui lòng nhập n > 0."); return; }
        Console.WriteLine($"Giá trị Fibonacci ở vị trí {n} là: {FibonacciThuN(n)}");
    }
    static void Bai2_6()
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
        Console.Write("Phần tử trong mảng: ");
        foreach (int x in mang) Console.Write(x + " ");

        for (i = 0; i < n - 1; i++)
            for (j = 0; j < n - i - 1; j++)
                if (mang[j] > mang[j + 1])
                {
                    int temp = mang[j];
                    mang[j] = mang[j + 1];
                    mang[j + 1] = temp;
                }

        Console.Write("\nMảng sau khi được sắp xếp: ");
        foreach (int x in mang) Console.Write(x + " ");
        Console.WriteLine();
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
        Console.WriteLine("--------------- CHƯƠNG 2: Phân tích ---------------");
        Console.WriteLine("---------- Bài 1 ----------");
        Bai2_1();
        Console.WriteLine("\n---------- Bài 2 ----------");
        Bai2_2();
        Console.WriteLine("\n---------- Bài 3 ----------");
        Bai2_3();
        Console.WriteLine("\n---------- Bài 4 ----------");
        Bai2_4();
        Console.WriteLine("\n---------- Bài 5 ----------");
        Bai2_5();
        Console.WriteLine("\n---------- Bài 6 ----------");
        Bai2_6();
    }
}