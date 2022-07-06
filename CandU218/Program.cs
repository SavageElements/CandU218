using System;

namespace CandU218
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int dataInput = Convert.ToInt16(Console.ReadLine());

            
            int result3 = Class1.AddSeven(dataInput);
            Console.WriteLine("Your number + 7 is " + result3);

            Console.WriteLine("Please enter a decimal.");

            decimal dataInput2 = Convert.ToDecimal(Console.ReadLine());
            int nextUP = Class1.AddSeven(dataInput2);
            Console.WriteLine("Your number + 8 is " + nextUP);

            Console.WriteLine("Please enter another number.");

            string dataInput3 = Convert.ToString(Console.ReadLine());
            int nextUP2 = Class1.AddSeven(dataInput3);
            Console.WriteLine("Your number + 9 is " + nextUP2);


        }
    }
}
