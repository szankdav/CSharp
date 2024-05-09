using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingGameUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            string[] lines = new string[File.ReadAllLines("input.txt").Length];
            while (!reader.EndOfStream) 
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = reader.ReadLine();
                }
            }
            reader.Close();

            StreamWriter writer = new StreamWriter("output.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("split"))
                {
                    writer.Write(lines[i].Split()[4] + " ");
                }
            }
            writer.Close();
        }
    }
}
