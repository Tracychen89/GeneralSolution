using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainValidAnagram(args);
            MainIntStack(args);
            //MainGenericStack(args);
        }

        static void MainValidAnagram(string[] args)
        {
            string s = "hhbywxfzydbppjxnbhezsxepfexkzofxyqdvcgdvgnjbvihgufvgtuxtpioxgjuwawk";

            string t = "rmhdxtymfgxjluxmeeerhxrrtjgecmyfdhevakyosvvuwgbwmxiakbmtqjjpgctjojd";

            //Console.WriteLine( t.Remove(0,1));
            Console.WriteLine(s.Length);
            ValidAnagram.Solution m = new ValidAnagram.Solution();
            Console.WriteLine(m.IsAnagram1(s, t));

            Console.ReadLine();
        }

        static void MainIntStack(string[] args)
        {
            IntStack.IntStack myStack = new IntStack.IntStack();
            int j;
            for (j = 0; j < 50; j++)
            {
                myStack.Push(j);
            }

            myStack.Display();
            //int num = myStack.Pop();
            //num = myStack.Pop();
            //num = myStack.Pop();
            //num = myStack.Pop();
            //Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
