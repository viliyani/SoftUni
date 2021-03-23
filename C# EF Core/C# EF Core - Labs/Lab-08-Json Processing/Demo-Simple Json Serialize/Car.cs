﻿using System;
using System.Collections.Generic;

namespace JsonDemo
{
    public class Car
    {
        public string Model { get; set; }

        public string Vendor { get; set; }

        public decimal Price { get; set; }

        public DateTime ManufacturedOn { get; set; }

        public List<string> Extras { get; set; }

        public Engine Engine { get; set; }
    }
}
