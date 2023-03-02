using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int res = MathCommon.Utility.Add(3,9);

            Console.WriteLine("The result is: {0}", res);
            /*
            MathCommon.Utility.Fibonacci(1, 1);

            do
            {
                Console.WriteLine("{0}:{1}", MathCommon.Utility.Fibonacci_Index(), MathCommon.Utility.Fibonacci_Current());
            } while (MathCommon.Utility.Fibonacci_Next());

            Console.WriteLine("{0} Fibonacci sequence values fit in an unsigned 64-bit integer.", MathCommon.Utility.Fibonacci_Index());
            */
        }
    }
}
