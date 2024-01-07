using System;
using System.Xml.Linq;

namespace quiz0701
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //5.Verilmiş array - dən verilmiş indexli elementi silən metod.
            int[] newArr = { 12, 14, 16, 18, 20 };
            string indexStr=Console.ReadLine();
            int index = Convert.ToInt32(indexStr);
            for(int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] == index) 
                Console.WriteLine(index);
            }
        }
    }
}

