using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Jabuticaba.Telefones;

namespace Jabuticaba.Benchmark
{
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class TelefoneBenchmarkDiagnoser
    {
        [Benchmark]
        public void ObterTelefoneCompleto()
        {
            Telefone telefone = "+55 (31) 9 7500-0001";
        }

        [Benchmark]
        public void ObterTelefoneSemDDI()
        {
            Telefone telefone = "(31) 9 7500-0001";
        }

        [Benchmark]
        public void ObterTelefoneSemNonoDigito()
        {
            Telefone telefone = "+55 (31) 7500-0001";
        }

        [Benchmark]
        public void ObterTelefoneDDDInvalido()
        {
            Telefone telefone = "55 (10) 7500-0001";
        }

        [Benchmark]
        public void ObterTelefoneServicoPublicoInvalido()
        {
            Telefone telefone = "666";
        }

        [Benchmark]
        public void ObterTelefoneServicoPublicoValido()
        {
            Telefone telefone = "190";
        }

        [Benchmark]
        public void NaoEhUmTelefoneValido()
        {
            Telefone telefone = "telefone";
        }
    }
}
