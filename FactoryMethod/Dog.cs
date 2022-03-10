﻿using System;

namespace DesignPatternsInC_Sharp.FactoryMethod
{
    public class Dog : IAnimal
    {

        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-Wow...\n");
        }
        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...\n\n");
        }
    }
}
