using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("SV: Truong Van Quang - MSV: 2415053122232");
        Console.WriteLine("--- Bai 13: Nhap va Dem tong so sinh vien ---");

        List<Student> dsSV = new List<Student>();

        Console.Write("Ban muon nhap bao nhieu sinh vien? ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.Write("Vui long nhap mot so nguyen duong: ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");
            Student sv = new Student();

            Console.Write(" - Nhap ID: ");
            sv.Id = int.Parse(Console.ReadLine());

            Console.Write(" - Nhap Ten: ");
            sv.Name = Console.ReadLine();

            dsSV.Add(sv);
        }

        int tongSo = dsSV.Count;

        Console.WriteLine("\n----------------------------------");
        Console.WriteLine($"Ket qua: Tong so sinh vien trong danh sach la: {tongSo}");
        Console.WriteLine("----------------------------------");

        Console.WriteLine("Nhan phim bat ky de ket thuc...");
        Console.ReadLine();
    }
}