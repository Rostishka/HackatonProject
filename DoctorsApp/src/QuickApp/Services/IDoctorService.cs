using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entity;
using DAL.Models;

namespace QuickApp.Services
{
    public interface IDoctorService
    {
        IEnumerable<Customer> GetAllCustomers();
    }
}
