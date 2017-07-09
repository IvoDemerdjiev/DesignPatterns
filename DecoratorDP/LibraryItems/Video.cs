using System;

namespace DecoratorDP
{
    public class Video : LibraryItem
    {
        private string director;
        private int playTime;
        private string title;

        public Video(string director, string title,
            int playTime, int numberOfCopies)
        {
            this.director = director;
            this.playTime = playTime;
            this.title = title;
            this.NumberOfCopies = numberOfCopies;
        }
        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", director);
            Console.WriteLine(" Title: {0}", title);
            Console.WriteLine(" # Copies: {0}", NumberOfCopies);
            Console.WriteLine(" Playtime: {0}\n", playTime);
        }
    }
}