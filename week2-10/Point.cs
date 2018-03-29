using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_10
{
    class Point
    {
    //Even though you don't see it, every class has a "Default" constructor.
    //Constructors "set up" your class for use.. 
    //public Point()
    //{


    //}

    //If you add parameters to the constructor 
    //and don't explicitly also define a paramterless constructor,
    //DotNet will not "generate" the parameterless constructor for you.
    //This is an indication to other developers that they MUST supply those parameters
    //in order to use your class.
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double x { get; set; }
        public double y { get; set; }
      

    }


}

