﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_UC2_UC3_AddUpdateRemove
{
    class contact
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public contact(string name, string address)
        {
            Name = name;
            Address = address;

        }
    }
}
