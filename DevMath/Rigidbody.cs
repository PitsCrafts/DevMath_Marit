using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Rigidbody
    {
        public Vector2 Velocity
        {
            get; private set;
        }

        public float Acceleration
        {
            get; private set;
        }

        public float mass = 1.0f;

        public float frictionCoefficient = 1.0f;
        public float normalForce = 1.0f;

        public void UpdateVelocityWithForce(Vector2 forceDirection, float forceNewton, float deltaTime)
        {
            float force = forceNewton - (frictionCoefficient * normalForce);
            Velocity = (forceDirection * (force / mass)) * deltaTime;
        }
    }
}
