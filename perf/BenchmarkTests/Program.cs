﻿using System.IO;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace BenchmarkTests
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var config = new CustomConfig()
                .WithOption(ConfigOptions.DisableLogFile, true)
                .WithArtifactsPath(GetArtifactsPath());

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);
        }

        private static string GetArtifactsPath()
        {
            return Path.Combine(RuntimeContext.SolutionDirectory, "docs", "benchmarks");
        }
    }
}