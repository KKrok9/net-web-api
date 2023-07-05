using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zKsiekiem.Models;
using zKsiekiem.Services;

namespace zKsiekiem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        //GET
        [HttpGet("GetCustomers")]
        public IActionResult GetCustomers()
        {
            var result = _customerService.GetAllCustomers();
            return Ok(result);
        }

        [HttpGet("GetSingleCustomer")]
        public IActionResult GetSingleCustomer(int id)
        {
            var result = _customerService.GetSingleCustomer(id);
            return Ok(result);
        }

        [HttpDelete("DeleteCustomer")]
        public IActionResult DeleteCustomer(int id)
        {
            _customerService.DeleteCustomer(id);
            return Ok();
        }

        [HttpPut("UpdateCustomer")]
        public IActionResult UpdateCustomer(Customer customer, int id)
        {
            _customerService.UpdateCustomer(customer, id);
            return Ok();
        }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerService.AddCustomer(customer);
            return Ok();
        }

    }
}