using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje3
{
    class Program
    {

        public interface INotifications
        {
        //Members
        void showNotification();
        string getDate();

        }

        public class Notification : INotifications
        {
            private string sender;
            private string message;
            private string date;

            //Default constructor
            public Notification()
            {
                sender = "Admin";
                message = "Yo, what's up?";
                date = " ";

            }

            public Notification(string mySender, string myMessage, string myDate)
            {
                this.sender = mySender;
                this.message = myMessage;
                this.date = myDate;
            } 

            public void showNotification()
            {
                Console.WriteLine($"Message {message} - was sent by {sender} - date {date}");
            }

            public string getDate()
            {
                return date;
            }
        }
    
        static void Main(string[] args)
        {
            Post post1 = new Post("'Thanks for the birthday wishes!!!'", true, "Zoran Kovacevic" );
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("'Check out my new shoes'", "Zoran Kovacevic", "https://images.com//shoes", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("'C# Video tutorial'", "Zoran Kovacevic", "http://fakevideo.com/video", true, 30);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
           
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nPress any key to stop the video!\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\nPlaying...");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;                    
            Console.ReadKey();
            
            videoPost1.Stop();


            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Employee michael = new Employee("Michael", "Miller", 40000);

            michael.Work();
            michael.Pause();
           

            Boss chuckNorris = new Boss("Ferrari", "Norris", "Chuck", 999999999);

            chuckNorris.Lead();

            Trainee michelle = new Trainee(32, 8, "Gartner", "Michelle", 10000);
            michelle.Learn();
            michelle.Work();

            Notification n1 = new Notification("Denis", "Tsup bro?", "12.06.2018");
            Notification n2 = new Notification("Frank", "All good buddy!", "12.06.2018");
            n1.showNotification();
            n2.showNotification();
            n1.getDate();
            Console.ReadLine();

        }
       
    }
}
