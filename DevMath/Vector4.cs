using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public float Magnitude
        {
            get { throw new NotImplementedException(); }
            //sqrt(x * x + y * y + z * z + w * w)
        }

        public Vector4 Normalized
        {
            get { throw new NotImplementedException(); }
            //x /= Magnitude
            //y /= Magnitude
            //z /= Magnitude
            //w /= Magnitude
        }

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static implicit operator Vector4(Vector3 v)
        {
            throw new NotImplementedException();
            //x = v.x
            //y = v.y
            //z = v.z
            //w = 0
        }

        public static float Dot(Vector4 lhs, Vector4 rhs)
        {
            throw new NotImplementedException();
            //lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * rhs.w
        }

        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            throw new NotImplementedException();
            //a + (b - a) * t
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            throw new NotImplementedException();
            //x = lhs.x + rhs.x
            //y = lhs.y + rhs.y
            //z = lhs.z + rhs.z
            //w = lhs.w + rhs.w
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            throw new NotImplementedException();
            //x = lhs.x - rhs.x
            //y = lhs.y - rhs.y
            //z = lhs.z - rhs.z
            //w = lhs.w - rhs.w
        }

        public static Vector4 operator -(Vector4 v)
        {
            throw new NotImplementedException();
            //x -= x
            //y -= y
            //z -= z
            //w -= w
        }

        public static Vector4 operator *(Vector4 lhs, float scalar)
        {
            throw new NotImplementedException();
            //x = lhs.x * scalar
            //y = lhs.y * scalar
            //z = lhs.z * scalar
            //w = lhs.w * scalar
        }

        public static Vector4 operator /(Vector4 lhs, float scalar)
        {
            throw new NotImplementedException();
            //x = lhs.x / scalar
            //y = lhs.y / scalar
            //z = lhs.z / scalar
            //w = lhs.w / scalar
        }
    }
}
