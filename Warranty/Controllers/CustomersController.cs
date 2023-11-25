using Microsoft.AspNetCore.Mvc;
using Warranty.Context;
using Warranty.Entities;
using Warranty.ViewModels.Customers;

namespace Warranty.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        #region Services & Constructor
        private readonly AppDbContext _dbContext;

        public CustomersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        [HttpPost]
        public IActionResult Create(CreateCustomer command)
        {
            var customer = new Customer
            {
                Name = command.Name,
                Email = command.Email,
                MobileNumber = command.MobileNumber,
                Address = command.Address,
                CreatedBy = "",
                LastUpdatedBy = "",
                Predefined = false,
                PredefinedValue = ""
            };

            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();

            return Ok("Created Successfully");
        }

        [HttpPut]
        public IActionResult Update(UpdateCustomer command)
        {
            var exCustomer = _dbContext.Customers.Find(command.Id);

            if(exCustomer == null)
            {
                return NotFound();
            }

            exCustomer.Name = command.Name;
            exCustomer.Email = command.Email;
            exCustomer.MobileNumber = command.MobileNumber;
            exCustomer.Address = command.Address;

            _dbContext.SaveChanges();

            return Ok("Updated Successfully");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var customer = _dbContext.Customers.Find(id);

            if (customer == null)
            {
                return NotFound();
            }

            customer.Archived = true;

            _dbContext.SaveChanges();

            return Ok("Successfully Deleted");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var customer = _dbContext.Customers.FirstOrDefault(f => f.Archived == null && f.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            var customerDetails = new GetCustomer
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                MobileNumber = customer.MobileNumber,
                Address = customer.Address
            };

            return Ok(customerDetails);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _dbContext.Customers.ToList();

            var customerList = customers.Select(s => new GetCustomer
            {
                Id = s.Id,
                Name = s.Name,
                Email = s.Email,
                MobileNumber = s.MobileNumber,
                Address = s.Address
            }).ToList();

            return Ok(customerList);
        }
    }
}
