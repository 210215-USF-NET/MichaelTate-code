using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels
{
    public class Stuff
    {

        //eventName
        private string stuffName;

        //event description
        private string stuffDescription;

        private string userId;

        //date
        public int Id { get; set; }

        public string StuffName
        {
            get { return stuffName; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("Customer name can't be empty or null");
                }
                stuffName = value;
            }
        }

        public string StuffDescription
        {
            get { return stuffDescription; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("Customer name can't be empty or null");
                }
                stuffDescription = value;
            }
        }

        public string StuffStatus { get; set; }

        //public User Name { get; set; }

    }
}