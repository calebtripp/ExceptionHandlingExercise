using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[9] { '0', '1', '2', '3', '4', '5', 'a', 'b', 'c' };
            var numbers = new List<int>();
            string str = String.Empty;

            foreach (var character in arr)
            {
                try
                {
                    str = character.ToString();
                    int inty = int.Parse(str);
                    numbers.Add(inty);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to Parse'{character}'");
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}