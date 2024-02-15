using BusinessLayer;
using DataAccesslayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IActionResult> Kendo()
        {
            var customer = await _customerService.GetCustomersAsync();
            return View(customer);
        }

        public async Task<IActionResult> Index()
        {
            var customer = await _customerService.GetCustomersAsync();
            return View(customer);
        }

        public async Task<IActionResult> GetData()
        {
            var customer = await _customerService.GetCustomersAsync();
            return Json(customer);
        }

        [HttpPost]
        public async Task<IActionResult> CreateData(NewCustomer newCustomer)
        {
             await _customerService.CreateCustomerAsync(newCustomer);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateData(NewCustomer newCustomer)
        {
            await _customerService.UpdateCustomer(newCustomer);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteData(int id)
        {
            await _customerService.DeleteCustomer(id);
            return Ok();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
