using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Jabuticaba.Benchmark
{

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
        public void CnpjSemMascara()
        {
            Cnpj cnpj = "78322994000150";
        }

        [Benchmark]
        public void CnpjValorNaoNumerico()
        {
            Cnpj cnpj = "2.055.097/0001-6a";
        }

        [Benchmark]
        public void CnpjMenorDoQue14Digitos()
        {
            Cnpj cnpj = "02.055.097/0001-6";
        }

        [Benchmark]
        public void CnpjMaiorDoQue14Digitos()
        {
            Cnpj cnpj = "02.055.097/0001-656";
        }

        [Benchmark]
        public void CnpjPrimeiroDigitoInvalido()
        {
            Cnpj cnpj = "02.055.097/0001-05";
        }

        [Benchmark]
        public void CnpjSegundoDigitoInvalido()
        {
            Cnpj cnpj = "02.055.097/0001-60";
        }

    }
}
