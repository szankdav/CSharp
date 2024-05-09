using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatIX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGradesAndNames;
            bool isNumber;

            do
            {
                Console.WriteLine("Kerem adja meg a jegyek es nevek szamat: ");
                isNumber = int.TryParse(Console.ReadLine(), out numberOfGradesAndNames);

                if (!isNumber)
                {
                    Console.WriteLine("A beirt adat nem ertelmezheto!");
                }

            } while (!isNumber || numberOfGradesAndNames < 1);

            int[] grades = new int[numberOfGradesAndNames];
            string[] names = new string[numberOfGradesAndNames];

            for (int i = 0; i < numberOfGradesAndNames; i++)
            {
                bool isValidGrade;
                int grade;
                Console.WriteLine($"Kerem adja meg a(z) {i + 1}. nevet: ");
                names[i] = Console.ReadLine().Trim();

                do
                {
                    Console.WriteLine($"Kerem adja meg a(z) {i + 1}. jegyet: ");
                    isValidGrade = int.TryParse(Console.ReadLine(), out grade);

                    if (!isValidGrade || (grade < 1 || grade > 5))
                    {
                        Console.WriteLine("A beirt adat nem ertelmezheto!");
                    }
                } while (!isValidGrade || (grade < 1 || grade > 5));

                grades[i] = grade;
            }

            double avgGrades = 0;
            int minGradeIndex = 0;
            int maxGradeIndex = 0;

            for (int j = 0; j < grades.Length; j++)
            {
                avgGrades += grades[j];
            }

            avgGrades = avgGrades / grades.Length;

            Console.WriteLine($"A jegyek atlaga: {avgGrades}");

            for (int k = 1; k < grades.Length; k++)
            {
                if (grades[minGradeIndex] > grades[k])
                {
                    minGradeIndex = k;
                }
            }

            for (int l = 1; l < grades.Length; l++)
            {
                if (grades[maxGradeIndex] < grades[l])
                {
                    maxGradeIndex = l;
                }
            }

            Console.WriteLine($"A legrosszabb jegy tulajdonosa: {names[minGradeIndex]}");
            Console.WriteLine($"A legjobb jegy tulajdonosa: {names[maxGradeIndex]}");

            Console.ReadKey();
        }
    }
}