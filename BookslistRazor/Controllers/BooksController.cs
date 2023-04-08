using BookslistRazor.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookslistRazor.Controllers
{
    public class BooksController : Controller
    {
        private readonly DataContext _context;

        public BooksController(DataContext context)
        {
            _context = context;

        }

         
        {
        }
    }

}
