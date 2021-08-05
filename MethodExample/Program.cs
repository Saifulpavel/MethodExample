using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result=Add(30,20);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        //MethodExample//
        static int Add(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }

    }
}
