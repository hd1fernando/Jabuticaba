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
            var summaryCpf = BenchmarkRunner.Run<CpfBenchmarkDiagnoser>();
            // var summaryCnpj = BenchmarkRunner.Run<CnpjBenchmarkDiagnoser>();
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
    public class CpfBenchmarkDiagnoser
    {
        [Benchmark]
        public void ObterCpf()
        {
            Cpf cpf = "529.982.247-25";
            cpf.Validar();
        }


        [Benchmark]
        public void CpfPrimeiroDigitoInvalido()
        {

            Cpf cpf = "149.764.610-00";
            cpf.Validar(ModoCascateamento.PararNoPrimeiroErro);
        }

        [Benchmark]
        public void CpfSegundoDigitoInvalido()
        {

            Cpf cpf = "529.982.247-20";
            cpf.Validar();
        }

        [Benchmark]
        public void CpfApenasDigitosRepetidos()
        {
            Cpf cpf = "111.111.111-11";
            cpf.Validar();
        }

        [Benchmark]
        public void CpfTamanhoMaiorDoQue11Digitos()
        {
            Cpf cpf = "149.764.610-331";
            cpf.Validar(ModoCascateamento.PararNoPrimeiroErro);
        }

        [Benchmark]
        public void CpfTamanhoMenorDoQue11Digitos()
        {
            Cpf cpf = "149.764.610";
            cpf.Validar();
        }

        [Benchmark]
        public void CpfContendoValorNaoNumerico()
        {
            Cpf cpf = "149.764.610a";
            cpf.Validar();
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
