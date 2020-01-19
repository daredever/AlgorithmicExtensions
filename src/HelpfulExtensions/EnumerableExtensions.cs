using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpfulExtensions
{
    public static class EnumerableExtensions
    {
        public static Task ForEachAsync<T>(this IEnumerable<T> list, Func<T, Task> function)
        {
            return Task.WhenAll(list.Select(function));
        }

        public static async Task<IEnumerable<TOut>> ForEachAsync<TIn, TOut>(this IEnumerable<TIn> list,
            Func<TIn, Task<TOut>> function)
        {
            var result = await Task.WhenAll(list.Select(function))
                .ConfigureAwait(false);

            return result.AsEnumerable();
        }

        public static Task ForEachAsync<T>(this IEnumerable<T> source, int partitionCount, Func<T, Task> body)
        {
            var partitions = Partitioner.Create(source).GetPartitions(partitionCount);
            var tasks = partitions.Select(partition =>
                Task.Run(async () =>
                {
                    using (partition)
                    {
                        while (partition.MoveNext())
                        {
                            await body(partition.Current).ConfigureAwait(false);
                        }
                    }
                }));

            return Task.WhenAll(tasks);
        }

        public static async Task<IEnumerable<TOut>> ForEachAsync<TIn, TOut>(this IEnumerable<TIn> source,
            int partitionCount, Func<TIn, Task<TOut>> body)
        {
            var partitions = Partitioner.Create(source).GetPartitions(partitionCount);
            var tasks = partitions.Select(partition =>
                Task.Run<List<TOut>>(async () =>
                {
                    var results = new List<TOut>();
                    using (partition)
                    {
                        while (partition.MoveNext())
                        {
                            var result = await body(partition.Current).ConfigureAwait(false);
                            results.Add(result);
                        }
                    }

                    return results;
                }));

            var allTasksResults = await Task.WhenAll(tasks).ConfigureAwait(false);
            var outputResult = new List<TOut>();
            foreach (var taskResults in allTasksResults)
            {
                outputResult.AddRange(taskResults);
            }

            return outputResult.AsEnumerable();
        }
    }
}