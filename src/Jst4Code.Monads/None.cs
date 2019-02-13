namespace Jst4Code
{
    internal class None<T> : Result<T>{ }

    public class None
    {
        public static None Value { get; } = new None();
        private None() { }
    }
}
