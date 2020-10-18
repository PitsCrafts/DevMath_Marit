using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Circle
    {
        public Vector2 Position
        {
            get; set;
        }

        public float Radius
        {
            get; set;
        }

        public bool CollidesWith(Circle circle)
        {
            throw new NotImplementedException();
            //if (sqrt((circle1.x - circle2.x)^2 + (circle1.y - circle2.y)^2) - radius1 - radius2 > 0) false
            //else true
        }
    }
}
