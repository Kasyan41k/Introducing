using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Method_overloading
{
    public class SomeOtherClass : MonoBehaviour
    {
        void Start()
        {
            SomeClass myClass = new SomeClass();

            myClass.Add(1, 2);
            myClass.Add("Hello ", "World");
        }
    }
}

