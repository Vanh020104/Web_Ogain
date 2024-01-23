using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OgainShop.Data;
using OgainShop.Models.Authentication;

namespace OgainShop.Controllers
{
   
    public class AdminController : Controller
    {
        // GET: /<controller>/

        // Order Management

        private readonly OgainShopContext _context;

        public AdminController(OgainShopContext context)
        {
            _context = context;
        }
        [Authentication]
        public IActionResult order()
        {
            return View("OrderManagement/order");
        }
        [Authentication]
        public IActionResult detailOrder()
        {
            return View("OrderManagement/detailOrder");
        }
        [Authentication]
        // Customer Management
        public IActionResult customer()
        {
            return View("CustomerManagement/customer");
        }
        [Authentication]
        // Product Management
        public async Task<IActionResult> Product()
        {
            var ogainShopContext = _context.Product.Include(p => p.Category);
            return View("ProductManagement/Product", await ogainShopContext.ToListAsync());
        }
        [Authentication]

        public IActionResult addProduct()
        {
            return View("ProductManagement/addProduct");
        }
        [Authentication]
        public IActionResult editProduct()
        {
            return View("ProductManagement/editProduct");
        }
        [Authentication]
        // Dashboard
        public IActionResult dashboard()
        {
            return View("DashboardAdmin/dashboard");
        }

        [Authentication]
        // Revenue
        public IActionResult revenue()
        {
            return View("RevenueManagement/revenue");
        }

    }
}
