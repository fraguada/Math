using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCommon
{
    public class Utility
    {
        /// <summary>
        /// Initialize a Fibonacci relation sequence
        /// such that F(0) = a, F(1) = b.
        /// </summary>
        public static void Fibonacci(ulong a, ulong b) 
        {
            UnsafeNativeMethods.fibonacci_init(a, b);
        }

        /// <summary>
        /// Produce the next value in the sequence.
        /// Returns true on success, false on overflow.
        /// </summary>
        public static bool Fibonacci_Next() 
        {
            return UnsafeNativeMethods.fibonacci_next();
        }

        /// <summary>
        /// Get the current value in the sequence.
        /// </summary>
        public static long Fibonacci_Current() 
        {
            return UnsafeNativeMethods.fibonacci_current();
        }

        /// <summary>
        /// Get the current index position in the sequence.
        /// </summary>
        public static uint Fibonacci_Index() 
        {
            return UnsafeNativeMethods.fibonacci_index();
        }

        /// <summary>
        /// Add two numbers.
        /// </summary>
        public static int Add(int a, int b)
        {
            return UnsafeNativeMethods.add(a, b);
        }
    }
}
