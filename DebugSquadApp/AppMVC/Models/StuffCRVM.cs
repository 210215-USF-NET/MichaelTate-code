using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Models
{
    public class StuffCRVM
    {
        [DisplayName("Task Name")]
        [Required]
        public string StuffName { get; set; }

        [DisplayName("Task Description")]
        [Required]
        public string StuffDescription { get; set; }

        [DisplayName("Status")]
        [Required]
        public string StuffStatus { get; set; }
    }
}