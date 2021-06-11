using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("create")]
        public IActionResult Create(CreateCustomerDto createCustomerDto)
        {
            var result = _customerService.Create(createCustomerDto);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateCustomerDto updateCustomerDto)
        {
            var result = _customerService.Update(updateCustomerDto);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("updateaddress")]
        public IActionResult UpdateAddress(CustomerAddress customerAddress)
        {
            var result = _customerService.UpdateAddress(customerAddress);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("updatecontact")]
        public IActionResult UpdateContact(CustomerContact customerContact)
        {
            var result = _customerService.UpdateContact(customerContact);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut("updatereference")]
        public IActionResult UpdateReference(CustomerReference customerReference)
        {
            var result = _customerService.UpdateReference(customerReference);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getaddress")]
        public IActionResult GetAddress(string customerNumber)
        {
            var result = _customerService.GetAddress(customerNumber);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcontact")]
        public IActionResult GetContact(string customerNumber)
        {
            var result = _customerService.GetContact(customerNumber);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getdetail")]
        public IActionResult GetDetail(string customerNumber)
        {
            var result = _customerService.GetDetail(customerNumber);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("geteducation")]
        public IActionResult GetEducation(string customerNumber)
        {
            var result = _customerService.GetEducation(customerNumber);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("gethouse")]
        public IActionResult GetHouse(string customerNumber)
        {
            var result = _customerService.GetHouse(customerNumber);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getidentity")]
        public IActionResult GetIdentity(string customerNumber)
        {
            var result = _customerService.GetIdentity(customerNumber);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getprofession")]
        public IActionResult GetProfession(string customerNumber)
        {
            var result = _customerService.GetProfession(customerNumber);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getreference")]
        public IActionResult GetReference(string customerNumber)
        {
            var result = _customerService.GetReference(customerNumber);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}