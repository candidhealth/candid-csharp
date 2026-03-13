using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class LabOptionalTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "name": "Genetic Health Labs",
              "code": "GH12345",
              "code_type": "quest"
            }
            """;
        var expectedObject = new LabOptional
        {
            Name = "Genetic Health Labs",
            Code = "GH12345",
            CodeType = LabCodeType.Quest,
        };
        var deserializedObject = JsonUtils.Deserialize<LabOptional>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "name": "Genetic Health Labs",
              "code": "GH12345",
              "code_type": "quest"
            }
            """;
        var actualObj = new LabOptional
        {
            Name = "Genetic Health Labs",
            Code = "GH12345",
            CodeType = LabCodeType.Quest,
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
