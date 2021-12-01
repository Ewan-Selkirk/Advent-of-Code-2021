using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2021.Days
{
    public class day01
    {
        static void Main(string[] args)
        {
            IEnumerable<String> lines = File.ReadLines("Days/day01/input.txt");
            int lastValue = 0;
            int count = 0;
            
            #region part_1
            foreach (var val in lines)
            {
                var num = int.Parse(val);
                if (lastValue == 0)
                {
                    lastValue = num;
                    Console.WriteLine(val +  " (N/A - no previous measurement)");
                    continue;
                }

                if (num > lastValue)
                {
                    Console.WriteLine(val + " (increased)");
                    count++;
                }
                else
                {
                    Console.WriteLine(val + " (decreased)");
                }

                lastValue = num;
            }
            Console.WriteLine("Increased " + count + " times");
            #endregion

            Console.WriteLine();
            Console.WriteLine();
            
            #region part_2
            lastValue = 0;
            count = 0;
            List<int> calc = new List<int>();

            foreach (var val in lines)
            {
                if (calc.Count() < 3)
                {
                    var num = int.Parse(val);
                    calc.Add(num);
                    if (calc.Count() == 3) goto checking;
                    continue;
                }
                
                // I had no idea C# had this... Seems neat
                checking:
                if (lastValue == 0)
                {
                    Console.WriteLine(calc.Sum() +  " (N/A - no previous measurement)");
                    lastValue = calc.Sum();
                    calc.RemoveAt(0);
                    continue;
                }

                if (calc.Sum() > lastValue)
                {
                    Console.WriteLine(val + " (increased)");
                    count++;
                }
                else
                {
                    Console.WriteLine(val + " (decreased)");
                }

                lastValue = calc.Sum();
                calc.RemoveAt(0);
            }
            
            Console.WriteLine(count);

            #endregion
        }
    }
}