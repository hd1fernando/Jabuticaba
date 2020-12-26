using System;
using System.Collections.Generic;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Jabuticaba.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
#if RELEASE
            var summary = BenchmarkRunner.Run<CpfBenchmarkDiagnoser>();
#endif

            List<IBenchmarkLocal> benchmarks = new() { new CpfBenchmark() };
            benchmarks.ForEach(
                b => b.Executar(numeroTentativas: 1_000_000)
            );
        }
    }

    [MemoryDiagnoser]
    public class CpfBenchmarkDiagnoser
    {
        [Benchmark(Baseline = true)]
        public void ObterCpf()
        {
            Cpf cpf = "529.982.247-25";
        }
    }

    public class CnpjBenchmark : IBenchmarkLocal
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
                Cnpj cpf = "02.055.097/0001-65";
            }
            stopWatch.Stop();

            Console.WriteLine($"{nameof(Cpf)}:");
            Console.WriteLine($"Quantidade de cpfs {numeroTentativas}");
            Console.WriteLine($"Tempo execução: {stopWatch.ElapsedMilliseconds}ms");
            Console.WriteLine($"GC geração 2 - {GC.CollectionCount(2) - gcAntesGeracao2}");
            Console.WriteLine($"GC geração 1 - {GC.CollectionCount(1) - gcAntesGeracao1}");
            Console.WriteLine($"GC geração 0 - {GC.CollectionCount(0) - gcAntesGeracao0}");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
        }
    }
}
