using System;

namespace _007_LogicalOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2; //010
            int y1 = 5; //101
            

            int x2 = 4; // 100
            int y2 = 5; // 101

            // &
            Console.WriteLine(x1 & y1);
            Console.WriteLine(x2 & y2);

            Console.WriteLine(new string('-', 50));

            // |
            Console.WriteLine(x1 | y1);
            Console.WriteLine(x2 | y2);

            Console.WriteLine(new string('-', 50));

            // ^
            int x = 45;
            int key = 102;
            int encrypt = x ^ key;
            Console.WriteLine($"Encrypted number: {encrypt}");

            int decrypt = encrypt ^ key;
            Console.WriteLine($"Decrypted number: {decrypt}");

            Console.WriteLine(new string('-', 50));

            // ~
            int x3 = 12;            //0001100
            Console.WriteLine(~x3); //1110011

            // Delay
            Console.ReadKey();
        }
    }
}
