using global::Candid.Net.Core;
using global::Candid.Net.Encounters.V4;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
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
        var inputJson = """
            {
              "id": "4F3D57F9-AC94-49D6-87E4-E804B709917A",
              "text": "Do you have any allergies?",
              "response": "No allergies"
            }
            """;
        JsonAssert.Roundtrips<IntakeFollowUp>(inputJson);
    }
}
