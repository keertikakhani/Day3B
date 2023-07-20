using System;

namespace Day3B
{
    class Program
    {
        public static void Main(string[] args)
        {
            Sum obj= new Sum();
            obj.Print();

            Sum obj1 = new Sum(25);
            obj1.Print();

           
            Console.ReadLine();
        }

    }
}
