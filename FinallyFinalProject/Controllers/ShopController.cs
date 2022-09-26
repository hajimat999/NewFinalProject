using FinallyFinalProject.DAL;
using FinallyFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinallyFinalProject.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext context;

        public ShopController(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        public async Task<IActionResult> Shop()
        {
            List<Category> categories = await context.Categories.ToListAsync();
            return View();
            
        }
         
    }
}
