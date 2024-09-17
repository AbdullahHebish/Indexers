namespace indexers
{
    public class program
    {
        static void Main(string[] args)
        {
            BookCollection book = new BookCollection();
            book[0]=new Book() { Author = "Author1",Title = "Free Palestine"};
            book[1] = new Book() { Author = "Author2", Title = "Free soudan" };
            Console.WriteLine(book[0].Title);
            Console.WriteLine(book["Free Palestine"].Author);
        }
    }
   
}