using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2021.Days.day02
{
    public class day02
    {

        public day02()
        {
            IEnumerable<String> lines = File.ReadLines("Days/day02/input.txt");

            
            Part1(lines);
            Part2(lines);
        }
        
        private void Part1(IEnumerable<string> input)
        {
            var depth = 0;
            var horizontal = 0;

            var instructions = SplitList(input);

            foreach (var instruction in instructions)
            {
                var value = int.Parse(instruction[1]);
                switch (instruction[0])
                {
                    case "forward":
                        horizontal += value;
                        break;
                    case "down":
                        depth += value;
                        break;
                    case "up":
                        depth -= value;
                        break;
                }
            }
            
            Console.WriteLine(depth * horizontal);
        }

        private void Part2(IEnumerable<string> input)
        {
            var aim = 0;
            var depth = 0;
            var horizontal = 0;

            var instructions = SplitList(input);

            foreach (var instruction in instructions)
            {
                var value = int.Parse(instruction[1]);
                switch (instruction[0])
                {
                    case "forward":
                        horizontal += value;
                        if (aim > 0)
                        {
                            depth += (value * aim);
                        }
                        break;
                    case "down":
                        aim += value;
                        break;
                    case "up":
                        aim -= value;
                        break;
                }
            }
            
            Console.WriteLine(depth * horizontal);
        }

        private static List<string[]> SplitList(IEnumerable<String> list)
        {
            List<String[]> split = new List<string[]>();

            foreach (var i in list)
            {
                split.Add(i.Split(" "));
            }

            return split;
        }
    }
}