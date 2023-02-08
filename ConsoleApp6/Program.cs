using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static bool Palindrom(string s)
        {
            if (s == null) throw new ArgumentNullException("s");
            s = s.ToLower().Replace(" ", string.Empty);
            return PInternal(s);
        }


        static bool PInternal(string s)
        {
            if (s.Length == 1 || string.IsNullOrEmpty(s)) return true;
            if (!s[0].Equals(s[s.Length - 1])) return false;
            return PInternal(s.Substring(1, s.Length - 2));
        }

        static void Main(string[] args)
        {
            //string s="Hello World";
            //Console.WriteLine("Введите номер:");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(s.Remove(num, 1));

            //string s = "Hello World";
            //Console.WriteLine(s.Trim(new Char[] { 'l' }));

            //string s = "Hello World. World Hello.";
            //int count = 0;
            //string[] subs = s.Split();

            //foreach (string sub in subs)
            //{
            //    Console.WriteLine($"Substring: {sub}");
            //    count++;
            //}
            //Console.WriteLine($"Кол-вл слов: {count}");

            //string s = "Every hunter wants to know where the pheasant sits";
            //Console.Write($"Исходная строка:{s}");
            //char[] sep = { ' ' };
            //string[] parts = s.Split(sep);
            //int partsLen = parts.Length;
            //string fString = "wants";
            //string sString = "pheasant";
            //for (int i = 0; i < partsLen; i++)
            //{
            //    if (parts[i] == fString)
            //    {
            //        parts[i] = sString;
            //        continue;
            //    }
            //    if (parts[i] == sString)
            //    {
            //        parts[i] = fString;
            //    }
            //}
            //string news = String.Join(" ", parts);
            //Console.WriteLine($"Обработанная строка:{news}");

            //var s = "Every hunter wants to know where the pheasant sits";

            //Console.WriteLine(Palindrom(s));
            //Console.ReadKey(true);

        }
    }

}
