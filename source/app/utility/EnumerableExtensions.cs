using System;
using System.Collections.Generic;
using System.Linq;

namespace app.utility
{
    public static class EnumerableExtensions
    {
        public static void for_each<Type>(this IEnumerable<Type> items,Action<Type> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }
    }
}