using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push("Kanika");
            s.Push("Sabharwal");
            s.Push("Welcome!");

            Console.WriteLine(s.Peek());
            s.Pop();
            Console.WriteLine(s.Contains("Kanika"));
            Console.WriteLine(s.Count);

            foreach (var x in s) Console.WriteLine(x);

            Console.ReadLine();

        }
    }
}
