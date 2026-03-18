using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("SV: Truong Van Quang - MSV: 2415053122232");
        List<string> students = new List<string> { "Quang", "An", "Binh", "Chau", "Dong" };
        Console.WriteLine("Danh sach SV hien tai: " + string.Join(", ", students));

        Console.Write("Nhap ten sinh vien muon xoa: ");
        string name = Console.ReadLine();

        if (students.Remove(name))
        {
            Console.WriteLine("Xoa thanh cong.");
        }
        else
        {
            Console.WriteLine("Khong tim thay ten nay.");
        }

        Console.WriteLine("Danh sach sau khi xoa: " + string.Join(", ", students));
        Console.ReadLine();
    }
}