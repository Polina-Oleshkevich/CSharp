using System;
using System.Text;

namespace Passwordgenerator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Какой длины пароль?");
            GenertorPw.Length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Пароль: {0}", GenertorPw.PasswdGetSet());
            Console.ReadLine();
        }
    }
    class GenertorPw
    {
        static public int Length { get; set; }
        static public string PasswdGetSet()
        {
            Random random = new Random();
            StringBuilder Passwd = new StringBuilder();
            for (int i = 0; i < Length; i++)
            {
                Passwd.Append((char)random.Next(50, 100));
            }
            return Passwd.ToString();
        }
    }
}
