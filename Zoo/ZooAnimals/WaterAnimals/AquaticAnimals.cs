using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals
{
    abstract class AquaticAnimals : ZooAnimals
    {
        public override string Color { get; set; } = "blue";

        public virtual void CanSwim(bool swims)
        {
            bool canSwim = swims;
            if (canSwim == false)
            {
                Console.WriteLine("this water animal does not swim");
            }
            else
            {
                Console.WriteLine("this water animal can swim!");
            }
        }
        public abstract void LivesInOcean();

    }
   
}
