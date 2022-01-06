using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipAPICreation.Models
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            string output = $"Make: {Make}\n";
            output += $"Model: {Model}\n";
            output += $"Year: {Year}\n";
            output += $"Color: {Color}\n";
            return output;
        }

    }


}
