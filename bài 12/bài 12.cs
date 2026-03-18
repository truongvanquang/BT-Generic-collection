using System;
using System.Collections.Generic;
using System.Linq;

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
        List<Student> dsSV = new List<Student> {
            new Student { Id = 101, Name = "Quang" },
            new Student { Id = 102, Name = "An" },
            new Student { Id = 103, Name = "Binh" }
        };

        Console.Write("Nhap ten sinh vien can tim: ");
        string findName = Console.ReadLine();

        var result = dsSV.Where(s => s.Name.ToLower().Contains(findName.ToLower())).ToList();

        if (result.Any())
        {
            Console.WriteLine("Da tim thay:");
            foreach (var s in result) Console.WriteLine($"- ID: {s.Id}, Ten: {s.Name}");
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien nao co ten tren.");
        }
        Console.ReadLine();
    }
}