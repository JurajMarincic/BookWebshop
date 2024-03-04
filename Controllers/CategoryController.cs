﻿using BookWebshop.Data;
using BookWebshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWebshop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> categoryList = _context.Categories.ToList();
            return View(categoryList);
        }
    }
}
