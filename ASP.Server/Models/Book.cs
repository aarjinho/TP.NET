﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ASP.Server.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        public IEnumerable<Author> Authors { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string Content { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        // Mettez ici les propriété de votre livre: Nom, Autheur, Prix, Contenu et Genres associés
        // N'oublier pas qu'un livre peut avoir plusieur genres
    }
}