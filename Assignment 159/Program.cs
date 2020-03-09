using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_159
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 5;
            int Total;
            MathFunction functionOne = new MathFunction();

            Total = functionOne.mathOne(z);

            Console.WriteLine("This is Step 1-2. multiply 5 * 5.");
            Console.WriteLine(Total);

            decimal q = 43.57m;
            int answer;
            MathFunction functionTwo = new MathFunction();
            answer = functionTwo.mathOne(q);

            Console.WriteLine("This is Step 3-4. divide 43.57 by 2.00");
            Console.WriteLine(answer);


            string x;
            int conclusion;
            MathFunction functionThree = new MathFunction();
            Console.WriteLine("Enter a number for the final Method:");
            x = (Console.ReadLine());
            Console.WriteLine(x + " minus 12 equals:");
            conclusion = functionThree.mathOne(x);

            Console.WriteLine(conclusion);


            
            Console.ReadLine();
        }
    }
}
