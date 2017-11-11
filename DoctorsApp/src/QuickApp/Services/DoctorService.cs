using System.Collections.Generic;
using DAL.Interfaces;
using DAL.Models;

namespace QuickApp.Services
{
    public class DoctorService : IDoctorService
    {
        private IUnitOfWork _unitOfWork;
        public DoctorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _unitOfWork.Customers.GetAllCustomersData();
        }
    }
}
