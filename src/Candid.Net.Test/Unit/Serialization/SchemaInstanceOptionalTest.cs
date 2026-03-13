using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.CustomSchemas.V1;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class SchemaInstanceOptionalTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "schema_id": "ec096b13-f80a-471d-aaeb-54b021c9d582",
              "content": {
                "provider_category": "internist",
                "is_urgent_care": true,
                "bmi": 24.2,
                "age": 38
              }
            }
            """;
        var expectedObject = new SchemaInstanceOptional
        {
            SchemaId = "ec096b13-f80a-471d-aaeb-54b021c9d582",
            Content = new Dictionary<string, object?>()
            {
                { "provider_category", "internist" },
                { "is_urgent_care", true },
                { "bmi", 24.2 },
                { "age", 38 },
            },
        };
        var deserializedObject = JsonUtils.Deserialize<SchemaInstanceOptional>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "schema_id": "ec096b13-f80a-471d-aaeb-54b021c9d582",
              "content": {
                "provider_category": "internist",
                "is_urgent_care": true,
                "bmi": 24.2,
                "age": 38
              }
            }
            """;
        var actualObj = new SchemaInstanceOptional
        {
            SchemaId = "ec096b13-f80a-471d-aaeb-54b021c9d582",
            Content = new Dictionary<string, object?>()
            {
                { "provider_category", "internist" },
                { "is_urgent_care", true },
                { "bmi", 24.2 },
                { "age", 38 },
            },
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
