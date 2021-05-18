using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace q_stack
{
   public class q
    {
        public static void qq()
        {
            Queue irfan = new Queue();
            irfan.Enqueue("welcome");
            irfan.Enqueue(20);
            irfan.Enqueue("abdullah");
            Console.WriteLine("number of iteam:{0}", irfan.Count);

            foreach (var item in irfan)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("number of iteam:{0}\n", irfan.Count);
            Console.WriteLine("value:{0}", irfan.Contains(20));
            Console.WriteLine("peek value is:{0}",irfan.Peek());


        }
    }
    public class stack
    {
        public static void abstack()
        {
            Stack abstack = new Stack();
            abstack.Push("welcome abdullah");
            abstack.Push("hi");
            abstack.Push(30);

            foreach (var item in abstack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("number of iteam:{0}\n", abstack.Count);
            abstack.Pop();
            Console.WriteLine(abstack);
            foreach (var item in abstack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("value:{0}", abstack.Contains("hi"));
        }
    }
}
