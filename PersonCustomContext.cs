using System.Text.Json.Serialization;

[JsonSerializable(typeof(Person[]))]
internal partial class PersonCustomContext : JsonSerializerContext { }
