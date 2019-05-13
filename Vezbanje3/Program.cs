using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje3
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("'-Thanks for the birthday wishes!!!'", true, "Zoran Kovacevic" );
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Zoran Kovacevic", "https://images.com//shoes", true);
            Console.WriteLine(imagePost1.ToString());

            Console.ReadKey();
        }
    }
}
