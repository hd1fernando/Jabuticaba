using System.Collections.Generic;
using BenchmarkDotNet.Running;

namespace Jabuticaba.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
#if RELEASE
             var summaryCpf = BenchmarkRunner.Run<CpfBenchmarkDiagnoser>();
             var summaryCnpj = BenchmarkRunner.Run<CnpjBenchmarkDiagnoser>();
#endif

            List<IBenchmarkLocal> benchmarks = new()
            {
                new CnpjBenchmark(),
                new CpfBenchmark(),
            };

            benchmarks.ForEach(
                b => b.Executar(numeroTentativas: 1_000_000)
            );
        }
    }
}
