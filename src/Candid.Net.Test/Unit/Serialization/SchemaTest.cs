using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.CustomSchemas.V1;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class SchemaTest
{
    [Test]
    public void TestSerialization_1()
    {
        var inputJson =
            @"
        {
  ""id"": ""ec096b13-f80a-471d-aaeb-54b021c9d582"",
  ""name"": ""General Medicine"",
  ""description"": ""Values associated with a generic visit"",
  ""fields"": [
    {
      ""key"": ""provider_category"",
      ""type"": ""STRING""
    },
    {
      ""key"": ""is_urgent_care"",
      ""type"": ""BOOLEAN""
    },
    {
      ""key"": ""bmi"",
      ""type"": ""DOUBLE""
    },
    {
      ""key"": ""age"",
      ""type"": ""INTEGER""
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Schema>(inputJson, serializerOptions);

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }

    [Test]
    public void TestSerialization_2()
    {
        var inputJson =
            @"
        {
  ""id"": ""ec096b13-f80a-471d-aaeb-54b021c9d582"",
  ""name"": ""General Medicine and Health"",
  ""description"": ""Values collected during all visits"",
  ""fields"": [
    {
      ""key"": ""provider_category"",
      ""type"": ""STRING""
    },
    {
      ""key"": ""is_urgent_care"",
      ""type"": ""BOOLEAN""
    },
    {
      ""key"": ""bmi"",
      ""type"": ""DOUBLE""
    },
    {
      ""key"": ""age"",
      ""type"": ""INTEGER""
    },
    {
      ""key"": ""visit_type"",
      ""type"": ""STRING""
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Schema>(inputJson, serializerOptions);

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        JToken.Parse(inputJson).Should().BeEquivalentTo(JToken.Parse(serializedJson));
    }
}
