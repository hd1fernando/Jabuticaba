using System;
using System.Diagnostics;

namespace Jabuticaba.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            CpfBenchmark.ValidarCpf(numeroTentativas: 1_000_000);
        }
    }

    public static class CpfBenchmark
    {
        /***
        Último resultado alcançado:
        Quantidade de cpfs 1000000
        Tempo execução: 527ms
        GC geração 2 - 0
        GC geração 1 - 0
        GC geração 0 - 45
        */
        public static void ValidarCpf(ulong numeroTentativas)
        {
            var stopWatch = new Stopwatch();
            var gcAntesGeracao2 = GC.CollectionCount(2);
            var gcAntesGeracao1 = GC.CollectionCount(1);
            var gcAntesGeracao0 = GC.CollectionCount(0);

            stopWatch.Start();
            for (ulong i = 0; i < numeroTentativas; i++)
            {
                Cpf cpf = "529.982.247-25";
            }
            stopWatch.Stop();

            Console.WriteLine($"{nameof(Cpf)}:");
            Console.WriteLine($"Quantidade de cpfs {numeroTentativas}");
            Console.WriteLine($"Tempo execução: {stopWatch.ElapsedMilliseconds}ms");
            Console.WriteLine($"GC geração 2 - {GC.CollectionCount(2) - gcAntesGeracao2}");
            Console.WriteLine($"GC geração 1 - {GC.CollectionCount(1) - gcAntesGeracao1}");
            Console.WriteLine($"GC geração 0 - {GC.CollectionCount(0) - gcAntesGeracao0}");
            Console.WriteLine();
        }
    }
}
