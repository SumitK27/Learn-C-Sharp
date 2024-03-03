namespace LINQs
{
    public static class Print
    {

        public static void PrintBook(Book book)
        {
            Console.WriteLine($"Title: {book.Title} \t Price: ${book.Price}");
        }

        public static void PrintBookNames(IEnumerable<string> bookNames)
        {
            foreach (var book in bookNames)
            {
                Console.WriteLine(book);
            }
        }

        public static void PrintBookOrNotFound(Book? firstOrDefaultBook)
        {
            Console.WriteLine(firstOrDefaultBook == null ? "Book not found" : $"Title: {firstOrDefaultBook.Title} \t Price: ${firstOrDefaultBook.Price}");
        }

        public static void PrintBooks(IEnumerable<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title} \t Price: ${book.Price}");
            }
        }
    }
}