using System.Runtime.InteropServices;

namespace MathCommonNetCore
{
    internal static class UnsafeNativeMethods
    {

        /// <summary>
        /// Initialize a Fibonacci relation sequence
        /// such that F(0) = a, F(1) = b.
        /// </summary>
        [DllImport("MathLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void fibonacci_init(ulong a, ulong b);

        /// <summary>
        /// Produce the next value in the sequence.
        /// Returns true on success, false on overflow.
        /// </summary>
        [DllImport("MathLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool fibonacci_next();

        /// <summary>
        /// Get the current value in the sequence.
        /// </summary>
        [DllImport("MathLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern long fibonacci_current();

        /// <summary>
        /// Get the current index position in the sequence.
        /// </summary>
        [DllImport("MathLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint fibonacci_index();

        /// <summary>
        /// Add two numbers.
        /// </summary>
        [DllImport("MathLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int add(int a, int b);

    }
}