using System.Text.Json;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.CustomSchemas.V1;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class SchemaFieldTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization_1()
    {
        var json = """
            {
              "key": "provider_category",
              "type": "STRING"
            }
            """;
        var expectedObject = new SchemaField { Key = "provider_category", Type = Primitive.String };
        var deserializedObject = JsonUtils.Deserialize<SchemaField>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization_1()
    {
        var expectedJson = """
            {
              "key": "provider_category",
              "type": "STRING"
            }
            """;
        var actualObj = new SchemaField { Key = "provider_category", Type = Primitive.String };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }

    [global::NUnit.Framework.Test]
    public void TestDeserialization_2()
    {
        var json = """
            {
              "key": "visit_type",
              "type": "STRING"
            }
            """;
        var expectedObject = new SchemaField { Key = "visit_type", Type = Primitive.String };
        var deserializedObject = JsonUtils.Deserialize<SchemaField>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization_2()
    {
        var expectedJson = """
            {
              "key": "visit_type",
              "type": "STRING"
            }
            """;
        var actualObj = new SchemaField { Key = "visit_type", Type = Primitive.String };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }

    [global::NUnit.Framework.Test]
    public void TestDeserialization_3()
    {
        var json = """
            {
              "key": "is_urgent_care",
              "type": "BOOLEAN"
            }
            """;
        var expectedObject = new SchemaField { Key = "is_urgent_care", Type = Primitive.Boolean };
        var deserializedObject = JsonUtils.Deserialize<SchemaField>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization_3()
    {
        var expectedJson = """
            {
              "key": "is_urgent_care",
              "type": "BOOLEAN"
            }
            """;
        var actualObj = new SchemaField { Key = "is_urgent_care", Type = Primitive.Boolean };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }

    [global::NUnit.Framework.Test]
    public void TestDeserialization_4()
    {
        var json = """
            {
              "key": "bmi",
              "type": "DOUBLE"
            }
            """;
        var expectedObject = new SchemaField { Key = "bmi", Type = Primitive.Double };
        var deserializedObject = JsonUtils.Deserialize<SchemaField>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization_4()
    {
        var expectedJson = """
            {
              "key": "bmi",
              "type": "DOUBLE"
            }
            """;
        var actualObj = new SchemaField { Key = "bmi", Type = Primitive.Double };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }

    [global::NUnit.Framework.Test]
    public void TestDeserialization_5()
    {
        var json = """
            {
              "key": "age",
              "type": "INTEGER"
            }
            """;
        var expectedObject = new SchemaField { Key = "age", Type = Primitive.Integer };
        var deserializedObject = JsonUtils.Deserialize<SchemaField>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization_5()
    {
        var expectedJson = """
            {
              "key": "age",
              "type": "INTEGER"
            }
            """;
        var actualObj = new SchemaField { Key = "age", Type = Primitive.Integer };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
