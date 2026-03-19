using global::Candid.Net.Core;
using global::Candid.Net.Encounters.V4;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IntakeQuestionOptionalTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "id": "6E7FBCE4-A8EA-46D0-A8D8-FF83CA3BB176",
              "text": "Do you have any allergies?",
              "responses": [
                {
                  "response": "No allergies",
                  "follow_ups": [
                    {
                      "id": "4F3D57F9-AC94-49D6-87E4-E804B709917A",
                      "text": "Do you have any allergies?",
                      "response": "No allergies"
                    }
                  ]
                }
              ]
            }
            """;
        var expectedObject = new IntakeQuestionOptional
        {
            Id = "6E7FBCE4-A8EA-46D0-A8D8-FF83CA3BB176",
            Text = "Do you have any allergies?",
            Responses = new List<IntakeResponseAndFollowUps>()
            {
                new IntakeResponseAndFollowUps
                {
                    Response = "No allergies",
                    FollowUps = new List<IntakeFollowUp>()
                    {
                        new IntakeFollowUp
                        {
                            Id = "4F3D57F9-AC94-49D6-87E4-E804B709917A",
                            Text = "Do you have any allergies?",
                            Response = "No allergies",
                        },
                    },
                },
            },
        };
        var deserializedObject = JsonUtils.Deserialize<IntakeQuestionOptional>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "id": "6E7FBCE4-A8EA-46D0-A8D8-FF83CA3BB176",
              "text": "Do you have any allergies?",
              "responses": [
                {
                  "response": "No allergies",
                  "follow_ups": [
                    {
                      "id": "4F3D57F9-AC94-49D6-87E4-E804B709917A",
                      "text": "Do you have any allergies?",
                      "response": "No allergies"
                    }
                  ]
                }
              ]
            }
            """;
        JsonAssert.Roundtrips<IntakeQuestionOptional>(inputJson);
    }
}
