using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi
            string hw = "Hello, World!";

            for (int i = hw.Length - 1; i >= 0; i--)
            {
                Console.Write(hw[i]);
            }
        }
    }
}
