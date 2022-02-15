using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskOne
{

    /// задача №1
    /// необходимо просуммировать все найденные числа
    /// исправить потенциальную ошибку
    ///
    /// задачу необходимо реализовать, дописав код, чтобы data.GetDigits() стал работоспособным

    public static class StringExt
    {
        public static byte[] GetDigits(this string str)
        {
            Console.WriteLine("GetDigist function\n");
            List<byte> digists = new List<byte>();
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digists.Add((byte)ch);
                }
            }
            return digists.ToArray();
        }
    }


    class Program
    {

        public static string RandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static void Main(string[] args)
        {
            string data = RandomString(5);
            byte summary = 0;

            foreach (byte digit in data.GetDigits())
            {
                summary += digit;
            }

            Console.WriteLine($"{data} => {summary}");
        }
    }
}
