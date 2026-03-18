using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("SV: Truong Van Quang - MSV: 2415053122232");
        Console.WriteLine("--- Bai 16: Dem so lan xuat hien ky tu ---");

        // 1. Nhập một chuỗi
        Console.Write("Nhap vao mot chuoi: ");
        string input = Console.ReadLine();

        // 2. Dùng Dictionary để đếm
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (c == ' ') continue; // Bo qua khoang trang neu muon

            if (charCounts.ContainsKey(c))
            {
                charCounts[c]++;
            }
            else
            {
                charCounts[c] = 1;
            }
        }

        // 3. In kết quả
        Console.WriteLine("Ket qua dem:");
        foreach (var pair in charCounts)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }

        Console.ReadLine();
    }
}