using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesActionsFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var action = new Action(DoSomehing);
            action();
            var action2 = new Action<int, int>(Sum);
            action2(5, 7);

            var func = new Func<int, int, int>(SumReturn);
            Console.WriteLine(func(11, 9));

            var func2 = new Func<int, int, double>(DivedeReturn);
            Console.WriteLine(func2(19,9));

            Console.ReadLine();
        }

        public static double DivedeReturn(int x, int y)
        {

            return (x / y);
        }

        public static int SumReturn(int x, int y)
        {
            return x + y;
        }

        public static void DoSomehing()
        {
            Console.WriteLine("I am doing now...");
        }

        public static void Sum(int x, int y)
        {
            Console.WriteLine("x+y=" + (x + y));
        }
    }

}
