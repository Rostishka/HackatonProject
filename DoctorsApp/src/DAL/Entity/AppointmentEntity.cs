using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class AppointmentEntity
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public PatientEntity Patient{ get; set; }
        public int PatientId { get; set; }
        public string Comment { get; set; }
    }
}
