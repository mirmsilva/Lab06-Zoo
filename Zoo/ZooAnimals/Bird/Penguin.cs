using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals
{
    class Penguin : Bird
    {
        public override string Color { get; set; }

        public override void hasFeathers()
        {
            Console.WriteLine("Feathers but, more Furish");
        }
        public override void isPecking()
        {
            Console.WriteLine("Sure");
        }
        public override void IsZooAnimal()
        {
            Console.WriteLine("Penguins are Birds which are Zoo Animals!");
        }

    }
}
