using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LV7.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please input Patient Name!")]
        public string Name { get; set; }

        public string Gender { get; set; }

        [DisplayName("Code For Patient")]
        [Range(10000, 99999, ErrorMessage = "Please input a valid Patient Code. The Patient Code must be between 10000 - 99999!")]
        public int PatientCode { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }

        public Patient() { 
            this.Doctors = new List<Doctor>();
        }


    }
}