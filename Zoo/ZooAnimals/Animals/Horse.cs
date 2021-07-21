using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals.Animals
{
    class Horse : LandAnimals
    {
        public override string Color { get; set; } = "multi colored"
        public override string[] Diet { get; set; } = { "grass", "hay" }
        public override string Habitat { get; set; } = "plains"
    }
}
