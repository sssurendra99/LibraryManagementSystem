using System;
using LibraryManagementSystem.enums;

namespace LibraryManagementSystem
{

    namespace classes
    {
    
        public class Book
        {
            private static int bookId = 1234567890;

            public int BookId {get; private set;}

            public string? Title {get; set;}
            
            public string? Author {get; set;}
            
            public int PublicationYear {get; set;}
            
            public BookCategory CategoryOfTheBook {get; set;}

            public bool Available {get; set;}

            public override string ToString()
            {
                return $"Title: {Title}\tBookID: {BookId}\tCategory: {CategoryOfTheBook}\tAuthor: {Author}\tPublicationYear: {PublicationYear}\tAvailability: {Available}\n";
            }


            public Book()
            {
                this.Available = true;
                this.BookId = bookId++;
            }

            public Book(string title, string author, int publicationYear, BookCategory bookCategory)
            {
                this.Title = title;
                this.Author = author;
                this.PublicationYear = publicationYear;
                this.CategoryOfTheBook = bookCategory;
                
                this.Available = true;

                this.BookId = bookId++;
                
            }

        }

    }
}