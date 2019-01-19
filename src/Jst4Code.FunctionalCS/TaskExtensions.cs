using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace Jst4Code.FunctionalCS
{
    public static class TaskExtensions
    {
        /// <summary>
        /// Convert a value to a Task that completes immediately
        /// </summary>
        [Pure]
        public static Task<T> AsTask<T>(this T self) =>
            Task.FromResult(self);
    }
}
