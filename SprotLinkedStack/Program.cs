using SprotLinkedStack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotLinkedStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedStack<int> linkedStack = new LinkedStack<int>();
            linkedStack.Push(10);
            linkedStack.Push(20);

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.ReadLine();
        }
    }
}
