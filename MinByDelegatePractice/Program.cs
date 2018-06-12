using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinByDelegatePractice
{
    class Program
    {
        /*
         * Write MinBy, a function that does:
         * var shortest = texts.MinBy(x => x.Length);
         * 
         * MinBy is retrieving the shortest length string in a list by accepting a lambda as a param
         * 
         * Test Case:
         * Assert.AreEqual("h", new[] {"lol", "asdf", "h", "hello world"}.MinBy(x => x.Length));
         * 
         * Can ignore dupes and return the first, or return an IEnumerable<T>
         * Do whatever on an empty sequence, prefer to throw an exception
         */
        static void Main(string[] args)
        {
            var texts = new[] { "lol", "asdf", "h", "hello world" };
            var dogs = ExtensionMethods.GetDogs();

            var shortTest = texts.MinBy(x => x.Length);
            var youngestDog = dogs.MinBy(y => y.Age);

            var nums = new[] { 90, 3, 5, 7, 44 };
            var smallestNum = nums.MinBy(x => x);

            Console.WriteLine(shortTest);
            Console.WriteLine(youngestDog.ToString());
            Console.WriteLine(smallestNum);
        }
    }
}
