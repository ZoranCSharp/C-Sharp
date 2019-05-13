using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vezbanje3
{
    class VideoPost:Post
    {
        //Member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;


        //Properties
        protected string VideoURL { get; set; }
        public int Length { get; set; }
        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublished, int length)
        {
            //Folowing properties and the GetNextID method are inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.isPublic = isPublic;
            //Property VideoURL is a member of VideoPost, but not of Post
            this.VideoURL = videoURL;            
            this.Length = length;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length} - {this.SendByUsername} ");
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                
                timer = new Timer(TimerCallback, null, 0, 500);
            }
            
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.Write($"  ");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Stopped at {currDuration}");
                currDuration = 0;
                timer.Dispose();
            }
            
        }

    }
}
