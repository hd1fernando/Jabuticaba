using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;

namespace Jabuticaba.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
#if RELEASE
            // var summaryCpf = BenchmarkRunner.Run<CpfBenchmarkDiagnoser>();
            var summaryCnpj = BenchmarkRunner.Run<CnpjBenchmarkDiagnoser>();
#endif

            List<IBenchmarkLocal> benchmarks = new()
            {
                new CnpjBenchmark(),
                new CpfBenchmark(),
                new RgSSPSpBenchmark()
            };
            
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

    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class CnpjBenchmarkDiagnoser
    {
        [Benchmark]
        public void ObterCnpj()
        {
            Cnpj cnpj = "78.322.994/0001-50";
        }

        [Benchmark]
        public void ObterCnpjSemMascara()
        {
            Cnpj Cnpj = "78322994000150";
        }
    }
}
