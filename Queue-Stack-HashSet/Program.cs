using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            _Queue queue = new _Queue();
            queue.QueueNotGeneric();
            GenericQueue genericQueue = new GenericQueue();
            genericQueue.QueueGeneric();
            _Stack _Stack = new _Stack();
            _Stack.StackMethod();
            GenericStack genericStack = new GenericStack();
            genericStack.GenericStackMethod();
            _HashSet _HashSet = new _HashSet();
            _HashSet.HashSetMethod();
        }
    }
}
