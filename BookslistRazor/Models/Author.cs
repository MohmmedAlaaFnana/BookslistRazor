using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookslistRazor.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string AutherName { get; set; }

    }
}
