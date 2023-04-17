using System;

namespace Classes_Henderson_Bobby
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Greetings greetings = new Greetings();
            //
            greetings.Welcome();

            //
            Console.WriteLine("waht si your name squire");
            string userName = Console.ReadLine();
            //
            greetings.Hello(userName);

        }
    }
}
