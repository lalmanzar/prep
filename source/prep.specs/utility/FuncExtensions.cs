using System;
using prep.collections;
using prep.utility;

namespace prep.specs.utility
{
    public static class FuncExtensions
    {
        public static IMatchAn<Movie> equal_to(this Func<Movie, ProductionStudio> func, ProductionStudio studio)
        {
            return new LambdaMatcher<Movie>(x => func.Invoke(x).Equals(studio));
        }
    }
}