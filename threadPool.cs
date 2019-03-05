/*
 * C# Program to Create Thread Pools
 */
using System;
using System.Threading;
class ThreadPoolDemo
{
    //Defines our two callback methods.
    public void task1(object obj)
    {
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Task 1 is being executed");
        }
    }
    public void task2(object obj)
    {
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Task 2 is being executed");
        }
    }
 
    static void Main()
    {
        //ThreadPool is an abstraction that allows for automatic management of
        //Available process threads without manually setting thread properties.
        ThreadPoolDemo tpd = new ThreadPoolDemo();
        for (int i = 0; i < 2; i++)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task1));
            ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task2));
            //The QueueUserWorkItem method takes a callback function to execute on the ThreadPool.
            //The Threads in the the ThreadPool will be assigned these work items.
        }
 
        Console.Read();
    }
}
