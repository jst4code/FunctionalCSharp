using System.Threading.Tasks;

namespace Jst4Code
{
    public delegate Result<T> Try<T>();
    public delegate Task<Result<A>> TryAsync<A>();
}
