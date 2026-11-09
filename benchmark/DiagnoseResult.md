``` bash

// * Detailed results *
CpfBenchmarkDiagnoser.ObterCpf: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 68.766 ns, StdErr = 0.973 ns (1.42%), N = 99, StdDev = 9.682 ns
Min = 52.719 ns, Q1 = 60.955 ns, Median = 67.510 ns, Q3 = 75.915 ns, Max = 99.014 ns
IQR = 14.960 ns, LowerFence = 38.516 ns, UpperFence = 98.355 ns
ConfidenceInterval = [65.465 ns; 72.068 ns] (CI 99.9%), Margin = 3.301 ns (4.80% of Mean)
Skewness = 0.62, Kurtosis = 2.89, MValue = 2.69
-------------------- Histogram --------------------
[49.971 ns ; 54.467 ns) | @@
[54.467 ns ; 60.140 ns) | @@@@@@@@@@@@@@@@@
[60.140 ns ; 65.634 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@
[65.634 ns ; 71.814 ns) | @@@@@@@@@@@@@@@@@@@@@
[71.814 ns ; 75.531 ns) | @@@@@@@
[75.531 ns ; 81.025 ns) | @@@@@@@@@@@@@@@@
[81.025 ns ; 87.109 ns) | @@@@@@@@
[87.109 ns ; 92.603 ns) | 
[92.603 ns ; 99.661 ns) | @@
---------------------------------------------------

CpfBenchmarkDiagnoser.CpfApenasDigitosRepetidos: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 84.067 ns, StdErr = 2.152 ns (2.56%), N = 94, StdDev = 20.868 ns
Min = 56.133 ns, Q1 = 69.805 ns, Median = 77.360 ns, Q3 = 93.111 ns, Max = 140.345 ns
IQR = 23.306 ns, LowerFence = 34.846 ns, UpperFence = 128.071 ns
ConfidenceInterval = [76.753 ns; 91.381 ns] (CI 99.9%), Margin = 7.314 ns (8.70% of Mean)
Skewness = 1.1, Kurtosis = 3.46, MValue = 2.39
-------------------- Histogram --------------------
[ 55.455 ns ;  69.003 ns) | @@@@@@@@@@@@@@@@@@@
[ 69.003 ns ;  81.051 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[ 81.051 ns ;  94.002 ns) | @@@@@@@@@@@@@@@@@
[ 94.002 ns ; 107.275 ns) | @@@@@@@@@@
[107.275 ns ; 120.556 ns) | @@@@@@
[120.556 ns ; 130.812 ns) | 
[130.812 ns ; 142.860 ns) | @@@@@@
---------------------------------------------------

CpfBenchmarkDiagnoser.CpfTamanhoMenorDoQue11Digitos: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 84.496 ns, StdErr = 0.930 ns (1.10%), N = 92, StdDev = 8.924 ns
Min = 67.771 ns, Q1 = 77.110 ns, Median = 84.666 ns, Q3 = 90.514 ns, Max = 110.033 ns
IQR = 13.404 ns, LowerFence = 57.004 ns, UpperFence = 110.620 ns
ConfidenceInterval = [81.332 ns; 87.660 ns] (CI 99.9%), Margin = 3.164 ns (3.74% of Mean)
Skewness = 0.28, Kurtosis = 2.81, MValue = 3.22
-------------------- Histogram --------------------
[ 65.176 ns ;  68.143 ns) | @
[ 68.143 ns ;  74.106 ns) | @@@@@@@@@@@
[ 74.106 ns ;  79.296 ns) | @@@@@@@@@@@@@@@@@@
[ 79.296 ns ;  82.415 ns) | @@@@@@
[ 82.415 ns ;  87.405 ns) | @@@@@@@@@@@@@@@@@@@@
[ 87.405 ns ;  92.594 ns) | @@@@@@@@@@@@@@@@@@@@@@@
[ 92.594 ns ;  97.906 ns) | @@@@@@@@@
[ 97.906 ns ; 104.896 ns) | @
[104.896 ns ; 110.085 ns) | @@@
---------------------------------------------------

CpfBenchmarkDiagnoser.CpfTamanhoMaiorDoQue11Digitos: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 91.540 ns, StdErr = 1.065 ns (1.16%), N = 94, StdDev = 10.324 ns
Min = 76.207 ns, Q1 = 82.659 ns, Median = 90.662 ns, Q3 = 98.152 ns, Max = 117.203 ns
IQR = 15.492 ns, LowerFence = 59.421 ns, UpperFence = 121.390 ns
ConfidenceInterval = [87.922 ns; 95.159 ns] (CI 99.9%), Margin = 3.618 ns (3.95% of Mean)
Skewness = 0.59, Kurtosis = 2.73, MValue = 3.83
-------------------- Histogram --------------------
[ 73.227 ns ;  77.029 ns) | @@@
[ 77.029 ns ;  82.989 ns) | @@@@@@@@@@@@@@@@@@@@@@@
[ 82.989 ns ;  86.145 ns) | @@@@
[ 86.145 ns ;  92.105 ns) | @@@@@@@@@@@@@@@@@@@@@@@
[ 92.105 ns ;  98.575 ns) | @@@@@@@@@@@@@@@@@@@@@@
[ 98.575 ns ; 105.887 ns) | @@@@@@@@@@@
[105.887 ns ; 113.105 ns) | @@@
[113.105 ns ; 120.183 ns) | @@@@@
---------------------------------------------------

CpfBenchmarkDiagnoser.CpfPrimeiroDigitoInvalido: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 91.888 ns, StdErr = 1.283 ns (1.40%), N = 96, StdDev = 12.574 ns
Min = 65.714 ns, Q1 = 84.575 ns, Median = 90.553 ns, Q3 = 100.779 ns, Max = 120.284 ns
IQR = 16.203 ns, LowerFence = 60.270 ns, UpperFence = 125.084 ns
ConfidenceInterval = [87.530 ns; 96.246 ns] (CI 99.9%), Margin = 4.358 ns (4.74% of Mean)
Skewness = -0.09, Kurtosis = 2.42, MValue = 3.31
-------------------- Histogram --------------------
[ 62.109 ns ;  67.365 ns) | @@
[ 67.365 ns ;  74.573 ns) | @@@@@@@@@@
[ 74.573 ns ;  77.818 ns) | @
[ 77.818 ns ;  83.893 ns) | @@@@@@@@
[ 83.893 ns ;  91.102 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[ 91.102 ns ; 100.029 ns) | @@@@@@@@@@@@@@@@@@@@@
[100.029 ns ; 104.138 ns) | @@@@@@
[104.138 ns ; 113.219 ns) | @@@@@@@@@@@@@@@@
[113.219 ns ; 120.428 ns) | @@@
---------------------------------------------------

CpfBenchmarkDiagnoser.CpfContendoValorNaoNumerico: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 100.663 ns, StdErr = 1.882 ns (1.87%), N = 94, StdDev = 18.243 ns
Min = 75.650 ns, Q1 = 87.059 ns, Median = 98.994 ns, Q3 = 111.556 ns, Max = 150.414 ns
IQR = 24.496 ns, LowerFence = 50.315 ns, UpperFence = 148.300 ns
ConfidenceInterval = [94.269 ns; 107.057 ns] (CI 99.9%), Margin = 6.394 ns (6.35% of Mean)
Skewness = 0.65, Kurtosis = 2.78, MValue = 2.86
-------------------- Histogram --------------------
[ 74.725 ns ;  85.257 ns) | @@@@@@@@@@@@@@@@@@@@@@
[ 85.257 ns ;  94.660 ns) | @@@@@@@@@@@@@
[ 94.660 ns ; 105.192 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[105.192 ns ; 116.272 ns) | @@@@@@@@@@@@@
[116.272 ns ; 124.587 ns) | @@@
[124.587 ns ; 136.312 ns) | @@@@@@@@
[136.312 ns ; 146.844 ns) | @@@@
[146.844 ns ; 155.680 ns) | @
---------------------------------------------------

CpfBenchmarkDiagnoser.CpfSegundoDigitoInvalido: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 119.655 ns, StdErr = 3.587 ns (3.00%), N = 95, StdDev = 34.962 ns
Min = 74.383 ns, Q1 = 89.873 ns, Median = 116.942 ns, Q3 = 140.900 ns, Max = 221.221 ns
IQR = 51.027 ns, LowerFence = 13.332 ns, UpperFence = 217.441 ns
ConfidenceInterval = [107.469 ns; 131.840 ns] (CI 99.9%), Margin = 12.185 ns (10.18% of Mean)
Skewness = 0.68, Kurtosis = 2.64, MValue = 3.38
-------------------- Histogram --------------------
[ 74.067 ns ;  94.181 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[ 94.181 ns ; 116.703 ns) | @@@@@@@@@@@@@@@@@
[116.703 ns ; 136.816 ns) | @@@@@@@@@@@@@@@@@@@@
[136.816 ns ; 162.238 ns) | @@@@@@@@@@@@@
[162.238 ns ; 182.352 ns) | @@@@@@@@@@
[182.352 ns ; 204.261 ns) | @@@@
[204.261 ns ; 211.164 ns) | 
[211.164 ns ; 231.278 ns) | @
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.15.8, Linux Manjaro Linux
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 955.30GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.112
  [Host]     : .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4


| Method                        | Mean      | Error     | StdDev    | Median    | Rank | Gen0   | Allocated |
|------------------------------ |----------:|----------:|----------:|----------:|-----:|-------:|----------:|
| ObterCpf                      |  68.77 ns |  3.301 ns |  9.682 ns |  67.51 ns |    1 |      - |         - |
| CpfApenasDigitosRepetidos     |  84.07 ns |  7.314 ns | 20.868 ns |  77.36 ns |    2 |      - |         - |
| CpfTamanhoMenorDoQue11Digitos |  84.50 ns |  3.164 ns |  8.924 ns |  84.67 ns |    2 | 0.0305 |     128 B |
| CpfTamanhoMaiorDoQue11Digitos |  91.54 ns |  3.618 ns | 10.324 ns |  90.66 ns |    2 | 0.0324 |     136 B |
| CpfPrimeiroDigitoInvalido     |  91.89 ns |  4.358 ns | 12.574 ns |  90.55 ns |    2 | 0.0210 |      88 B |
| CpfContendoValorNaoNumerico   | 100.66 ns |  6.394 ns | 18.243 ns |  98.99 ns |    2 | 0.0573 |     240 B |
| CpfSegundoDigitoInvalido      | 119.65 ns | 12.185 ns | 34.962 ns | 116.94 ns |    2 | 0.0210 |      88 B |

// * Warnings *
MultimodalDistribution
  CpfBenchmarkDiagnoser.CpfTamanhoMenorDoQue11Digitos: Default -> It seems that the distribution is bimodal (mValue = 3.22)
  CpfBenchmarkDiagnoser.CpfTamanhoMaiorDoQue11Digitos: Default -> It seems that the distribution is bimodal (mValue = 3.83)
  CpfBenchmarkDiagnoser.CpfPrimeiroDigitoInvalido: Default     -> It seems that the distribution is bimodal (mValue = 3.31)
  CpfBenchmarkDiagnoser.CpfContendoValorNaoNumerico: Default   -> It seems that the distribution can have several modes (mValue = 2.86)
  CpfBenchmarkDiagnoser.CpfSegundoDigitoInvalido: Default      -> It seems that the distribution is bimodal (mValue = 3.38)

// * Hints *
Outliers
  CpfBenchmarkDiagnoser.ObterCpf: Default                      -> 1 outlier  was  removed (106.02 ns)
  CpfBenchmarkDiagnoser.CpfApenasDigitosRepetidos: Default     -> 6 outliers were removed (156.57 ns..247.61 ns)
  CpfBenchmarkDiagnoser.CpfTamanhoMenorDoQue11Digitos: Default -> 8 outliers were removed (117.10 ns..141.28 ns)
  CpfBenchmarkDiagnoser.CpfTamanhoMaiorDoQue11Digitos: Default -> 6 outliers were removed (127.64 ns..209.95 ns)
  CpfBenchmarkDiagnoser.CpfPrimeiroDigitoInvalido: Default     -> 4 outliers were removed (138.12 ns..166.71 ns)
  CpfBenchmarkDiagnoser.CpfContendoValorNaoNumerico: Default   -> 6 outliers were removed (156.66 ns..176.04 ns)
  CpfBenchmarkDiagnoser.CpfSegundoDigitoInvalido: Default      -> 5 outliers were removed (264.78 ns..339.35 ns)

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Median    : Value separating the higher half of all measurements (50th percentile)
  Rank      : Relative position of current benchmark mean among all benchmarks (Arabic style)
  Gen0      : GC Generation 0 collects per 1000 operations
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 ns      : 1 Nanosecond (0.000000001 sec)

// * Detailed results *
CnpjBenchmarkDiagnoser.CnpjSemMascara: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 68.918 ns, StdErr = 1.383 ns (2.01%), N = 99, StdDev = 13.764 ns
Min = 52.171 ns, Q1 = 56.712 ns, Median = 67.180 ns, Q3 = 77.833 ns, Max = 109.316 ns
IQR = 21.121 ns, LowerFence = 25.031 ns, UpperFence = 109.514 ns
ConfidenceInterval = [64.225 ns; 73.611 ns] (CI 99.9%), Margin = 4.693 ns (6.81% of Mean)
Skewness = 0.83, Kurtosis = 3.19, MValue = 2.27
-------------------- Histogram --------------------
[ 52.070 ns ;  59.880 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[ 59.880 ns ;  69.905 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@
[ 69.905 ns ;  80.101 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@
[ 80.101 ns ;  90.121 ns) | @@@@@@@@@
[ 90.121 ns ;  93.526 ns) | 
[ 93.526 ns ; 102.687 ns) | @@@@
[102.687 ns ; 110.497 ns) | @@@
---------------------------------------------------

CnpjBenchmarkDiagnoser.ObterCnpj: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 72.075 ns, StdErr = 0.959 ns (1.33%), N = 100, StdDev = 9.586 ns
Min = 56.163 ns, Q1 = 63.550 ns, Median = 72.736 ns, Q3 = 80.361 ns, Max = 92.875 ns
IQR = 16.811 ns, LowerFence = 38.333 ns, UpperFence = 105.578 ns
ConfidenceInterval = [68.824 ns; 75.326 ns] (CI 99.9%), Margin = 3.251 ns (4.51% of Mean)
Skewness = 0, Kurtosis = 1.75, MValue = 3.27
-------------------- Histogram --------------------
[53.453 ns ; 59.376 ns) | @@@@@@@@@@@
[59.376 ns ; 64.797 ns) | @@@@@@@@@@@@@@@@@@@@@@
[64.797 ns ; 70.222 ns) | @@@@@@@@
[70.222 ns ; 76.443 ns) | @@@@@@@@@@@@@@@@@@@
[76.443 ns ; 81.864 ns) | @@@@@@@@@@@@@@@@@@@@@@
[81.864 ns ; 87.637 ns) | @@@@@@@@@@@@@@@@
[87.637 ns ; 93.609 ns) | @@
---------------------------------------------------

CnpjBenchmarkDiagnoser.CnpjMenorDoQue14Digitos: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 81.547 ns, StdErr = 0.478 ns (0.59%), N = 41, StdDev = 3.060 ns
Min = 77.339 ns, Q1 = 78.906 ns, Median = 81.366 ns, Q3 = 83.649 ns, Max = 89.356 ns
IQR = 4.743 ns, LowerFence = 71.792 ns, UpperFence = 90.763 ns
ConfidenceInterval = [79.850 ns; 83.244 ns] (CI 99.9%), Margin = 1.697 ns (2.08% of Mean)
Skewness = 0.5, Kurtosis = 2.26, MValue = 2
-------------------- Histogram --------------------
[77.337 ns ; 79.666 ns) | @@@@@@@@@@@@@@@@@
[79.666 ns ; 83.072 ns) | @@@@@@@@@@@@
[83.072 ns ; 85.829 ns) | @@@@@@@@
[85.829 ns ; 88.191 ns) | @@@
[88.191 ns ; 90.520 ns) | @
---------------------------------------------------

CnpjBenchmarkDiagnoser.CnpjPrimeiroDigitoInvalido: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 87.833 ns, StdErr = 0.455 ns (0.52%), N = 19, StdDev = 1.984 ns
Min = 84.576 ns, Q1 = 86.442 ns, Median = 87.312 ns, Q3 = 89.081 ns, Max = 92.884 ns
IQR = 2.639 ns, LowerFence = 82.483 ns, UpperFence = 93.040 ns
ConfidenceInterval = [86.048 ns; 89.618 ns] (CI 99.9%), Margin = 1.785 ns (2.03% of Mean)
Skewness = 0.69, Kurtosis = 3.01, MValue = 2
-------------------- Histogram --------------------
[83.600 ns ; 85.583 ns) | @
[85.583 ns ; 87.535 ns) | @@@@@@@@@@
[87.535 ns ; 90.717 ns) | @@@@@@@
[90.717 ns ; 93.860 ns) | @
---------------------------------------------------

CnpjBenchmarkDiagnoser.CnpjSegundoDigitoInvalido: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 98.340 ns, StdErr = 1.397 ns (1.42%), N = 83, StdDev = 12.730 ns
Min = 86.619 ns, Q1 = 91.250 ns, Median = 94.367 ns, Q3 = 99.702 ns, Max = 147.105 ns
IQR = 8.452 ns, LowerFence = 78.572 ns, UpperFence = 112.379 ns
ConfidenceInterval = [93.571 ns; 103.109 ns] (CI 99.9%), Margin = 4.769 ns (4.85% of Mean)
Skewness = 2.24, Kurtosis = 7.94, MValue = 2
-------------------- Histogram --------------------
[ 82.789 ns ;  89.679 ns) | @@@@@@@@@@@@@
[ 89.679 ns ;  97.340 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[ 97.340 ns ; 105.233 ns) | @@@@@@@@@@@@@@@
[105.233 ns ; 115.002 ns) | @@@@
[115.002 ns ; 123.441 ns) | @@
[123.441 ns ; 131.102 ns) | @@@
[131.102 ns ; 138.763 ns) | 
[138.763 ns ; 141.563 ns) | 
[141.563 ns ; 149.224 ns) | @@@
---------------------------------------------------

CnpjBenchmarkDiagnoser.CnpjMaiorDoQue14Digitos: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 107.757 ns, StdErr = 1.101 ns (1.02%), N = 90, StdDev = 10.449 ns
Min = 82.125 ns, Q1 = 101.369 ns, Median = 106.283 ns, Q3 = 111.340 ns, Max = 137.853 ns
IQR = 9.971 ns, LowerFence = 86.412 ns, UpperFence = 126.296 ns
ConfidenceInterval = [104.009 ns; 111.506 ns] (CI 99.9%), Margin = 3.748 ns (3.48% of Mean)
Skewness = 0.64, Kurtosis = 3.52, MValue = 2.42
-------------------- Histogram --------------------
[ 80.753 ns ;  86.874 ns) | @@
[ 86.874 ns ;  92.605 ns) | @
[ 92.605 ns ;  98.173 ns) | @@@@@@@@
[ 98.173 ns ; 104.949 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@
[104.949 ns ; 111.069 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[111.069 ns ; 118.892 ns) | @@@@@@@@@@
[118.892 ns ; 125.468 ns) | @@@@@
[125.468 ns ; 131.588 ns) | @@@@@@
[131.588 ns ; 138.667 ns) | @@
---------------------------------------------------

CnpjBenchmarkDiagnoser.CnpjValorNaoNumerico: DefaultJob
Runtime = .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4; GC = Concurrent Workstation
Mean = 151.200 ns, StdErr = 4.100 ns (2.71%), N = 95, StdDev = 39.958 ns
Min = 106.251 ns, Q1 = 118.969 ns, Median = 137.390 ns, Q3 = 171.925 ns, Max = 261.970 ns
IQR = 52.955 ns, LowerFence = 39.536 ns, UpperFence = 251.358 ns
ConfidenceInterval = [137.274 ns; 165.127 ns] (CI 99.9%), Margin = 13.927 ns (9.21% of Mean)
Skewness = 1.01, Kurtosis = 3.03, MValue = 3.16
-------------------- Histogram --------------------
[ 94.757 ns ; 109.178 ns) | @@@
[109.178 ns ; 132.166 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[132.166 ns ; 157.062 ns) | @@@@@@@@@@@@@@@@@@@
[157.062 ns ; 181.870 ns) | @@@@@@@@@@@@@@@@@@
[181.870 ns ; 190.985 ns) | 
[190.985 ns ; 210.119 ns) | @@@
[210.119 ns ; 233.107 ns) | @@@@@@@@@@
[233.107 ns ; 244.847 ns) | 
[244.847 ns ; 267.835 ns) | @@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.15.8, Linux Manjaro Linux
11th Gen Intel Core i5-1135G7 2.40GHz (Max: 955.30GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.112
  [Host]     : .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 42.42.42.42424), X64 RyuJIT x86-64-v4


| Method                     | Mean      | Error     | StdDev    | Median    | Rank | Gen0   | Allocated |
|--------------------------- |----------:|----------:|----------:|----------:|-----:|-------:|----------:|
| CnpjSemMascara             |  68.92 ns |  4.693 ns | 13.764 ns |  67.18 ns |    1 |      - |         - |
| ObterCnpj                  |  72.07 ns |  3.251 ns |  9.586 ns |  72.74 ns |    1 |      - |         - |
| CnpjMenorDoQue14Digitos    |  81.55 ns |  1.697 ns |  3.060 ns |  81.37 ns |    2 | 0.0324 |     136 B |
| CnpjPrimeiroDigitoInvalido |  87.83 ns |  1.785 ns |  1.984 ns |  87.31 ns |    3 | 0.0229 |      96 B |
| CnpjSegundoDigitoInvalido  |  98.34 ns |  4.769 ns | 12.730 ns |  94.37 ns |    4 | 0.0229 |      96 B |
| CnpjMaiorDoQue14Digitos    | 107.76 ns |  3.748 ns | 10.449 ns | 106.28 ns |    5 | 0.0324 |     136 B |
| CnpjValorNaoNumerico       | 151.20 ns | 13.927 ns | 39.958 ns | 137.39 ns |    6 | 0.0591 |     248 B |

// * Warnings *
MultimodalDistribution
  CnpjBenchmarkDiagnoser.ObterCnpj: Default            -> It seems that the distribution is bimodal (mValue = 3.27)
  CnpjBenchmarkDiagnoser.CnpjValorNaoNumerico: Default -> It seems that the distribution can have several modes (mValue = 3.16)

// * Hints *
Outliers
  CnpjBenchmarkDiagnoser.CnpjSemMascara: Default             -> 1 outlier  was  removed (115.47 ns)
  CnpjBenchmarkDiagnoser.CnpjMenorDoQue14Digitos: Default    -> 1 outlier  was  removed (98.56 ns)
  CnpjBenchmarkDiagnoser.CnpjPrimeiroDigitoInvalido: Default -> 2 outliers were removed (106.02 ns, 110.77 ns)
  CnpjBenchmarkDiagnoser.CnpjSegundoDigitoInvalido: Default  -> 17 outliers were removed (152.16 ns..229.80 ns)
  CnpjBenchmarkDiagnoser.CnpjMaiorDoQue14Digitos: Default    -> 10 outliers were removed (145.47 ns..186.29 ns)
  CnpjBenchmarkDiagnoser.CnpjValorNaoNumerico: Default       -> 5 outliers were removed (274.81 ns..429.79 ns)

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Median    : Value separating the higher half of all measurements (50th percentile)
  Rank      : Relative position of current benchmark mean among all benchmarks (Arabic style)
  Gen0      : GC Generation 0 collects per 1000 operations
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 ns      : 1 Nanosecond (0.000000001 sec)

// * Benchmark local (1.000.000 de iterações) *
Cnpj:
Quantidade de cnpjs 1000000
Tempo execução: 1219ms
GC geração 2 - 0
GC geração 1 - 0
GC geração 0 - 0
09/11/2026 08:42:50

Cpf:
Quantidade de cpfs 1000000
Tempo execução: 321ms
GC geração 2 - 0
GC geração 1 - 0
GC geração 0 - 0
09/11/2026 08:42:50

```
