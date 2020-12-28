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

            List<IBenchmarkLocal> benchmarks = new() { new CnpjBenchmark(), new CpfBenchmark() };
            benchmarks.ForEach(
                b => b.Executar(numeroTentativas: 1_000_000)
            );
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
            cnpj.Validar();
        }

        [Benchmark]
        public void CnpjSemMascara()
        {
            Cnpj cnpj = "78322994000150";
            cnpj.Validar();
        }

        [Benchmark]
        public void CnpjValorNaoNumerico()
        {
            Cnpj cnpj = "2.055.097/0001-6a";
            cnpj.Validar();
        }

        [Benchmark]
        public void CnpjMenorDoQue14Digitos()
        {
            Cnpj cnpj = "02.055.097/0001-6";
            cnpj.Validar();
        }

        [Benchmark]
        public void CnpjMaiorDoQue14Digitos()
        {
            Cnpj cnpj = "02.055.097/0001-656";
            cnpj.Validar();
        }

        [Benchmark]
        public void CnpjPrimeiroDigitoInvalido()
        {
            Cnpj cnpj = "02.055.097/0001-05";
            cnpj.Validar();
        }

        [Benchmark]
        public void CnpjSegundoDigitoInvalido()
        {
            Cnpj cnpj = "02.055.097/0001-60";
            cnpj.Validar();
        }

    }
}
