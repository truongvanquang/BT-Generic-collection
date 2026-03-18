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
        List<Student> dsSV = new List<Student>();
        Console.Write("Nhap so luong sinh vien can them: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student sv = new Student();
            Console.Write($"Nhap ID cho SV {i + 1}: ");
            sv.Id = int.Parse(Console.ReadLine());
            Console.Write($"Nhap Ten cho SV {i + 1}: ");
            sv.Name = Console.ReadLine();
            dsSV.Add(sv);
        }

        Console.WriteLine("\n--- Thong tin danh sach sinh vien ---");
        foreach (var s in dsSV)
        {
            Console.WriteLine($"ID: {s.Id} | Ho Ten: {s.Name}");
        }
        Console.ReadLine();
    }
}