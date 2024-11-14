``` bash

// * Detailed results *
CpfBenchmarkDiagnoser.CpfApenasDigitosRepetidos: DefaultJob
Runtime = .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT; GC = Concurrent Workstation
Mean = 59.700 ns, StdErr = 0.361 ns (0.60%), N = 85, StdDev = 3.328 ns
Min = 54.100 ns, Q1 = 57.141 ns, Median = 59.039 ns, Q3 = 61.630 ns, Max = 68.872 ns
IQR = 4.489 ns, LowerFence = 50.407 ns, UpperFence = 68.364 ns
ConfidenceInterval = [58.469 ns; 60.931 ns] (CI 99.9%), Margin = 1.231 ns (2.06% of Mean)
Skewness = 0.8, Kurtosis = 3.24, MValue = 2
-------------------- Histogram --------------------
[53.106 ns ; 55.306 ns) | @@@@
[55.306 ns ; 57.642 ns) | @@@@@@@@@@@@@@@@@@@@
[57.642 ns ; 59.629 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@
[59.629 ns ; 61.907 ns) | @@@@@@@@@@@@@@@@@@
[61.907 ns ; 64.438 ns) | @@@@@@@
[64.438 ns ; 66.424 ns) | @@@@@@
[66.424 ns ; 69.188 ns) | @@@@
---------------------------------------------------

CpfBenchmarkDiagnoser.CpfPrimeiroDigitoInvalido: DefaultJob
Runtime = .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT; GC = Concurrent Workstation
Mean = 76.688 ns, StdErr = 0.410 ns (0.53%), N = 22, StdDev = 1.924 ns
Min = 73.621 ns, Q1 = 75.018 ns, Median = 76.659 ns, Q3 = 78.250 ns, Max = 80.154 ns
IQR = 3.232 ns, LowerFence = 70.170 ns, UpperFence = 83.098 ns
ConfidenceInterval = [75.121 ns; 78.255 ns] (CI 99.9%), Margin = 1.567 ns (2.04% of Mean)
Skewness = 0.04, Kurtosis = 1.74, MValue = 2
-------------------- Histogram --------------------
[72.720 ns ; 76.044 ns) | @@@@@@@@
[76.044 ns ; 78.400 ns) | @@@@@@@@
[78.400 ns ; 80.202 ns) | @@@@@@
---------------------------------------------------

CpfBenchmarkDiagnoser.ObterCpf: DefaultJob
Runtime = .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT; GC = Concurrent Workstation
Mean = 77.373 ns, StdErr = 1.021 ns (1.32%), N = 99, StdDev = 10.156 ns
Min = 65.659 ns, Q1 = 69.935 ns, Median = 73.278 ns, Q3 = 82.934 ns, Max = 102.749 ns
IQR = 12.999 ns, LowerFence = 50.437 ns, UpperFence = 102.432 ns
ConfidenceInterval = [73.910 ns; 80.836 ns] (CI 99.9%), Margin = 3.463 ns (4.48% of Mean)
Skewness = 0.99, Kurtosis = 2.79, MValue = 2.33
-------------------- Histogram --------------------
[62.777 ns ;  66.320 ns) | @
[66.320 ns ;  72.083 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[72.083 ns ;  78.163 ns) | @@@@@@@@@@@@@@@@@
[78.163 ns ;  83.926 ns) | @@@@@@@@@@@@@@@
[83.926 ns ;  90.036 ns) | @@@@@@@
[90.036 ns ;  93.097 ns) | @
[93.097 ns ;  98.860 ns) | @@@@@@@@@
[98.860 ns ; 105.631 ns) | @@@@@
---------------------------------------------------

CpfBenchmarkDiagnoser.CpfSegundoDigitoInvalido: DefaultJob
Runtime = .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT; GC = Concurrent Workstation
Mean = 85.206 ns, StdErr = 0.686 ns (0.80%), N = 97, StdDev = 6.755 ns
Min = 75.588 ns, Q1 = 79.502 ns, Median = 83.525 ns, Q3 = 90.310 ns, Max = 104.780 ns
IQR = 10.808 ns, LowerFence = 63.290 ns, UpperFence = 106.521 ns
ConfidenceInterval = [82.878 ns; 87.534 ns] (CI 99.9%), Margin = 2.328 ns (2.73% of Mean)
Skewness = 0.79, Kurtosis = 2.85, MValue = 2.5
-------------------- Histogram --------------------
[ 73.659 ns ;  77.154 ns) | @@
[ 77.154 ns ;  81.014 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[ 81.014 ns ;  85.258 ns) | @@@@@@@@@@@@@@@@@@@
[ 85.258 ns ;  88.297 ns) | @@@@@@@@
[ 88.297 ns ;  92.157 ns) | @@@@@@@@@@@@@@@@@
[ 92.157 ns ;  96.316 ns) | @@@@@@@@@@
[ 96.316 ns ; 101.737 ns) | @@@
[101.737 ns ; 106.709 ns) | @@
---------------------------------------------------

CpfBenchmarkDiagnoser.CpfTamanhoMaiorDoQue11Digitos: DefaultJob
Runtime = .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT; GC = Concurrent Workstation
Mean = 99.843 ns, StdErr = 0.594 ns (0.60%), N = 79, StdDev = 5.282 ns
Min = 91.066 ns, Q1 = 96.432 ns, Median = 98.102 ns, Q3 = 102.914 ns, Max = 113.190 ns
IQR = 6.482 ns, LowerFence = 86.708 ns, UpperFence = 112.638 ns
ConfidenceInterval = [97.811 ns; 101.876 ns] (CI 99.9%), Margin = 2.032 ns (2.04% of Mean)
Skewness = 0.85, Kurtosis = 2.88, MValue = 2.13
-------------------- Histogram --------------------
[ 89.450 ns ;  91.813 ns) | @
[ 91.813 ns ;  95.045 ns) | @@@@@@@@@@@@
[ 95.045 ns ;  98.936 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[ 98.936 ns ; 102.617 ns) | @@@@@@@@@@@@@@@@
[102.617 ns ; 106.390 ns) | @@@@@@@@
[106.390 ns ; 110.100 ns) | @@@@@
[110.100 ns ; 113.331 ns) | @@@@@@@
---------------------------------------------------

CpfBenchmarkDiagnoser.CpfTamanhoMenorDoQue11Digitos: DefaultJob
Runtime = .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT; GC = Concurrent Workstation
Mean = 107.512 ns, StdErr = 1.523 ns (1.42%), N = 95, StdDev = 14.844 ns
Min = 89.616 ns, Q1 = 96.603 ns, Median = 103.258 ns, Q3 = 115.640 ns, Max = 152.763 ns
IQR = 19.037 ns, LowerFence = 68.048 ns, UpperFence = 144.196 ns
ConfidenceInterval = [102.339 ns; 112.686 ns] (CI 99.9%), Margin = 5.173 ns (4.81% of Mean)
Skewness = 1.16, Kurtosis = 3.62, MValue = 2.24
-------------------- Histogram --------------------
[ 85.346 ns ;  91.623 ns) | @@@@
[ 91.623 ns ; 100.162 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[100.162 ns ; 108.684 ns) | @@@@@@@@@@@@@@@@@@@@@@
[108.684 ns ; 116.615 ns) | @@@@@@@@
[116.615 ns ; 125.154 ns) | @@@@@@@@@@@@@
[125.154 ns ; 129.063 ns) | @
[129.063 ns ; 137.602 ns) | @@@@@@
[137.602 ns ; 144.936 ns) |
[144.936 ns ; 153.476 ns) | @@@@
---------------------------------------------------

CpfBenchmarkDiagnoser.CpfContendoValorNaoNumerico: DefaultJob
Runtime = .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT; GC = Concurrent Workstation
Mean = 111.993 ns, StdErr = 0.750 ns (0.67%), N = 94, StdDev = 7.272 ns
Min = 100.128 ns, Q1 = 106.017 ns, Median = 110.300 ns, Q3 = 116.772 ns, Max = 134.739 ns
IQR = 10.755 ns, LowerFence = 89.885 ns, UpperFence = 132.905 ns
ConfidenceInterval = [109.444 ns; 114.542 ns] (CI 99.9%), Margin = 2.549 ns (2.28% of Mean)
Skewness = 0.88, Kurtosis = 3.67, MValue = 2
-------------------- Histogram --------------------
[ 98.029 ns ; 101.619 ns) | @@
[101.619 ns ; 105.949 ns) | @@@@@@@@@@@@@@@@@@@
[105.949 ns ; 110.147 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@
[110.147 ns ; 114.255 ns) | @@@@@@@@@@@@@@@@@@
[114.255 ns ; 116.563 ns) | @@@@@
[116.563 ns ; 120.762 ns) | @@@@@@@@@@@@@@@@@@
[120.762 ns ; 127.263 ns) | @@@@
[127.263 ns ; 131.612 ns) |
[131.612 ns ; 135.811 ns) | @@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22631
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=8.0.404
  [Host]     : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT
  DefaultJob : .NET 6.0.36 (6.0.3624.51421), X64 RyuJIT


|                        Method |      Mean |    Error |    StdDev |    Median | Rank |  Gen 0 | Allocated |
|------------------------------ |----------:|---------:|----------:|----------:|-----:|-------:|----------:|
|     CpfApenasDigitosRepetidos |  59.70 ns | 1.231 ns |  3.328 ns |  59.04 ns |    1 |      - |         - |
|     CpfPrimeiroDigitoInvalido |  76.69 ns | 1.567 ns |  1.924 ns |  76.66 ns |    2 | 0.0210 |      88 B |
|                      ObterCpf |  77.37 ns | 3.463 ns | 10.156 ns |  73.28 ns |    2 |      - |         - |
|      CpfSegundoDigitoInvalido |  85.21 ns | 2.328 ns |  6.755 ns |  83.53 ns |    3 | 0.0210 |      88 B |
| CpfTamanhoMaiorDoQue11Digitos |  99.84 ns | 2.032 ns |  5.282 ns |  98.10 ns |    4 | 0.0324 |     136 B |
| CpfTamanhoMenorDoQue11Digitos | 107.51 ns | 5.173 ns | 14.844 ns | 103.26 ns |    5 | 0.0305 |     128 B |
|   CpfContendoValorNaoNumerico | 111.99 ns | 2.549 ns |  7.272 ns | 110.30 ns |    6 | 0.0573 |     240 B |

// * Hints *
Outliers
  CpfBenchmarkDiagnoser.CpfApenasDigitosRepetidos: Default     -> 8 outliers were removed (72.38 ns..80.31 ns)
  CpfBenchmarkDiagnoser.CpfPrimeiroDigitoInvalido: Default     -> 6 outliers were removed (90.14 ns..110.32 ns)
  CpfBenchmarkDiagnoser.ObterCpf: Default                      -> 1 outlier  was  removed (103.84 ns)
  CpfBenchmarkDiagnoser.CpfSegundoDigitoInvalido: Default      -> 3 outliers were removed (116.12 ns..124.13 ns)
  CpfBenchmarkDiagnoser.CpfTamanhoMaiorDoQue11Digitos: Default -> 6 outliers were removed (119.21 ns..134.32 ns)
  CpfBenchmarkDiagnoser.CpfTamanhoMenorDoQue11Digitos: Default -> 5 outliers were removed (166.14 ns..207.73 ns)
  CpfBenchmarkDiagnoser.CpfContendoValorNaoNumerico: Default   -> 6 outliers were removed (140.07 ns..145.31 ns)

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Median    : Value separating the higher half of all measurements (50th percentile)
  Rank      : Relative position of current benchmark mean among all benchmarks (Arabic style)
  Gen 0     : GC Generation 0 collects per 1000 operations
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 ns      : 1 Nanosecond (0.000000001 sec)

// * Diagnostic Output - MemoryDiagnoser *
```