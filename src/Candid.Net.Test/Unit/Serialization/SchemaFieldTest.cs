using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.CustomSchemas.V1;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
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
        var inputJson = """
            {
              "key": "provider_category",
              "type": "STRING"
            }
            """;
        JsonAssert.Roundtrips<SchemaField>(inputJson);
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
        var inputJson = """
            {
              "key": "visit_type",
              "type": "STRING"
            }
            """;
        JsonAssert.Roundtrips<SchemaField>(inputJson);
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
        var inputJson = """
            {
              "key": "is_urgent_care",
              "type": "BOOLEAN"
            }
            """;
        JsonAssert.Roundtrips<SchemaField>(inputJson);
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
        var inputJson = """
            {
              "key": "bmi",
              "type": "DOUBLE"
            }
            """;
        JsonAssert.Roundtrips<SchemaField>(inputJson);
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
        var inputJson = """
            {
              "key": "age",
              "type": "INTEGER"
            }
            """;
        JsonAssert.Roundtrips<SchemaField>(inputJson);
    }
}
