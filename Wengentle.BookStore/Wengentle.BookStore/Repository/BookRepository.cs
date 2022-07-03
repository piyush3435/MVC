using Webgentle.BookStore.Models;
namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return (List<BookModel>)DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "MVC", Author = "Nitish" },
                new BookModel() { Id = 2, Title = "C#", Author = "Akash" },
                new BookModel() { Id = 3, Title = "JAVA", Author = "Jack" },
                new BookModel() { Id = 4, Title = "Python", Author = "Mahesh" },
                new BookModel() { Id = 5, Title = "Dot Net Core", Author = "Piyush" },
            };
        }
    }
}
