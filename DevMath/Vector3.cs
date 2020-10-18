using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public float Magnitude
        {
            get { throw new NotImplementedException(); }
            //sqrt(x * x + y * y + z * z)
        }

        public Vector3 Normalized
        {
            get { throw new NotImplementedException(); }
            //x /= Magnitude
            //y /= Magnitude
            //z /= Magnitude
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static implicit operator Vector3(Vector2 v)
        {
            throw new NotImplementedException();
            //x = v.x
            //y = v.y
            //z = 0
        }

        public static float Dot(Vector3 lhs, Vector3 rhs)
        {
            throw new NotImplementedException();
            //lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z

        }

        public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
        {
            throw new NotImplementedException();
            //x = lhs.y * rhs.z - lhs.z * rhs.y
            //y = lhs.z * rhs.x - lhs.x * rhs.z
            //z = lhs.x * rhs.y - lhs.y * rhs.x
        }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            throw new NotImplementedException();
            //a + (b - a) * t
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            throw new NotImplementedException();
            //x = lhs.x + rhs.x
            //y = lhs.y + rhs.y
            //z = lhs.z + rhs.z
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            throw new NotImplementedException();
            //x = lhs.x - rhs.x
            //y = lhs.y - rhs.y
            //z = lhs.z - rhs.z
        }

        public static Vector3 operator -(Vector3 v)
        {
            throw new NotImplementedException();
            //x -= x
            //y -= y
            //z -= z
        }

        public static Vector3 operator *(Vector3 lhs, float scalar)
        {
            throw new NotImplementedException();
            //x = lhs.x * scalar
            //y = lhs.y * scalar
            //z = lhs.z * scalar
        }

        public static Vector3 operator /(Vector3 lhs, float scalar)
        {
            throw new NotImplementedException();
            //x = lhs.x / scalar
            //y = lhs.y / scalar
            //z = lhs.z / scalar
        }
    }
}
