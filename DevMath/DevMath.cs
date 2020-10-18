using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class DevMath
    {
        public static float Lerp(float a, float b, float t)
        {
            throw new NotImplementedException();
            //a + (b - a) * t
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time)
        {
            throw new NotImplementedException();
            //startVelocity * time + 0.5 * acceleration * time * time
        }

        public static float Clamp(float value, float min, float max)
        {
            throw new NotImplementedException();
            //if (min < value < max) true
        }

        public static float RadToDeg(float angle)
        {
            throw new NotImplementedException();
            //deg = angle * 180 / 3.14
        }

        public static float DegToRad(float angle)
        {
            throw new NotImplementedException();
            //rad = angle * 3.14 / 180
        }
    }
}
