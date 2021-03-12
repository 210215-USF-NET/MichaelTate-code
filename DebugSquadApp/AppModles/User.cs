using System;

namespace AppModels
{
    public class User
    {
        private string name;
        private int id;

        public int Id { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("Customer name can't be empty or null");
                }
                name = value;
            }
        }

        //public override string ToString() => $"User Details: \nId: {this.Id}\n name: {this.Name}";
    }
}