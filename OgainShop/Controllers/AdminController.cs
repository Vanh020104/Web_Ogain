using Microsoft.AspNetCore.Mvc;

namespace OgainShop.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/

        // Order Management
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
        public IActionResult product()
        {
            return View("ProductManagement/product");
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
        public IActionResult revenue()
        {
            return View("RevenueManagement/revenue");
        }

    }
}
