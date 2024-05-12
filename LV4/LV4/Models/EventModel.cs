using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LV4.Models
{
    public class EventModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please input a Event Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please input a Event Location")]
        public string Location { get; set; }

    }
}