﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiApp.Models
{
    public class Driver
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public Order CurrentOrder { get; set; }
    }
}
