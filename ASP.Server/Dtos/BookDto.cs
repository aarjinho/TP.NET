using ASP.Server.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;

namespace ASP.Server.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Content { get; set; }
        public List<string> Genres { get; set; } 
    }

    public class GenreDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
