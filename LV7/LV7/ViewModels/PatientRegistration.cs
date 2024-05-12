using LV7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LV7.ViewModels
{
    public class PatientRegistration
    {
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public ICollection<Patient> Patients { get; set; }

        public int SelectedPatientId { get; set; }
    }
}