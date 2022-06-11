using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack_HashSet
{
    public class GenericStack
    {
        public void GenericStackMethod()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
                Console.Write(item + ",");
        }
    }
}
