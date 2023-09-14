using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyShop.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ItemDbContext _itemDbContext;

        public CustomerController(ItemDbContext itemDbContext)
        {
            _itemDbContext = itemDbContext;
        }
        
        public async Task<IActionResult> Table()
        {
            List<Customer> customers = await _itemDbContext.Customers.ToListAsync();
            return View(customers);
        }
    }
}

