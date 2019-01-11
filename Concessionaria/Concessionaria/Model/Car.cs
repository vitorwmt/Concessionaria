using System;
using System.Collections.Generic;
using System.Text;

namespace Concessionaria.Model
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
