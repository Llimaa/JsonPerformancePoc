
# JsonPerformancePoc
Benchmark para melhorar a performance na serialização de json utilizando Source generation.

### Benchmark
Comparação utilizando a serialização normal vs serialização utilizando Source generation:

| Method            | Mean       | Error   | StdDev  | Allocated |
|------------------ |-----------:|--------:|--------:|----------:|
| SerializerDefault | 1,121.1 ms | 2.41 ms | 1.88 ms |    1080 B |
| SerializerCustom  |   644.5 ms | 2.46 ms | 2.06 ms |     736 B |

### Documentações de apoio :book:
[Reflection versus source generation in System.Text.Json](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/reflection-vs-source-generation?pivots=dotnet-8-0)

[JsonSerializerContext Classe](https://learn.microsoft.com/pt-br/dotnet/api/system.text.json.serialization.jsonserializercontext?view=net-8.0)
