using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Jabuticaba.Benchmark
{
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class CpfBenchmarkDiagnoser
    {
        [Benchmark]
        public void ObterCpf()
        {
            Cpf cpf = "529.982.247-25";
        }


        [Benchmark]
        public void CpfPrimeiroDigitoInvalido()
        {

            Cpf cpf = "149.764.610-00";
        }

        [Benchmark]
        public void CpfSegundoDigitoInvalido()
        {

            Cpf cpf = "529.982.247-20";
        }

        [Benchmark]
        public void CpfApenasDigitosRepetidos()
        {
            Cpf cpf = "111.111.111-11";
        }

        [Benchmark]
        public void CpfTamanhoMaiorDoQue11Digitos()
        {
            Cpf cpf = "149.764.610-331";
        }

        [Benchmark]
        public void CpfTamanhoMenorDoQue11Digitos()
        {
            Cpf cpf = "149.764.610";
        }

        [Benchmark]
        public void CpfContendoValorNaoNumerico()
        {
            Cpf cpf = "149.764.610a";
        }
    }
}
