using System;

namespace Jst4Code.FunctionalCS.Curry
{
    public static class FuncExtension
    {
        public static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>(
            this Func<T1, T2, TResult> function) =>
                value1 => value2 => function(value1, value2);
    }
}
