using AppModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

        [DisplayName("Assigned To")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Status")]
        [Required]
        public string StuffStatus { get; set; }
    }
}