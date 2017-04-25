﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMakesPerfect.HashTable
{
    public class Person
    {
        public Person (string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Key {
            get
            {
                return String.Concat(this.FirstName, this.LastName);
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
