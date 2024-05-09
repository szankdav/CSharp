namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num3, num4, num5;
            int num1;

            num1 = 13;
            int num2 = 23;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
           
            int sum = num1 + num2;

            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;

            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;

            float fDiv = f1 / f2;

            Console.WriteLine("f1/f2 is " + fDiv);

            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num1 is " + dIDiv);

            string myName = "David";
            string message = "My name is " + myName;

            string capsMessage = message.ToUpper();

            string lowerMessage = message.ToLower();

            Console.WriteLine("My name is " + myName);
            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);

            Console.ReadKey();
        }
    }
}