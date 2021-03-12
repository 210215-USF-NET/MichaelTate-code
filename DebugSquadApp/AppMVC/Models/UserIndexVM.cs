using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Models
{
    public class UserIndexVM
    {
        public string name;
        [DisplayName("User Name")]
        public string Name { get; set;  }

        
    }
}
