﻿using System;

namespace _01_concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Object
            People obj = new People();
            obj.name = "Douglas";
            obj.age = 26;
            obj.message();
        }
    }
}
