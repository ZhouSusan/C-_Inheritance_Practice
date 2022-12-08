﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
