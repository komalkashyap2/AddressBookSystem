using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
      class Contact1
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Contact1(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
