using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("SV: Truong Van Quang - MSV: 2415053122232");
        List<string> ds = new List<string> { "C#", "Java", "Python", "C++" };

        Console.Write("Nhap ngon ngu lap trinh can kiem tra: ");
        string ngonNgu = Console.ReadLine();

        if (ds.Contains(ngonNgu))
        {
            Console.WriteLine("Co ton tai.");
        }
        else
        {
            Console.WriteLine("Khong ton tai.");
        }
        Console.ReadLine();
    }
}