using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace BenchmarkTests.Tests
{
    [AsciiDocExporter]
    [MemoryDiagnoser]
    [ShortRunJob]
    public class StringPrefixSearch
    {
        private const string StringRef =
            "11|12|13|14|15|16|17|18|19|" +
            "21|22|24|27|28|" +
            "31|32|33|34|35|37|38|" +
            "41|42|43|44|45|46|47|48|49|" +
            "51|53|54|55|" +
            "61|62|63|64|65|66|67|68|69|" +
            "71|73|74|75|77|79|" +
            "81|82|83|84|85|86|87|88|89|" +
            "91|92|93|94|95|96|97|98|99|";

        private static readonly HashSet<string> HashSetRef = new()
        {
            "11", "12", "13", "14", "15", "16", "17", "18", "19",
            "21", "22", "24", "27", "28",
            "31", "32", "33", "34", "35", "37", "38",
            "41", "42", "43", "44", "45", "46", "47", "48", "49",
            "51", "53", "54", "55",
            "61", "62", "63", "64", "65", "66", "67", "68", "69",
            "71", "73", "74", "75", "77", "79",
            "81", "82", "83", "84", "85", "86", "87", "88", "89",
            "91", "92", "93", "94", "95", "96", "97", "98", "99"
        };

        private static readonly string[] ArrayRef =
        {
            "11", "12", "13", "14", "15", "16", "17", "18", "19",
            "21", "22", "24", "27", "28",
            "31", "32", "33", "34", "35", "37", "38",
            "41", "42", "43", "44", "45", "46", "47", "48", "49",
            "51", "53", "54", "55",
            "61", "62", "63", "64", "65", "66", "67", "68", "69",
            "71", "73", "74", "75", "77", "79",
            "81", "82", "83", "84", "85", "86", "87", "88", "89",
            "91", "92", "93", "94", "95", "96", "97", "98", "99"
        };

        [Params("11988776655", "66988776655", "99988776655", "57988776655")]
        public string Input { get; set; } = string.Empty;

        [Benchmark]
        public int StringSpanIndex()
        {
            return StringRef.AsSpan().IndexOf(Input.AsSpan(0, 2), StringComparison.Ordinal);
        }

        [Benchmark]
        public int StringSubstringIndex()
        {
            return StringRef.IndexOf(Input.Substring(0, 2), StringComparison.Ordinal);
        }

        [Benchmark]
        public bool StringHashSetIndex()
        {
            return HashSetRef.Contains(Input.Substring(0, 2));
        }

        [Benchmark]
        public int StringArrayIndex()
        {
            return Array.IndexOf(ArrayRef, Input.Substring(0, 2), 0);
        }

        [Benchmark]
        public int StringArrayBinarySearch()
        {
            return Array.BinarySearch(ArrayRef, Input.Substring(0, 2));
        }
    }
}