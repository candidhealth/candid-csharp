using System.Text.Json;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.CustomSchemas.V1;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class SchemaTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization_1()
    {
        var json = """
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
            """;
        var expectedObject = new Schema
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
        };
        var deserializedObject = JsonUtils.Deserialize<Schema>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization_1()
    {
        var expectedJson = """
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
            """;
        var actualObj = new Schema
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
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }

    [global::NUnit.Framework.Test]
    public void TestDeserialization_2()
    {
        var json = """
            {
              "id": "ec096b13-f80a-471d-aaeb-54b021c9d582",
              "name": "General Medicine and Health",
              "description": "Values collected during all visits",
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
                },
                {
                  "key": "visit_type",
                  "type": "STRING"
                }
              ]
            }
            """;
        var expectedObject = new Schema
        {
            Id = "ec096b13-f80a-471d-aaeb-54b021c9d582",
            Name = "General Medicine and Health",
            Description = "Values collected during all visits",
            Fields = new List<SchemaField>()
            {
                new SchemaField { Key = "provider_category", Type = Primitive.String },
                new SchemaField { Key = "is_urgent_care", Type = Primitive.Boolean },
                new SchemaField { Key = "bmi", Type = Primitive.Double },
                new SchemaField { Key = "age", Type = Primitive.Integer },
                new SchemaField { Key = "visit_type", Type = Primitive.String },
            },
        };
        var deserializedObject = JsonUtils.Deserialize<Schema>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization_2()
    {
        var expectedJson = """
            {
              "id": "ec096b13-f80a-471d-aaeb-54b021c9d582",
              "name": "General Medicine and Health",
              "description": "Values collected during all visits",
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
                },
                {
                  "key": "visit_type",
                  "type": "STRING"
                }
              ]
            }
            """;
        var actualObj = new Schema
        {
            Id = "ec096b13-f80a-471d-aaeb-54b021c9d582",
            Name = "General Medicine and Health",
            Description = "Values collected during all visits",
            Fields = new List<SchemaField>()
            {
                new SchemaField { Key = "provider_category", Type = Primitive.String },
                new SchemaField { Key = "is_urgent_care", Type = Primitive.Boolean },
                new SchemaField { Key = "bmi", Type = Primitive.Double },
                new SchemaField { Key = "age", Type = Primitive.Integer },
                new SchemaField { Key = "visit_type", Type = Primitive.String },
            },
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
