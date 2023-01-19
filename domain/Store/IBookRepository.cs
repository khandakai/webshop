using System;
namespace Store
{
	public interface IBookRepository
	{
		Book[] GetAllByIsbn(string isbn);

		Book[] GetAllByTitleOrAuthor(string titleofAuthor);

		Book GetById(int id);
	}
}