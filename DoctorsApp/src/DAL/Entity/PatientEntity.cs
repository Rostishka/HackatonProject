using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class PatientEntity : ApplicationUser
    {
        public virtual List<AppointmentEntity> Apointments { get; set; } = new List<AppointmentEntity>();
        public virtual List<ReviewEntity> Reviews { get; set; } = new List<ReviewEntity>();
    }
}
