using System.Collections.Generic;
using System.Globalization;
using BenchmarkDotNet.Analysers;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Filters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Validators;

namespace StringPrefixSearchBenchmark
{
    internal class BenchmarkConfig
        : IConfig
    {
        private readonly IConfig _defaultConfig = DefaultConfig.Instance;

        public IEnumerable<IColumnProvider> GetColumnProviders()
        {
            return _defaultConfig.GetColumnProviders();
        }

        public IEnumerable<IExporter> GetExporters()
        {
            yield return AsciiDocExporter.Default;
        }

        public IEnumerable<ILogger> GetLoggers()
        {
            yield return ConsoleLogger.Default;
        }

        public IEnumerable<IDiagnoser> GetDiagnosers()
        {
            return _defaultConfig.GetDiagnosers();
        }

        public IEnumerable<IAnalyser> GetAnalysers()
        {
            return _defaultConfig.GetAnalysers();
        }

        public IEnumerable<Job> GetJobs()
        {
            return _defaultConfig.GetJobs();
        }

        public IEnumerable<IValidator> GetValidators()
        {
            return _defaultConfig.GetValidators();
        }

        public IEnumerable<HardwareCounter> GetHardwareCounters()
        {
            return _defaultConfig.GetHardwareCounters();
        }

        public IEnumerable<IFilter> GetFilters()
        {
            return _defaultConfig.GetFilters();
        }

        public IEnumerable<BenchmarkLogicalGroupRule> GetLogicalGroupRules()
        {
            return _defaultConfig.GetLogicalGroupRules();
        }

        public IOrderer? Orderer => _defaultConfig.Orderer;

        public SummaryStyle SummaryStyle => _defaultConfig.SummaryStyle;

        public ConfigUnionRule UnionRule => _defaultConfig.UnionRule;

        public string ArtifactsPath => _defaultConfig.ArtifactsPath;

        public CultureInfo? CultureInfo => _defaultConfig.CultureInfo;

        public ConfigOptions Options => _defaultConfig.Options;
    }
}