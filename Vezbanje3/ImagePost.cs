using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje3
{
    //ImagePost derives from Post and adds a property (ImageURL) and two constructors
    class ImagePost:Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            //The following properties and the GetNextID method are inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            //Property ImageURL is a member of ImagePost, but not of Post
            this.ImageURL = imageURL;
            this.isPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} - {this.SendByUsername} ");
        }

    }
}
