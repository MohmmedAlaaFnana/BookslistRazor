using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;


namespace BookslistRazor.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        [Required(ErrorMessage = "*ISBN cant be blank")]
        public string ISBN { get; set; }

        [Required]
        public int TotalPagers { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public int PublisherId { get; set; }

        [Required]
        public int GenreId { get; set; }


    }
}
