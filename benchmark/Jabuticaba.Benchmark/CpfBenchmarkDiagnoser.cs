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
            cpf.Validar();
        }


        [Benchmark]
        public void CpfPrimeiroDigitoInvalido()
        {

            Cpf cpf = "149.764.610-00";
            cpf.Validar();
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
            cpf.Validar();
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
}
