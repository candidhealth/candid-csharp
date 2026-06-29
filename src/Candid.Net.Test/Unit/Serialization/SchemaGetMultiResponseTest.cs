using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.CustomSchemas.V1;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SchemaGetMultiResponseTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "schemas": [
                {
                  "id": "ec096b13-f80a-471d-aaeb-54b021c9d582",
                  "name": "General Medicine",
                  "description": "Values associated with a generic visit",
                  "fields": [
                    {
                      "key": "provider_category",
                      "type": "STRING"
                    },
                    {
                      "key": "is_urgent_care",
                      "type": "BOOLEAN"
                    },
                    {
                      "key": "bmi",
                      "type": "DOUBLE"
                    },
                    {
                      "key": "age",
                      "type": "INTEGER"
                    }
                  ]
                }
              ]
            }
            """;
        var expectedObject = new SchemaGetMultiResponse
        {
            Schemas = new List<Schema>()
            {
                new Schema
                {
                    Id = "ec096b13-f80a-471d-aaeb-54b021c9d582",
                    Name = "General Medicine",
                    Description = "Values associated with a generic visit",
                    Fields = new List<SchemaField>()
                    {
                        new SchemaField { Key = "provider_category", Type = Primitive.String },
                        new SchemaField { Key = "is_urgent_care", Type = Primitive.Boolean },
                        new SchemaField { Key = "bmi", Type = Primitive.Double },
                        new SchemaField { Key = "age", Type = Primitive.Integer },
                    },
                },
            },
        };
        var deserializedObject = JsonUtils.Deserialize<SchemaGetMultiResponse>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "schemas": [
                {
                  "id": "ec096b13-f80a-471d-aaeb-54b021c9d582",
                  "name": "General Medicine",
                  "description": "Values associated with a generic visit",
                  "fields": [
                    {
                      "key": "provider_category",
                      "type": "STRING"
                    },
                    {
                      "key": "is_urgent_care",
                      "type": "BOOLEAN"
                    },
                    {
                      "key": "bmi",
                      "type": "DOUBLE"
                    },
                    {
                      "key": "age",
                      "type": "INTEGER"
                    }
                  ]
                }
              ]
            }
            """;
        JsonAssert.Roundtrips<SchemaGetMultiResponse>(inputJson);
    }
}
