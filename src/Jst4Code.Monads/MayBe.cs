namespace Jst4Code
{
    public interface IMayBe<T> { }

    public abstract class MayBe<T> : IMayBe<T>
    {
        public bool HasValue { get => this is Some<T>; }
        public bool IsNull { get => this is None<T>; }

        public static implicit operator MayBe<T>(T value)
            => value == null
                ? new None<T>()
                : (MayBe<T>)new Some<T>(value);

        public static implicit operator MayBe<T>(None none) =>
            new None<T>();
    }
}
