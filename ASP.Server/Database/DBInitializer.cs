using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ASP.Server.Models;

namespace ASP.Server.Database
{
    public class DbInitializer
    {
        public static void Initialize(LibraryDbContext bookDbContext)
        {
            if (bookDbContext.Books.Any())
                return;

            // Genres
            var genres = new List<Genre>
            {
                new Genre { Name = "Science Fiction" },
                new Genre { Name = "Classic" },
                new Genre { Name = "Romance" },
                new Genre { Name = "Thriller" }
            };
            bookDbContext.Genre.AddRange(genres);
            bookDbContext.SaveChanges();

            // Authors are associated with Books, so no need to add them separately

            // Books
            var books = new List<Book>
            {
                new Book
                {
                    Authors = new List<Author> { new Author { Name = "Auteur1" } },
                    Title = "Livre1",
                    Content = "contenu1",
                    Genres = new List<Genre> { genres[2], genres[3] }
                },
                new Book
                {
                    Authors = new List<Author> { new Author { Name = "Victor Hugo" }, new Author { Name = "Shakespeare" } },
                    Title = "Livre2",
                    Content = "contenu2",
                    Genres = new List<Genre> { genres[0] }
                },
                new Book
                {
                    Authors = new List<Author> { new Author { Name = "Auteur4" }, new Author { Name = "Auteur5" } },
                    Title = "Livre3",
                    Content = "contenu3",
                    Genres = new List<Genre> { genres[1], genres[3] }
                },
                new Book
                {
                    Authors = new List<Author> { new Author { Name = "Auteur1" }, new Author { Name = "Auteur5" } },
                    Title = "Livre4",
                    Content = "contenu4",
                    Genres = new List<Genre> { genres[0] }
                }
            };
            bookDbContext.Books.AddRange(books);
            bookDbContext.SaveChanges();
        }
    }
}