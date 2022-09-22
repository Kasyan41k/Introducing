using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Member_hiding
{
    public class Humanoid : MonoBehaviour
    {
        public void Yell()
        {
            Debug.Log("Humanoid version of the Yell() method");
        }
    }
}

