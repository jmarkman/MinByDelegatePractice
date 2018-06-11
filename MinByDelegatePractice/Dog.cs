using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinByDelegatePractice
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        public Dog(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public override string ToString()
        {
            return $"Dog Name:\t{Name}\nDog Breed:\t{Breed}\nDog Age:\t{Age}";
        }
    }
}
