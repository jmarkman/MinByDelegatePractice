using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinByDelegatePractice
{
    public static class ExtensionMethods
    {
        public static string MinBy<T>(this T[] list, Func<T, int> lambda)
        {
            if (list.Length == 0)
                throw new Exception("The collection is empty, the operation cannot be completed.");

            var min = lambda(list[0]);
            T result = default(T);
            foreach (var item in list)
            {
                if (lambda(item) < min)
                {
                    result = item;
                    min = lambda(item);
                }
            }

            return result.ToString();
        }
    }
}
