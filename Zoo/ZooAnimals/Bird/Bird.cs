using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals
{
    abstract class Bird : ZooAnimals
    {
        public override string Color { get; set; } = "black";


        public abstract void hasFeathers();
        public virtual void isPecking()
        {
            Console.WriteLine(" is pecking");
        }





    }
}
