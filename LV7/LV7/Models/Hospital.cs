using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LV7.Models
{
    public class Hospital
    {
        public int Id { get; set; }

        [DisplayName("Hospital Name")]
        public string Name { get; set; }

        [DisplayName("Hospital Location")]
        public string Locationtion { get; set; }

        [DisplayName("Hospital Picture")]
        public string ImageUrl { get; set; }

    }
}