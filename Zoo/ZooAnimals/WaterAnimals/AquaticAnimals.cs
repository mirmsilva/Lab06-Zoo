using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals
{
    //this is still not an object (parent)
    public abstract class AquaticAnimals : ZooAnimals
    {
        //Inherited from Zoo Animals
        public override string Color { get; set; } = "blue"
        public override string[] Diet { get; set;} = {"plankton", "seaweed"}

        //Don't need to do anything yet will pass on to turtle
        public override int Legs { get; set; }

        public override void TheySleep()
        {
            Console.WriteLine("Aquatic Animals sleep");
        }

        //Some can live on land
        public virtual void CanLiveOnLand();

        //They all live in or near water
        public abstract string TypeOfWater { get; set; }

        //Some lay eggs
        public virtual void LaysEggs();


    }
   
}
