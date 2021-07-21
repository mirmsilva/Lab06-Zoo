using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals
{
    public abstract class Bird : ZooAnimals
    {
        public override string Color { get; set; } = "green"
        public override string[] Diet { get; set;} = {"worms", "bread crumbs"}

        public override int Legs { get; set; } = 2

        public override void TheySleep()
        {
            Console.WriteLine("Birds sleep");
        }

        public virtual void Flies();

        public abstract void LaysEggs();


    }
}
