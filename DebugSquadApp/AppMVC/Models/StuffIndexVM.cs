using AppModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Models
{
    public class StuffIndexVM
    {
        [DisplayName("Task Name")]
        public string StuffName { get; set; }

        [DisplayName("Task Description")]
        public string StuffDescription { get; set; }

        public string Name { get; set; }

        [DisplayName("Task Status")]
        public string StuffStatus { get; set; }
    }
}