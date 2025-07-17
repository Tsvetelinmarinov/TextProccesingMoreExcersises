/// <summary>
///  01.ExtractPersonInformation
/// </summary>

using System;
using System.Text;
using System.Collections.Generic;

namespace _01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, byte> people = new();

            byte lines = byte.Parse(Console.ReadLine()!);
            for (; lines > 0; --lines)
            {
                string def = Console.ReadLine()!;

                string name = def.Substring(
                    def.IndexOf('@') + 1, 
                    def.IndexOf('|') - def.IndexOf('@') - 1
                );

                byte age = byte.Parse(
                    def.Substring(
                        def.IndexOf('#') + 1,
                        def.IndexOf('*') - def.IndexOf('#') - 1
                    )
                );

                people.Add(name, age);
            }

            foreach (KeyValuePair<string, byte> man in people)
            {
                Console.WriteLine($"{man.Key} is {man.Value} years old.");
            }
        }
    }
}
