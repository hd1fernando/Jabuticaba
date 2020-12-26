using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
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

            List<IBenchmarkLocal> benchmarks = new() { new CnpjBenchmark(), new CpfBenchmark() };
            benchmarks.ForEach(
                b => b.Executar(numeroTentativas: 1_000_000)
            );
        }
    }

    [MemoryDiagnoser]
    public class CpfBenchmarkDiagnoser
    {
        [Benchmark(Baseline = true)]
        public void ObterCpf()
        {
            Cpf cpf = "529.982.247-25";
        }
    }

    [MemoryDiagnoser]
    public class CnpjBenchmarkDiagnoser
    {
        [Benchmark(Baseline = true)]
        public void ObterCnpj()
        {
            Cnpj cnpj = "78.322.994/0001-50";
        }
    }
}
