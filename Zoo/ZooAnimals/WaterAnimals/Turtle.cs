using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals.WaterAnimals
{
    //this is an actual object (children)
    public class Turtle : AquaticAnimals
    {
       public override int Legs { get; set; } = 4

        public override void CanLiveOnLand()
        {
            Console.WriteLine("Turtles spend lots of time on the beach");
        }

        public override void LaysEggs()
        {
            Console.WriteLine("Turtles lay eggs");
        }



    }

}
