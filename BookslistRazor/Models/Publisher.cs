﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookslistRazor.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        [Required]
        public string PublisherName { get; set; }

    }
}
