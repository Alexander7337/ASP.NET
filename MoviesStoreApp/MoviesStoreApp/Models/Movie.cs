namespace MoviesStoreApp.Models
{
    using Attributes;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Movie
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Director { get; set; }

        //[Display(Name = "Date released")]
        [DateValidation(ErrorMessage = "Cannot hold a future date!")]
        public DateTime? ReleaseDate { get; set; }

        public string Genre { get; set; }

        public string Rating { get; set; }
    }
}