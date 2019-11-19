using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiApp.Models
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Cost { get; set; }

        public double Location { get; set; }

        public State State { get; set; }
        public Client Client { get; set; }
    }
}
