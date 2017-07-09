using System;

namespace PrototypeDP.Colors
{
    public class Color : ColorPrototype
    {
        private int red;
        private int green;
        private int blue;

        public Color(int red, int green,int blue)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
        }
        public override ColorPrototype Clone()
        {
            Console.WriteLine(
               "Cloning color RGB: {0,3},{1,3},{2,3}",
               red, green, blue);

            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
