using global::Candid.Net.Core;
using global::Candid.Net.CustomSchemas.V1;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SchemaInstanceTest
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
        var expectedObject = new SchemaInstance
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
        var deserializedObject = JsonUtils.Deserialize<SchemaInstance>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
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
        JsonAssert.Roundtrips<SchemaInstance>(inputJson);
    }
}
