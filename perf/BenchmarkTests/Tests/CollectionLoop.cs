using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchmarkTests.Tests
{
    [MemoryDiagnoser]
    [DisassemblyDiagnoser]
    public class CollectionLoop
    {
        private string[] _arrayRef = Array.Empty<string>();
        private List<string> _listRef = new();

        [Params(100, 1_000, 10_000)]
        public int Length { get; set; } = 0;

        [GlobalSetup]
        public void Setup()
        {
            _arrayRef = string.Concat(Strings.LoremIpsum100Lines, " ", Strings.LoremIpsum100Lines)
                .Split(new[] { '\r', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Take(Length)
                .ToArray();

            _listRef = _arrayRef.ToList();
        }

        [Benchmark(Baseline = true)]
        public int ForArray()
        {
            int sum = 0;
            for (var i = 0; i < _arrayRef.Length; i++)
            {
                sum += _arrayRef[i].Length;
            }

            return sum;
        }

        [Benchmark]
        public int ForList()
        {
            int sum = 0;
            for (var i = 0; i < _listRef.Count; i++)
            {
                sum += _listRef[i].Length;
            }

            return sum;
        }

        [Benchmark]
        public int ForEachArray()
        {
            int sum = 0;
            foreach (var element in _arrayRef)
            {
                sum += element.Length;
            }

            return sum;
        }

        [Benchmark]
        public int ForEachList()
        {
            int sum = 0;
            foreach (var element in _listRef)
            {
                sum += element.Length;
            }

            return sum;
        }

        [Benchmark]
        public int LinqSumArray()
        {
            return _arrayRef.Sum(s => s.Length);
        }

        [Benchmark]
        public int LinqSumList()
        {
            return _listRef.Sum(s => s.Length);
        }
    }
}