using System.Linq;
namespace Store.Memory;
public class BookRepository : IBookRepository
{
    private readonly Book[] books = new[]
    {
        new Book(1, "Art of Programming", "ISBN 12312-31231", "D. Knuth", "The bible of all fundamental algorithms and the work that taught many of today’s software developers most of what they know about computer programming.", 99.9m),
        new Book(2, "Refactoring", "ISBN 12312-31232", "M. Fowler", "Martin Fowler’s guide to reworking bad code into well-structured code\r\n\r\nRefactoring improves the design of existing code and enhances software maintainability, as well as making existing code easier to understand. Original Agile Manifesto signer and software development thought leader, Martin Fowler, provides a catalog of refactorings that explains why you should refactor; how to recognize code that needs refactoring; and how to actually do it successfully, no matter what language you use.", 47.49m),
        new Book(3, "C Programming Language", "ISBN 12312-31233", "B. Kernighan, D. Ritchie", "The bible of all fundamental algorithms and the work that taught many of today’s software developers most of what they know about computer programming.", 228.0m)
    };

    public Book[] GetAllByIsbn(string isbn)
    {
        return books.Where(book => book.Isbn == isbn)
            .ToArray();
    }   


    public Book[] GetAllByTitleOrAuthor(string titlePart)
    {
        return books.Where(book => book.Author.Contains(titlePart)
                                || book.Title.Contains(titlePart))
            .ToArray();
    }

    public Book GetById(int id)
    {
        return books.Single(book => book.Id== id);
    }
}

