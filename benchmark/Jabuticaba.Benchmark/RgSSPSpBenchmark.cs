using System;
using System.Diagnostics;
using Jabuticaba.OrgaoEmissor.SSP.SP;

namespace Jabuticaba.Benchmark
{
    public class RgSSPSpBenchmark : IBenchmarkLocal
    {
        /**
        Último resultado alcançado:
        
        */
        public void Executar(ulong numeroTentativas)
        {
            var stopWatch = new Stopwatch();
            var gcAntesGeracao2 = GC.CollectionCount(2);
            var gcAntesGeracao1 = GC.CollectionCount(1);
            var gcAntesGeracao0 = GC.CollectionCount(0);

            stopWatch.Start();
            for (ulong i = 0; i < numeroTentativas; i++)
            {
                Rg rg = "15.506.536-1";
            }
            stopWatch.Stop();

            Console.WriteLine($"{nameof(Rg)}:");
            Console.WriteLine($"Quantidade de Rgs {numeroTentativas}");
            Console.WriteLine($"Tempo execução: {stopWatch.ElapsedMilliseconds}ms");
            Console.WriteLine($"GC geração 2 - {GC.CollectionCount(2) - gcAntesGeracao2}");
            Console.WriteLine($"GC geração 1 - {GC.CollectionCount(1) - gcAntesGeracao1}");
            Console.WriteLine($"GC geração 0 - {GC.CollectionCount(0) - gcAntesGeracao0}");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
        }
    }


}
