using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector2
    {
        public float x;
        public float y;

        public float Magnitude
        {
            get { throw new NotImplementedException(); }
            //sqrt(x * x + y * y)
        }

        public Vector2 Normalized
        {
            get { throw new NotImplementedException(); }
            //x /= Magnitude(vector)
            //y /= Magnitude(vector)
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static float Dot(Vector2 lhs, Vector2 rhs)
        {
            throw new NotImplementedException();
            //lhs.x * rhs.x + lhs.y * rhs.y
        }

        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            throw new NotImplementedException();
            //a + (b - a) * t
        }

        public static float Angle(Vector2 lhs, Vector2 rhs)
        {
            throw new NotImplementedException();
            //acos(Dot(lhs, rhs) / (magnitude(lhs) * magnitude(rhs)))
        }

        public static Vector2 DirectionFromAngle(float angle)
        {
            throw new NotImplementedException();
            //x = cos(angle)
            //y = sin(angle)
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            throw new NotImplementedException();
            //x = lhs.x + rhs.x
            //y = lhs.y + rhs.y
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            throw new NotImplementedException();
            //x = lhs.x - rhs.x
            //y = lhs.y - rhs.y
        }

        public static Vector2 operator -(Vector2 v)
        {
            throw new NotImplementedException();
            //x -= x
            //y -= y
        }

        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            throw new NotImplementedException();
            //x = lhs.x * scalar
            //y = lhs.y * scalar
        }

        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            throw new NotImplementedException();
            //x = lhs.x / scalar
            //y = lhs.y / scalar
        }
    }
}
