using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals
{
    class Dolphin : AquaticAnimals
    {

        public override void CanSwim(bool swims)
        {
            base.CanSwim(swims);
        }

        public override void LivesInOcean()
        {
            Console.WriteLine("Dolphins do live in the ocean!");
        }
        public override void IsZooAnimal()
        {
            Console.WriteLine("Dolphins are Zoo Animals");
        }
    }
}
