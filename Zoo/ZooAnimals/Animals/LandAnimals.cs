using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals
{
    public abstract class LandAnimals : ZooAnimals, IHabit
    {
        public override string Color { get; set; } = "green";
        public override string[] Diet { get; set; } = { "vegetation", "other animals" };

        public override int Legs { get; set; }

        public override void TheySleep()
        {
            Console.WriteLine("Land Animals sleep");
        }

        public void Fast()
        {
            Console.WriteLine("Most Land Animals are fast but, some can be slow");
        }

        void IHabit.Diet()
        {
            Console.WriteLine("We eat people sometimes!");
        }

        public void Nocturnal()
        {
            Console.WriteLine("We all sleep at different times of the day");
        }

        public abstract string Habitat { get; set; }

        public virtual string HasHands { get; set; }
    }
}
