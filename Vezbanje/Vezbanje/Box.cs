using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbanje
{
    class Box
    {
        public int length;
        public int heigth;
        public int width;
        public int volume;

        public int Length
        {   get { return length; }
            set { if (value < 0) value = -value; length = value; }
        }
        public int Heigth {
            get { return heigth; }
            set { if (value < 0) value = -value; heigth = value; }            
            }
        public int Width {

            get { return width; }

            set {
                if (value < 0)
                    value = -value;

                width = value;
            }
        }

        public int Volume { get { return volume; } set { volume = value; } }

        public void DisplayInfo()
        {
            Volume = Length * Heigth * Width;
            Console.WriteLine($"Length is {Length} and height is {Heigth} and width is {Width} so the volume is {Volume}");
        }

        public Box(int length, int heigth, int width)
        {
            this.length = length;
            this.heigth = heigth;
            this.width = width;
        }

        public int FrontSurface
        {
            get { return heigth * length; }
        }
    }
}
