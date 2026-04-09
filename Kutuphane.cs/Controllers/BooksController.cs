using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kutuphane.Data;
using Kutuphane.cs.Models;

namespace Kutuphane.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }

            public IActionResult Index()
            {
                var books = _context.Books.ToList();
                return View(books);
            }

            
            [HttpGet]
            public IActionResult Add()
            {
                return View();
            }

            
            [HttpPost]
            public IActionResult Add(Book newBook)
            {
                _context.Books.Add(newBook);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            
            [HttpGet]
            public IActionResult Update(int id)
            {
                var book = _context.Books.Find(id);
                if (book == null)
                {
                    return NotFound();
                }
                return View(book);
            }

           
            [HttpPost]
            public IActionResult Update(Book updatedBook)
            {
                _context.Books.Update(updatedBook);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

      
            public IActionResult Remove(int id)
            {
                var book = _context.Books.Find(id);
                if (book == null)
                {
                    return NotFound();
                }

                _context.Books.Remove(book);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    }
}
