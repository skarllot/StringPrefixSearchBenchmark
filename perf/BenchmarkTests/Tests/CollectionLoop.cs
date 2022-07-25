using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchmarkTests.Tests
{
    [AsciiDocExporter]
    [MemoryDiagnoser]
    [ShortRunJob]
    public class CollectionLoop
    {
        private int[] ArrayRef;
        private List<int> ListRef;

        [Params(100, 1_000, 10_000)]
        public int Length { get; set; } = 0;

        [GlobalSetup]
        public void Setup()
        {
            ArrayRef = Enumerable.Range(1, Length).ToArray();
            ListRef = Enumerable.Range(1, Length).ToList();
        }

        [Benchmark(Baseline = true)]
        public int ForArray()
        {
            int sum = 0;
            for (var i = 0; i < ArrayRef.Length; i++)
            {
                sum += ArrayRef[i];
            }

            return sum;
        }

        [Benchmark]
        public int ForList()
        {
            int sum = 0;
            for (var i = 0; i < ListRef.Count; i++)
            {
                sum += ListRef[i];
            }

            return sum;
        }

        [Benchmark]
        public int ForEachArray()
        {
            int sum = 0;
            foreach (var element in ArrayRef)
            {
                sum += element;
            }

            return sum;
        }

        [Benchmark]
        public int ForEachList()
        {
            int sum = 0;
            foreach (var element in ListRef)
            {
                sum += element;
            }

            return sum;
        }

        [Benchmark]
        public int LinqSumArray()
        {
            return ArrayRef.Sum();
        }

        [Benchmark]
        public int LinqSumList()
        {
            return ListRef.Sum();
        }
    }
}