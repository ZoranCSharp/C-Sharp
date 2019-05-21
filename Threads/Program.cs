using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {

            //var taskCompletionSource = new TaskCompletionSource<bool>();
            //var thread = new Thread(() =>
            //{
            //    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started!");
            //    Thread.Sleep(5000);
            //    taskCompletionSource.TrySetResult(true);
            //    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended!");
            //});


            //thread.Start();
            //var test = taskCompletionSource.Task.Result;
            //Console.WriteLine($"Task was done {test}");


            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            })
            { IsBackground = true }.Start();


            Enumerable.Range(0, 100).ToList().ForEach(f =>
             {
                 ThreadPool.QueueUserWorkItem((o =>
                 {
                     new Thread(() =>
                     {
                         Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started!");
                         Thread.Sleep(5000);

                         Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended!");
                     }).Start();
                 }));
                 
             });
           



            Console.ReadLine();
        }
    }
}
