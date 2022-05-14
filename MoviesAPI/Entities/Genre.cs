﻿using MoviesAPI.Filters;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field with name {0} is required (from genre)")]
        [StringLength(50)]
        [FirstLetterUppercase]
        public string? Name { get; set; }
    }
}