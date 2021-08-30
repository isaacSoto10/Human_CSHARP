using System;
using System.Collections.Generic;

namespace FirstCSharp
{
    public class Human
    {
    // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
     
        public int getter
        {
            get{
                return health;
            } 
            set{
                health = value;
            }
        }
        public Person(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            getter = 100;
        }
        public PersonDetails(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            getter = health;
        }
     
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
     
    // Add a constructor to assign custom values to all fields
     
    // Build Attack method
        public int Attack(Human target)
        {
            target.getter = (5*(target.Strength));
            return getter;
        }
    }


}


//Sum and Print 1-5
//Sum numbers from 1 to 5, printing out the current number and sum so far at each step of the way
//The expected output will be: Num: 1, Sum: 1, Num: 2, Sum: 3, Num: 3, Sum: 6, Num: 4, Sum: 10, Num: 5, Sum: 15
