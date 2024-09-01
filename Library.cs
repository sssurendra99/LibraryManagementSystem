using LibraryManagementSystem.enums;

namespace LibraryManagementSystem
{
    namespace classes
    {
        public class Library
        {
            private List<Book> books = new List<Book>();

            private List<Member> members = new List<Member>();

            public void RegisterMember(){

                var member = new Member();

                Console.WriteLine();                
                
                Console.WriteLine("Enter Name: ");
                member.Name = Console.ReadLine();

                
                Console.WriteLine("Enter Member type: (Member - 0\tStaff-Management - 1\tStaff-Minor - 2))");
                int memberType = Convert.ToInt32(Console.ReadLine());

                switch (memberType)
                {
                    case 0:
                        member.LibraryMemberType = MemberType.Member;
                        break;

                    case 1:    
                        member.LibraryMemberType = MemberType.StaffManagement;
                        break;

                    case 2: 
                        member.LibraryMemberType = MemberType.StaffMinor;
                        break;
            
                    default:
                        Console.WriteLine("Enter the correct type!");
                        break;    
                }

                members.Add(member);

                

            }

            public void MenuOfLibrarySystem(){
                
                Console.WriteLine("\nSelect an Operation: \n");

                string operations = $"\nAdd a book\t- 1\nDisplay books\t- 2\nBorrow a book\t- 3\nReturn a book\t- 4\nDisplay members\t- 5\nRemove a book\t- 6\nExit the System\t- 7\n\n";

                bool isSystemOn = true;

                while(isSystemOn){
                    // Display the menu
                    Console.Write(operations);

                    Console.WriteLine("Enter: ");
                    int operation = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n");

                    switch(operation){
                        case 1:
                            AddBook();
                            break;

                        case 2:
                            DisplayAllBooks();
                            break;

                        case 3:
                            AddBook();
                            break;

                        case 4:
                            AddBook();
                            break;

                        case 5:
                            Console.WriteLine("\nEnter the book id: \n");
                            break;

                        case 6:
                            AddBook();
                            break;

                        case 7:
                            Console.WriteLine("System shutting down! ");
                            isSystemOn = false;
                            break;

                        default: 
                            Console.WriteLine("Enter a valid operation!");
                            break;
                    }

                }
            }

            public Library(){
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine
                ("------------Welcome to Libray System--------------");
                Console.WriteLine("--------------------------------------------------");
            }

            public void AddBook()
            {
                var book = new Book();
                
                // Get the Book title
                Console.WriteLine("Enter Title: ");
                book.Title = Console.ReadLine();

                // Get the author of the book
                Console.WriteLine("Enter Author: ");
                book.Author = Console.ReadLine();

                // Get the Publication year
                Console.WriteLine("Enter Publication year: ");
                book.PublicationYear = Convert.ToInt32(Console.ReadLine());

                // Get the category
                Console.WriteLine("Enter the Book Category: (Fiction - 0\tHistory - 1\tChild - 2))");
                int userInput = Convert.ToInt32(Console.ReadLine());

                

                switch(userInput)
                {
                    case 0:
                        book.CategoryOfTheBook = BookCategory.Fiction;
                        break;

                    case 1: 
                        book.CategoryOfTheBook = BookCategory.History;
                        break;

                    case 2:
                        book.CategoryOfTheBook = BookCategory.Child;
                        break;

                    default:
                        Console.WriteLine("Not a given Genre!.\nCategory will keep empty!.");
                        book.CategoryOfTheBook = BookCategory.None;
                        break;

                }

                books.Add(book);

            }

            public void DisplayAllBooks(){
                
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("The available Books are: \n");

                

                foreach(Book book in books){


                    Console.Write(book.ToString());
                    
                }
            }

            public void BorrowBook(){

            }

            public List<Book> DisplayAvailableBooks(){
                var availableBooks = new List<Book>();

                foreach(Book book in books){
                    if(book.Available == true){
                        availableBooks.Add(book);
                    }
                }
                return availableBooks;
            }

            public void RemoveBook(Book book){

                books.Remove(book);

                DisplayAllBooks();

            }
            
        }
    }
}