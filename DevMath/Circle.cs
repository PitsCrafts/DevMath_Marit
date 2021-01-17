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
            if (Math.Sqrt(Math.Pow((Position.x - circle.Position.x), 2) + Math.Pow((Position.y - circle.Position.y), 2)) - Radius - circle.Radius > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
