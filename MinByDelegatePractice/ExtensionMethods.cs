using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinByDelegatePractice
{
    public static class ExtensionMethods
    {
        public static T MinBy<T>(this IEnumerable<T> list, Func<T, int> lambda)
        {
            if (list is null)
                throw new Exception("The list is null!");
            else if (list.Count() == 0)
                throw new Exception("The collection is empty, the operation cannot be completed.");

            var min = lambda(list.First());
            T result = default(T);
            foreach (var item in list)
            {
                if (lambda(item) < min)
                {
                    result = item;
                    min = lambda(item);
                }
            }

            return result;
        }

        public static Dog[] GetDogs()
        {
            Dog[] dogs =
            {
                new Dog("Fido", "Boxer", 4),
                new Dog("Sam", "Bull Terrier", 2),
                new Dog("Spot", "English Pointer", 5),
                new Dog("Lassie", "Collie", 6),
                new Dog("Earl", "Golden Retriever", 7),
                new Dog("Bo", "Beagle", 2),
                new Dog("Sparky", "Pug", 3),
                new Dog("Pechi", "Pembroke Welsh Corgi", 4),
                new Dog("Frank", "Pomeranian", 5),
                new Dog("Jumper", "Old English Sheepdog", 10),
                new Dog("Fluffer", "Pembroke Welsh Corgi", 2),
                new Dog("Rocky", "English Bulldog", 7),
                new Dog("Bella", "English Pointer", 9),
                new Dog("Coco", "English Pointer", 4),
                new Dog("Tucker", "English Bulldog", 2),
                new Dog("Lucky", "Dachshund", 1),
                new Dog("Lily", "Dalmatian", 5),
                new Dog("Ruby", "Cocker Spaniel", 4),
                new Dog("Teddy", "Dachshund", 3),
                new Dog("Oliver", "German Shepherd", 11)
            };

            return dogs;
        }
    }
}
