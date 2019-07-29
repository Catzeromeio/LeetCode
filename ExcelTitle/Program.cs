using System;
using System.Collections.Generic;

namespace ExcelTitle
{
    class Program
    {
        static void Main(string[] args)
        {

            ConvertToTitle(701);
        }

        static public string ConvertToTitle(int n)
        {
           
            List<int> result = new List<int>();
            Helper(result, n, 26);

            List<char> final = new List<char>();
            foreach (var item in result)
                final.Add((char)(item + 64));

            return new string(final.ToArray());
        }

        //10进制转换到26进制

        static void Helper(List<int> store, int decimalValue, int n)
        {
            int mod = decimalValue % n;
            int div = decimalValue / n;
                
            if (mod == 0)
                div--;

            if (div != 0)
            {
                Helper(store, div, n);
            }

            if (mod == 0)
                store.Add(n);
            else
                store.Add(mod);
        }
    }
}
