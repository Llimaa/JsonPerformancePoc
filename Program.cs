using System.Text.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run(typeof(SerializerMethods).Assembly);

[MemoryDiagnoser]
public class SerializerMethods
{
    private MemoryStream _memoryStream = default!;
    private Utf8JsonWriter _jsonWriter =default!;
    private IEnumerable<Person> _people = default!;

    [GlobalSetup]
    public void Setup()
    {
        _memoryStream = new MemoryStream();
        _jsonWriter = new Utf8JsonWriter(_memoryStream);

        _people = DataFakePeople.GetPeople();
    }

    [GlobalCleanup]
    public void Cleanup()
    {
        _memoryStream.Dispose();
        _jsonWriter.Dispose();
    }

    [Benchmark]
    public void SerializerDefault()
    {
        JsonSerializer.Serialize(_jsonWriter, _people);

        _memoryStream.SetLength(0);
        _jsonWriter.Reset();
    }

    [Benchmark]
    public void SerializerCustom()
    {
        JsonSerializer.Serialize(_jsonWriter, value: _people, jsonTypeInfo: PersonCustomContext.Default.PersonArray);

        _memoryStream?.SetLength(0);
        _jsonWriter.Reset();
    }
}
