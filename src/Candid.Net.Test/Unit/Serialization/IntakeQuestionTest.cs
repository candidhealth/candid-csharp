using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class IntakeQuestionTest
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
        var expectedObject = new IntakeQuestion
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
        var deserializedObject = JsonUtils.Deserialize<IntakeQuestion>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
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
        var actualObj = new IntakeQuestion
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
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
