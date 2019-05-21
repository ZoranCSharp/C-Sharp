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


            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 4");
            //})
            //{ IsBackground = true }.Start();


            //Enumerable.Range(0, 100).ToList().ForEach(f =>
            // {
            //     ThreadPool.QueueUserWorkItem((o =>
            //     {
            //         new Thread(() =>
            //         {
            //             Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started!");
            //             Thread.Sleep(5000);

            //             Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended!");
            //         }).Start();
            //     }));

            // });

            Console.WriteLine("Main Thread started!");
            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();

            thread1.Join();
            Console.WriteLine("Thread1 Function Done");
            thread2.Join();
            Console.WriteLine("Thread2 Function Done");


            Console.WriteLine("Main thread ended!");

            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1Function done!");
            }
            else
            {
                Console.WriteLine("Threa1Function wasnt done in one sec");
            }
            thread2.Join();
            Console.WriteLine("Thread2Function done");

            for(int i =0; i < 10; i++)
            {
                if (thread1.IsAlive)
                { 
                    Console.WriteLine("Thread1 is still doing stuff");
                    Thread.Sleep(300);
                }
                else
                {
                    Console.WriteLine("Thread1 completed");
                }
            }
           


            Console.ReadLine();

        }
        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");

            Thread.Sleep(3000);
            Console.WriteLine("Thread1Function coming back to caller.");
        }

            
            public static void Thread2Function()
            {
            Console.WriteLine("Thread2Fucntion started");
            }
    }
}
