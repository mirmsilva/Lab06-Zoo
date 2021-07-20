using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals
{
    class Flamingo : Bird
    {
        public override string Color { get; set; }

        public override void hasFeathers()
        {
            Console.WriteLine("Is Flying");
        }

        public override void IsZooAnimal()
        {
            Console.WriteLine("Flamingos are Birds which are Zoo Animals!");
        }

    }
}
