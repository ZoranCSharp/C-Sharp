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
            //Console.WriteLine("Hello World!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World!");
            //Thread.Sleep(1000);

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread One");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread Two");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread Three");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread Four");
            }).Start();

           
            Console.ReadLine();
        }
    }
}
