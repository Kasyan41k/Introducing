using Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interfaces
{
    public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
    {
        public void Kill()
        {
            Debug.Log("You are dead");
        }

        public void Damage(float damageTaken)
        {
            Debug.Log("Damage taken");
        }
    }
}

