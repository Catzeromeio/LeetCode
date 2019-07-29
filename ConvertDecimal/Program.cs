using System;
using System.Collections.Generic;


namespace ConvertDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Result = new List<int>();

            Helper(Result, 200, 8);

            Console.WriteLine();

            Console.ReadLine();
        }

        static void Helper(List<int> store, int decimalValue, int n)
        {
            int mod = decimalValue % n;
            int div = decimalValue / n;

            if (div != 0)
                Helper(store, div, n);

            store.Add(mod);
        }

    }
}
