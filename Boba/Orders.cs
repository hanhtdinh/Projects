using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boba
{
   public  class Orders
    {
        //properties of the drinks and customer information
        //link with phone number
        public string Type { get; set; }
        public string Size { get; set; }
        public string Toppings { get; set; }
        public string SweetnessLevel { get; set; }
        public string IceLevel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; }

        
        
    }
}
