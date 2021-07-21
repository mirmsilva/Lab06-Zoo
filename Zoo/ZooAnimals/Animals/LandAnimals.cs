using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals
{
    public class LandAnimals : ZooAnimals
    {
        public override string Color { get; set; } = "green"
        public override string[] Diet { get; set; } = { "vegetation", "other animals" }

        public override int Legs { get; set; }

        public override void TheySleep()
        {
            Console.WriteLine("Land Animals sleep");
        }
        public abstract string Habitat {get; set;}

        public virtual string HasHands { get; set; }
    }
}
