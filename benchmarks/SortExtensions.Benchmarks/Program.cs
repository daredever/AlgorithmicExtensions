using BenchmarkDotNet.Running;

namespace SortExtensions.Benchmarks
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<CompareSorters>();
        }
    }
}