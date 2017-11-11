using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.Extensions.Logging;
using QuickApp.Services;

namespace QuickApp.Controllers
{
    public class DoctorController : Controller
    {
        //private IUnitOfWork _unitOfWork;
        readonly ILogger _logger;
        private IDoctorService _service;

        public DoctorController(/*IUnitOfWork unitOfWork, */ILogger<DoctorController> logger, IDoctorService service)
        {
           // _unitOfWork = unitOfWork;
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
