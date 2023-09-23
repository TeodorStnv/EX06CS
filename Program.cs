using System.ComponentModel.Design;

namespace EX06CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;
            string oddEven = "";


            if (operation == "+")
            {
                result = N1 + N2;
            }
            else if (operation == "-")
            {
                result = N1 - N2;
            }
            else if (operation == "*")
            {
                result = N1 * N2;
            }
            else if (operation == "/")
            {
                if (N2 != 0)
                {
                    result = (double)N1 / N2;
                    Console.WriteLine($"{N1} {operation} {N2} = {result:F2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }

            else if (operation == "%")
            {
                if (N2 != 0)
                {
                    result = N1 % N2;
                    Console.WriteLine($"{N1} {operation} {N2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }



            if (operation != "/" && operation != "%")
            {
                if (result % 2 == 0)
                {
                    oddEven = "even";

                }
                else
                {
                    oddEven = "odd";
                }
                Console.WriteLine($"{N1} {operation} {N2} = {result} - {oddEven}");

            }
            //else
            //{
            //    Console.WriteLine($"{N1} {operation} {N2} = {result}");
            //}









            }
    }
}