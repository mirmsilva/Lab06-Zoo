using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals
{
    //first level (granddaddy) not an actual object
    public abstract class ZooAnimals
    {
        //abstract must be implemented & overridden
        public abstract string Color { get; set; } 

        public abstract string[] Diet { get; set; }

        //Virtual some animals have it others don't
        public virtual int Legs { get; set; }

        //virtual methods sub-classes MAY implement, are given a default but, can be overridden

        //Abstract method all Animals sleep so they all must use this method
        public abstract void TheySleep();


    }


}
