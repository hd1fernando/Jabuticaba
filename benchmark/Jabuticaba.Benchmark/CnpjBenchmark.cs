using System;
using System.Diagnostics;

namespace Jabuticaba.Benchmark
{
    public class CnpjBenchmark : IBenchmarkLocal
    {
        /**
        Último resultado alcançado:
        Cnpj:
        Quantidade de cnpjs 1000000
        Tempo execução: 862ms
        GC geração 2 - 0
        GC geração 1 - 0
        GC geração 0 - 0
        12/26/2020 9:17:20 AM
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
                Cnpj cnpj = "02.055.097/0001-65";
            }
            stopWatch.Stop();

            Console.WriteLine($"{nameof(Cnpj)}:");
            Console.WriteLine($"Quantidade de cnpjs {numeroTentativas}");
            Console.WriteLine($"Tempo execução: {stopWatch.ElapsedMilliseconds}ms");
            Console.WriteLine($"GC geração 2 - {GC.CollectionCount(2) - gcAntesGeracao2}");
            Console.WriteLine($"GC geração 1 - {GC.CollectionCount(1) - gcAntesGeracao1}");
            Console.WriteLine($"GC geração 0 - {GC.CollectionCount(0) - gcAntesGeracao0}");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
        }
    }
}
