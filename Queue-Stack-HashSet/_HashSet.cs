using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack_HashSet
{
    public class _HashSet
    {
        public void HashSetMethod()
        {
            HashSet<string> myhash = new HashSet<string>();

            myhash.Add("C");
            myhash.Add("C++");
            myhash.Add("C#");
            myhash.Add("Java");
            myhash.Add("Ruby");
            myhash.Add("Ruby");
            Console.WriteLine();
            Console.WriteLine("Elements of myhash1:");

            foreach (var val in myhash)
            {
                Console.WriteLine(val);
            }

            HashSet<int> myhash3 = new HashSet<int>() {10,
                               100,1000,10000,100000,100000};

            Console.WriteLine("Elements of myhash2:");
            foreach (var value in myhash3)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("=================================");
            HashSet<string> myhash1 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");

            // Creating another HashSet
            // Using HashSet class
            HashSet<string> myhash2 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash2.Add("PHP");
            myhash2.Add("C++");
            myhash2.Add("Perl");
            myhash2.Add("Java");

            // Using UnionWith method
            myhash1.UnionWith(myhash2);
            foreach (var ele in myhash1)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("=================================");
            List<int> vs = new List<int>() { 1,1,10,100,1000,1000,100000};
            var ttt = vs.ToHashSet<int>();
            foreach (var ele in ttt)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
