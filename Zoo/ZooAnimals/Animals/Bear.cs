using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals.Animals
{
    class Bear : LandAnimals
    {
        public override string Color { get; set; } = "black"
        public override string[] Diet { get; set; } = { "hikers", "berries" }
        public override string Habitat { get; set; } = "forest"
    }
}
