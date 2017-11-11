using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.Extensions.Logging;
using QuickApp.Services;

namespace QuickApp.Controllers
{
    [Route("api/[controller]")]
    public class DoctorController : Controller
    {
        readonly ILogger _logger;
        private IDoctorService _service;

        public DoctorController(ILogger<DoctorController> logger, IDoctorService service)
        {
            _logger = logger;
            _service = service;
        }

       // [Authorize(Roles = "Admin")]
        [HttpGet("GetAllCustomers")]
        public IActionResult GetAllCustomers()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var response = _service.GetAllCustomers();

                return Ok(response);
            }
            catch (Exception e)
            {
                _logger.LogError(0, e, "Failed to Create Favour request");
                return StatusCode(500, new Error(e.Message));
            }
        }
    }
}
