using System;
using System.Collections.Generic;

class Student { public int Id; public string Name; }

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

        Console.WriteLine("Danh sach ID hien tai: 101, 102, 103");
        Console.Write("Nhap ID sinh vien muon xoa: ");
        int idXoa = int.Parse(Console.ReadLine());

        int removedCount = dsSV.RemoveAll(s => s.Id == idXoa);

        if (removedCount > 0) Console.WriteLine($"Da xoa sinh vien co ID {idXoa}.");
        else Console.WriteLine("Khong tim thay ID de xoa.");

        Console.WriteLine("So luong sinh vien con lai: " + dsSV.Count);
        Console.ReadLine();
    }
}