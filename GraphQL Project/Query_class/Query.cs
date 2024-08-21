namespace GraphQL_Project.Query_class
{
    public class Query
    {
        public Book GetBook() =>
         new Book
         {
             Title = "C# in depth.",
             Author = new Author
             {
                 Name = "Jon Skeet"
             }
         };


        Author author = new Author() { Name = "Adnan" };
        public IEnumerable<Book> GetBooks() => new List<Book>() {
       

            new Book {Title = "Idun" , Author = author},
            new Book {Title = "Tippla" , Author = author},

            };
    }
}
