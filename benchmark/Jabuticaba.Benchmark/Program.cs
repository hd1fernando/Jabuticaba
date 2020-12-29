using System.Collections.Generic;
using BenchmarkDotNet.Running;

namespace Jabuticaba.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
#if RELEASE
            // var summaryCpf = BenchmarkRunner.Run<CpfBenchmarkDiagnoser>();
            // var summaryCnpj = BenchmarkRunner.Run<CnpjBenchmarkDiagnoser>();
            var summaryCnpj = BenchmarkRunner.Run<CepBenchmarkDiagnoser>();
#endif

            List<IBenchmarkLocal> benchmarks = new()
            {
                new CnpjBenchmark(),
                new CpfBenchmark(),
                new CepBenchmark(),
                new TelefoneBenchmark()
            };

            benchmarks.ForEach(
                b => b.Executar(numeroTentativas: 1_000_000)
            );
        }
    }
}
