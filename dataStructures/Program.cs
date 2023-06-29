using System;
using System.Collections.Generic;
using System.Linq;

namespace dataStructures
{
    public class Program
    {
        private static object em;

        static void Main(string[] args)
        {

             static void Email()
            {
                em = EmailService.SendStaffEmail();


            }
            //var newStack = new Stack<int>();
            //newStack.Push(1);
            //newStack.Push(2);
            //newStack.Push(3);
            //newStack.Push(4);
            //newStack.Push(5);
            //newStack.Push(9);
            ////newStack.Pop(10);


            //Console.WriteLine(newStack); 
            //var result = newStack.Pop();
            //Console.WriteLine(result);
            
            Console.WriteLine("Hello World!");

            var newList = new List<int>() { 1, 2, 4, 5, 6};

            foreach (int i in newList)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(newList);

            //var newQueue = new Queue<int>();
            //newQueue.Enqueue(1);
            //newQueue.Enqueue(2);
            //newQueue.Enqueue(3);
            //newQueue.Enqueue(4);
            //newQueue.Enqueue(5);

            //var result = newQueue.Dequeue();
            //Console.WriteLine(result);
            //var remaining = newQueue.ToList();
            //Console.WriteLine(remaining);

            //foreach (var item in remaining)
            //    Console.WriteLine(item);

        }

        

    }
}
