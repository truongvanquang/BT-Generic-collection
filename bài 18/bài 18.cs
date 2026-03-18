using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name;
    public double Score;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("SV: Truong Van Quang - MSV: 2415053122232");
        Console.WriteLine("--- Bai 18: Tim sinh vien co diem cao nhat ---");

        List<Student> dsSV = new List<Student>();
        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student sv = new Student();
            Console.Write($"Nhap ten SV thu {i + 1}: ");
            sv.Name = Console.ReadLine();
            Console.Write($"Nhap diem cho {sv.Name}: ");
            sv.Score = double.Parse(Console.ReadLine());
            dsSV.Add(sv);
        }

        // Tìm sinh viên có điểm cao nhất
        if (dsSV.Count > 0)
        {
            var bestStudent = dsSV.OrderByDescending(s => s.Score).First();
            Console.WriteLine($"\nSinh vien co diem cao nhat la: {bestStudent.Name} voi {bestStudent.Score} diem.");
        }

        Console.ReadLine();
    }
}