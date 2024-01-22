using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OgainShop.Data;

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
        public IActionResult order()
        {
            return View("OrderManagement/order");
        }
        public IActionResult detailOrder()
        {
            return View("OrderManagement/detailOrder");
        }

        // Customer Management
        public IActionResult customer()
        {
            return View("CustomerManagement/customer");
        }

        // Product Management
        public async Task<IActionResult> Product()
        {
            var ogainShopContext = _context.Product.Include(p => p.Category);
            return View("ProductManagement/Product", await ogainShopContext.ToListAsync());
        }


        public IActionResult addProduct()
        {
            return View("ProductManagement/addProduct");
        }
        public IActionResult editProduct()
        {
            return View("ProductManagement/editProduct");
        }

        // Dashboard
        public IActionResult dashboard()
        {
            return View("DashboardAdmin/dashboard");
        }


        // Revenue
        public IActionResult revenue()
        {
            return View("RevenueManagement/revenue");
        }

    }
}
