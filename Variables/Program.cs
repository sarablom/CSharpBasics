using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Sara";
            var isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            //0 represents the first value after the string and 1 the second
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //0 - 255
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            //-3,4028235E+38 - 3,4028235E+38
        }
    }
}
