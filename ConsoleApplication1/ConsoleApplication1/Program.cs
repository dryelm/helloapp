using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void greetBlack()
        {
            Console.WriteLine("hello, Black");
            greetBlack();
            greetWhite();
        }
        
        public static void greetWhite()
        {
            Console.WriteLine("hello, White");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");      
        }
    }
}