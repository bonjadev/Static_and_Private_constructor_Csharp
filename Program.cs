using System;

namespace Static_and_Private_constructor
{
    class PrConstructor
    {
        public int a;
        public PrConstructor(int b)
        {
            this.a = b;
        }
        private PrConstructor()
        {
            Console.WriteLine("Private Constructor");
        }

    }

    class test
    {
        static void Main()
        {
            PrConstructor obj = new PrConstructor(5);
            Console.WriteLine(obj.a);
            Console.ReadLine();
        }
    }
}
