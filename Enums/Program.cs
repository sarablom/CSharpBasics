using System;

namespace CSharpfundamentals;
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            //3

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            //Express

            Console.WriteLine(method.ToString());
            //Express
        }
    }
}
