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
            var kitaplar = _context.Books.Include(b => b.Kategori).ToList();
            return View(kitaplar);
            }

            
            [HttpGet]
            public IActionResult Add()
            {
       
 
            ViewBag.Kategoriler = new SelectList(_context.Kategoriler.ToList(), "Id", "Name");
            return View();
            }


        [HttpPost]
        [ValidateAntiForgeryToken] 
        public IActionResult Add(Book newBook)
        {
            if (ModelState.IsValid)
            { 
                _context.Books.Add(newBook);
                _context.SaveChanges();
                TempData["Success"] = "Kitap başarıyla eklendi!"; 
                return RedirectToAction("Index");
            }
            return View(newBook);
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
        [ValidateAntiForgeryToken] 
        public IActionResult Update(Book updatedBook)
        {
            if (ModelState.IsValid) 
            {
                _context.Books.Update(updatedBook); 
                _context.SaveChanges();             

                TempData["SuccessMessage"] = "Kitap başarıyla güncellendi!"; 
                return RedirectToAction("Index");   
            }
            return View(updatedBook);
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
