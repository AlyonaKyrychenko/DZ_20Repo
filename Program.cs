using System;

namespace DZ_20
{
    public class Program
    {
        static void Main(string[] args)
        {
            _ = new Starter();
            var bl = new BusinessLogic();
            bl.Run();
            Console.ReadLine();
        }
    }
}
