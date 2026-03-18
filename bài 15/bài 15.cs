using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("SV: Truong Van Quang - MSV: 2415053122232");
        Console.WriteLine("--- Bai 15: Tra cuu tu dien Anh - Viet ---");

        // 1. Tạo Dictionary và lưu dữ liệu mẫu
        Dictionary<string, string> tuDien = new Dictionary<string, string> {
            { "apple", "qua tao" },
            { "book", "quyen sach" },
            { "computer", "may tinh" },
            { "student", "sinh vien" }
        };

        // 2. Nhập từ tiếng Anh và tra nghĩa
        Console.Write("Nhap tu tieng Anh can tra (vi du: apple, book...): ");
        string key = Console.ReadLine().ToLower().Trim();

        if (tuDien.ContainsKey(key))
        {
            Console.WriteLine($"Nghia cua tu '{key}' la: {tuDien[key]}");
        }
        else
        {
            Console.WriteLine("Rat tiec, tu nay chua co trong tu dien.");
        }

        Console.ReadLine();
    }
}