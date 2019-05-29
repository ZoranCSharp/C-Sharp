using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3

        }

        static void Main(string[] args)
        {
            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //var methodId = 3;

            //Console.WriteLine((ShippingMethod)methodId);

            //Console.WriteLine(method.ToString());

            //var methodName = "Express";

            //var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            //Console.WriteLine((int)shippingMethod);

            //var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            ////Length
            //Console.WriteLine($"Length: {numbers.Length}");

            ////IndexOf()
            //var index = Array.IndexOf(numbers, 9);

            ////Clear()
            //Array.Clear(numbers, 0, 2);

            //Console.WriteLine("Effects of Clear()");
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            ////Copy()
            //int[] another = new int[3];
            //Array.Copy(numbers, another, 3);

            //Console.WriteLine("Effects of Copy()");
            //foreach (var cop in another)
            //{
            //    Console.WriteLine(cop);
            //}

            ////Sort()

            //Array.Sort(another);

            //Console.WriteLine("Effects of Sort()");
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            ////Reverse()
            //Array.Reverse(numbers);

            //Console.WriteLine("Effect of Reverse()");

            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //var x = 0;
            //Console.WriteLine("\n" + Math.Pow(0,0));

            var numbers = new List<int>() { 1,2,3,4,5};
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            
            Console.WriteLine($"Index of 1: {numbers.IndexOf(1)}" );
            Console.WriteLine($"Last index of 1: {numbers.LastIndexOf(1)}");

            Console.WriteLine($"Count: {numbers.Count}" );

            for(var i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
               
            }

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.Clear();
            Console.WriteLine($"Count: {numbers.Count}");

            //not allowed to remove in foreach loop. Must use regular for loop
            //foreach (var n in numbers)
            //{
            //    if(n == 1)
            //    {
            //        numbers.Remove(n);
            //    }
            //    Console.WriteLine(n);
            //}


            Console.ReadKey();
        }
    }
}
