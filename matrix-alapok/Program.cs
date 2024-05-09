namespace matrix_alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] randomSzamMatrix = new int[10,10];
            for (int i = 0; i < randomSzamMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomSzamMatrix.GetLength(1); j++)
                {
                    randomSzamMatrix[i, j] = random.Next(0, 101);
                }
            }
            Console.WriteLine("1. feladat:");
            for (int i = 0; i < randomSzamMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomSzamMatrix.GetLength(1); j++)
                {
                    Console.Write($"{randomSzamMatrix[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("2. feladat:");
            string[,] keresztnevek = new string[,] { { "Kati", "Judit", "Csaba", }, { "Gyuri", "Misi", "Tibi" }, { "Jani", "Miki", "Norbi" } };

            for (int i = 0; i < keresztnevek.GetLength(0); i++)
            {
                for (int j = 0; j < keresztnevek.GetLength(1); j++)
                {
                    Console.WriteLine($"{i + 1}. sor {j + 1}. elem: {keresztnevek[i,j]}");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < keresztnevek.GetLength(0); i++)
            {
                for (int j = 0; j < keresztnevek.GetLength(1); j++)
                {
                    Console.Write($"{keresztnevek[i, j]} ");
                    if (j == keresztnevek.GetLength(1) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("3. feladat:");
            int[][] jaggedTomb = new int[6][];

            for (int i = 0; i < jaggedTomb.GetLength(0); i++)
            {
                int randomDarabSzam = random.Next(3, 10);
                jaggedTomb[i] = new int[randomDarabSzam];
                for (int j = 0; j < randomDarabSzam; j++)
                {
                    jaggedTomb[i][j] = random.Next(1, 1000);
                }
            }

            for (int i = 0; i < jaggedTomb.Length; i++)
            {
                for (int j = 0; j < jaggedTomb[i].Length; j++)
                {
                    Console.Write($"{jaggedTomb[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("4. feladat");
            int[][] inicializaltJaggedTomb = new int[6][];
            inicializaltJaggedTomb[0] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            inicializaltJaggedTomb[1] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            inicializaltJaggedTomb[2] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            inicializaltJaggedTomb[3] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            inicializaltJaggedTomb[4] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            inicializaltJaggedTomb[5] = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < inicializaltJaggedTomb.Length; i++)
            {
                for (int j = 0; j < inicializaltJaggedTomb[i].Length; j++)
                {
                    Console.Write($"{inicializaltJaggedTomb[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("5. feladat");
            int[,] nNMatrix = new int[random.Next(1, 21), random.Next(1, 21)];
            for (int i = 0; i < nNMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < nNMatrix.GetLength(1); j++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("6. feladat");
            int[,] sorfolytonosMatrix = new int[random.Next(1, 21), random.Next(1, 21)];
            int counter = 1;
            for (int i = 0; i < sorfolytonosMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < sorfolytonosMatrix.GetLength(1); j++)
                {
                    sorfolytonosMatrix[i,j] = counter;
                    counter++;
                    Console.Write($"{sorfolytonosMatrix[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("7. feladat");
            int[,] randomMatrix = new int[10, 10];
            Console.WriteLine("7/a feladat:");
            for (int i = 0; i < randomMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomMatrix.GetLength(1); j++)
                {
                    randomMatrix[i, j] = random.Next(0, 101);
                    Console.Write($"{randomMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("7/b feladat:");
            for (int i = 0; i < randomMatrix.GetLength(0); i++)
            {
                Console.Write($"{string.Empty.PadLeft(i, '\t')}{randomMatrix[i, i]}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("7/c feladat:");
            for (int i = 0; i < randomMatrix.GetLength(0); i++)
            {
                Console.Write($"{string.Empty.PadLeft(randomMatrix.GetLength(0) - i, '\t')}{randomMatrix[i, randomMatrix.GetLength(0) - i - 1]}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("7/d feladat:");
            Console.Write($"{randomMatrix[0, randomMatrix.GetLength(0) - 2]} {randomMatrix[0, randomMatrix.GetLength(0) - 1]}");
            Console.WriteLine();
            Console.Write($"   {randomMatrix[1, randomMatrix.GetLength(0) - 1]}");
            Console.WriteLine();
            Console.WriteLine("7/e feladat:");
            Console.Write($"{randomMatrix[randomMatrix.GetLength(0) - 2, 0]}");
            Console.WriteLine();
            Console.Write($"{randomMatrix[randomMatrix.GetLength(0) - 1, 0]} {randomMatrix[randomMatrix.GetLength(0) - 1, 1]}");
            Console.WriteLine();
            Console.WriteLine("7/f feladat:");
            Console.Write($"{randomMatrix[0, 0]} {randomMatrix[0, 1]}");
            Console.WriteLine();
            Console.Write($"{randomMatrix[1, 0]}");
            Console.WriteLine();
            Console.WriteLine("7/g feladat:");
            Console.Write($"   {randomMatrix[randomMatrix.GetLength(0) - 2, randomMatrix.GetLength(0) - 1]}");
            Console.WriteLine();
            Console.Write($"{randomMatrix[randomMatrix.GetLength(0) - 1, randomMatrix.GetLength(0) - 2]} {randomMatrix[randomMatrix.GetLength(0) - 1, randomMatrix.GetLength(0) - 1]}");

            Console.ReadLine();
        }
    }
}
