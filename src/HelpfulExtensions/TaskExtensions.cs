using System.Threading;
using System.Threading.Tasks;

namespace HelpfulExtensions
{
    public static class TaskExtensions
    {
        /// <summary>
        /// Run task with cancellation.
        /// </summary>
        /// <param name="task">Task</param>
        /// <param name="token">Cancellation token</param>
        /// <typeparam name="T">Output type</typeparam>
        /// <returns>Task result</returns>
        public static async Task<T> WithCancellation<T>(this Task<T> task, CancellationToken token)
        {
            var taskForCancel = new TaskCompletionSource<Empty>();

            using (token.Register(tcs => ((TaskCompletionSource<Empty>) tcs).TrySetResult(new Empty()), taskForCancel))
            {
                var completedTask = await Task.WhenAny(task, taskForCancel.Task).ConfigureAwait(false);
                if (completedTask == taskForCancel.Task)
                {
                    token.ThrowIfCancellationRequested();
                }
            }

            return await task.ConfigureAwait(false);
        }
    }
}