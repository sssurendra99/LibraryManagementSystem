using System;
using LibraryManagementSystem.classes;


namespace LibraryManagementSystem
{
    public class Program
    {
        static void Main(string[] args){

            var m = new Member();
            

            var library = new Library();
            
            library.MenuOfLibrarySystem();
        }
    }
}
