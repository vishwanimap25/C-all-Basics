﻿using System;

namespace practice_project
{
    public class person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("my name is " + FirstName + " " + LastName);
        }
    }
}
