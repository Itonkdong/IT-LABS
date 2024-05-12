using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LV7.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int HospitalId { get; set; }

        public Hospital Hospital { get; set; }

        public ICollection<Patient> Patients { get; set; }

        public Doctor() { 
            this.Patients = new List<Patient>();
        }
    }
}