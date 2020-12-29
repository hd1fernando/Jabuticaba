using System;
using System.Diagnostics;
using Jabuticaba.Telefones;

namespace Jabuticaba.Benchmark
{
    public class TelefoneBenchmark : IBenchmarkLocal
    {
        public void Executar(ulong numeroTentativas)
        {
            var stopWatch = new Stopwatch();
            var gcAntesGeracao2 = GC.CollectionCount(2);
            var gcAntesGeracao1 = GC.CollectionCount(1);
            var gcAntesGeracao0 = GC.CollectionCount(0);

            stopWatch.Start();
            for (ulong i = 0; i < numeroTentativas; i++)
            {

                Telefone telefone = "+55 (31) 9 7500-0001";
            }
            stopWatch.Stop();

            Console.WriteLine($"{nameof(Telefone)}:");
            Console.WriteLine($"Quantidade de telefones {numeroTentativas}");
            Console.WriteLine($"Tempo execução: {stopWatch.ElapsedMilliseconds}ms");
            Console.WriteLine($"GC geração 2 - {GC.CollectionCount(2) - gcAntesGeracao2}");
            Console.WriteLine($"GC geração 1 - {GC.CollectionCount(1) - gcAntesGeracao1}");
            Console.WriteLine($"GC geração 0 - {GC.CollectionCount(0) - gcAntesGeracao0}");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
        }
    }
}
