using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class FruitSalad
    {
        void Start()
        {
            
            Fruit myFruit = new Apple();

            myFruit.SayHello();
            myFruit.Chop();

            Apple myApple = (Apple)myFruit;

            myApple.SayHello();
            myApple.Chop();
        }
    }
}
