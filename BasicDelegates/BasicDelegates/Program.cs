using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDelegates
{
    //declare the delegate type
    public delegate string MyDelegate(int arg1, int arg2);

    class Program
    {
        static string func1(int a, int b)
        {
            return (a + b).ToString();
        }
        static string func2(int a, int b)
        {
            return (a * b).ToString();
        }
        static void Main(string[] args)
        {
        }
    }
}
