using System;

namespace LibraryManagementSystem{
    namespace classes{
        public class Book{
            public string? Title {get; set;}
            public string? Author {get; set;}
            public int PublicationYear {get; set;}
            public enum Category 
            {
                Fiction,
                History,
                Child
            }

            public bool Available {get; set;}
            
            
            
        }
    }
}