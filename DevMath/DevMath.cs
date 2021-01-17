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
            return a + (b - a) * t;
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time)
        {
            return startVelocity * time + 0.5f * acceleration * time * time;
        }

        public static float Clamp(float value, float min, float max)
        {
            if (value < min)
            {
                return min;
            }
            else if (max < value)
            {
                return max;
            }
            else
            {
                return value;
            }
        }

        public static float RadToDeg(float angle)
        {
            return angle * 180f / 3.14f;
        }

        public static float DegToRad(float angle)
        {
            return angle * 3.14f / 180f;
        }
    }
}
