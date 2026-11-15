using System;
class Program
{
    static void Bai3_1()
    {
        Console.Write("Nhập số tự nhiên n: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0) { Console.WriteLine("Vui lòng nhập n >= 0."); return; }
        Console.WriteLine($"Tổng từ 1 đến {n} là: {TongN(n)}");
    }

    static long TongN(int n)
    {
        if (n == 0) return 0;
        return n + TongN(n - 1);
    }
    static void Bai3_2()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0) { Console.WriteLine("Vui lòng nhập n >= 0."); return; }
        Console.WriteLine("Tổng lũy thừa liên tiếp = " + TongLuyThua(n));
    }

    static long LuyThuaNguyen(int a, int b)
    {
        if (b == 0) return 1;
        return (long)a * LuyThuaNguyen(a, b - 1);
    }

    static long TongLuyThua(int n)
    {
        if (n == 0) return 0;
        return TongLuyThua(n - 1) + LuyThuaNguyen(n, n);
    }
    static void Bai3_3()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0) { Console.WriteLine("Vui lòng nhập n >= 0."); return; }
        Console.WriteLine("Tổng phân số = " + TongPhanSo(n));
    }

    static double TongPhanSo(int n)
    {
        if (n == 0) return 0;
        return TongPhanSo(n - 1) + 1.0 / n;
    }

    static void Bai3_4()
    {
        Console.Write("Nhập x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Nhập số mũ của x: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Vui lòng nhập n >= 0!");
            return;
        }
        Console.WriteLine($"Kết quả = {LuyThuaThuc(x, n)}");
    }

    static double LuyThuaThuc(double x, int n)
    {
        if (n == 0) return 1;
        return x * LuyThuaThuc(x, n - 1);
    }

    static void Bai3_5()
    {
        Console.Write("Nhập số tự nhiên n để kiểm tra: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Vui lòng nhập số nguyên dương!");
            return;
        }
        Console.WriteLine("Ước số lẻ lớn nhất là: " + TimUocLeLN(n));
    }

    static int TimUocLeLN(int n)
    {
        if (n % 2 != 0) return n;
        return TimUocLeLN(n / 2);
    }

    static void Bai3_6()
    {
        Console.Write("Nhập số a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập số b: ");
        int b = int.Parse(Console.ReadLine());
        a = Math.Abs(a);
        b = Math.Abs(b);
        Console.WriteLine($"UCLN của hai số {a}, {b} là = {UCLN(a, b)}");
    }

    static int UCLN(int a, int b)
    {
        if (b == 0) return a;
        return UCLN(b, a % b);
    }
    static void Bai3_7()
    {
        Console.Write("Nhập số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Vui lòng nhập số nguyên dương!");
            return;
        }
        Console.WriteLine($"Số chữ số của {n} là: {DemChuSo(n)}");
    }

    static int DemChuSo(int n)
    {
        if (n < 10) return 1;
        return 1 + DemChuSo(n / 10);
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("\n--------------- CHƯƠNG 3: Đệ Quy ---------------");
        Console.WriteLine("---------- Bài 1 ----------");
        Bai3_1();
        Console.WriteLine("\n---------- Bài 2 ----------");
        Bai3_2();
        Console.WriteLine("\n---------- Bài 3 ----------");
        Bai3_3();
        Console.WriteLine("\n---------- Bài 4 ----------");
        Bai3_4();
        Console.WriteLine("\n---------- Bài 5 ----------");
        Bai3_5();
        Console.WriteLine("\n---------- Bài 6 ----------");
        Bai3_6();
        Console.WriteLine("\n---------- Bài 7 ----------");
        Bai3_7();
    }
}