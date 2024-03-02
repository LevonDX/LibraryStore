using LibraryStore.Data.Entities;
using LibraryStore.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryStore.API.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        [HttpGet]
        [Route("list")]
        public IActionResult List()
        {
            List<Book> books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "The Hobbit",
                    Description = "The Hobbit is the unforgettable story of Bilbo, a peace-loving hobbit, who embarks on a strange and magical adventure.",
                    ISBN = "9780345534835",
                    Authors = new List<Author>
                    {
                        new Author
                        {
                            Id = 1,
                            Name = "J.R.R. Tolkien"
                        }
                    }
                },
                new Book
                {
                    Id = 2,
                    Title = "The Fellowship of the Ring",
                    Description = "The Fellowship of the Ring is the first part of J.R.R. Tolkien's epic adventure, The Lord of the Rings.",
                    ISBN = "9780345534835",
                    Authors = new List<Author>
                    {
                        new Author
                        {
                            Id = 1,
                            Name = "J.R.R. Tolkien"
                        }
                    }
                }
            };

            List<BookViewModel> bookViewModels = new List<BookViewModel>();

            foreach (Book item in books)
            {
                BookViewModel bookViewModel = new BookViewModel
                {
                    Title = item.Title,
                    Description = item.Description,
                    Authors = new List<string>()
                };

                foreach (Author author in item.Authors)
                {
                    bookViewModel.Authors.Add(author.Name);
                }

                bookViewModels.Add(bookViewModel);
            }

            return Ok(bookViewModels);
        }
    }
}
