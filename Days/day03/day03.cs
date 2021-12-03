using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2021.Days.day03
{
    public class day03
    {

        public day03()
        {
            IEnumerable<string> lines = File.ReadLines("Days/day03/input.txt");

            Part1(lines);
            Part2(lines);
        }
        
        private static void Part1(IEnumerable<string> input)
        {
            var gamma = "";
            var epsilon = "";

            var zero = 0;
            var one = 0;

            for (var i = 0; i < input.First().Length; i++)
            {
                foreach (var binary in input)
                {
                    if (binary[i] == '0')
                    {
                        zero++;
                    }
                    else
                    {
                        one++;
                    }
                }

                if (zero > one)
                {
                    gamma += '0';
                    epsilon += '1';

                    zero = 0;
                    one = 0;
                }
                else
                {
                    gamma +='1';
                    epsilon += '0';
                    
                    zero = 0;
                    one = 0;
                }
            }

            var gammaBinary = Convert.ToInt32(gamma, 2);
            var epsilonBinary = Convert.ToInt32(epsilon, 2);
            
            Console.WriteLine(gamma + " - " + gammaBinary);
            Console.WriteLine(epsilon + " - " + epsilonBinary);
            
            Console.WriteLine($"{gammaBinary} * {epsilonBinary} = " + gammaBinary * epsilonBinary);
        }
        
        private static void Part2(IEnumerable<string> input)
        {
            
        }
    }
}