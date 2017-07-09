﻿namespace DecoratorDP
{
    using System;
    using System.Collections.Generic;

    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) 
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumberOfCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumberOfCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}