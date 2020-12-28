using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Jabuticaba.Benchmark
{
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class CepBenchmarkDiagnoser
    {
        [Benchmark]
        public void OberCep()
        {
            Cep cep = "70686-820";
        }

        [Benchmark]
        public void OberCepSemPontuacao()
        {
            Cep cep = "70686820";
        }

        [Benchmark]
        public void CepMenor()
        {
            Cep cep = "70686-82";
        }

        [Benchmark]
        public void CepMaior()
        {
            Cep cep = "70686-8200";
        }

        [Benchmark]
        public void CepSemIfenNaSextaPosicao()
        {
            Cep cep = "70686 820";
        }

        [Benchmark]
        public void CepSemNumeros()
        {
            Cep cep = "7068a-820";
        }
    }
}
