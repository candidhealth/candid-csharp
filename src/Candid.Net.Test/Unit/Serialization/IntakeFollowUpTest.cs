using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class IntakeFollowUpTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "id": "4F3D57F9-AC94-49D6-87E4-E804B709917A",
              "text": "Do you have any allergies?",
              "response": "No allergies"
            }
            """;
        var expectedObject = new IntakeFollowUp
        {
            Id = "4F3D57F9-AC94-49D6-87E4-E804B709917A",
            Text = "Do you have any allergies?",
            Response = "No allergies",
        };
        var deserializedObject = JsonUtils.Deserialize<IntakeFollowUp>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "id": "4F3D57F9-AC94-49D6-87E4-E804B709917A",
              "text": "Do you have any allergies?",
              "response": "No allergies"
            }
            """;
        var actualObj = new IntakeFollowUp
        {
            Id = "4F3D57F9-AC94-49D6-87E4-E804B709917A",
            Text = "Do you have any allergies?",
            Response = "No allergies",
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
