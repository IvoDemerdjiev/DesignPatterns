using System;

namespace DecoratorDP
{
    public class Book : LibraryItem
    {
        public string author;
        public string title;

        public Book(string author, string title, int numberOfCopies)
        {
            this.author = author;
            this.title = title;
            this.NumberOfCopies = numberOfCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", author);
            Console.WriteLine(" Title: {0}", title);
            Console.WriteLine(" # Copies: {0}", NumberOfCopies);
        }
    }
}