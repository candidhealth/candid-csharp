using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Tags;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class TagTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "creator_id": "00EB5A46-35C6-441B-9751-AF307AEF5888",
              "tag_id": "void-claim-submitted",
              "description": "to indicate claims where a void claim has been submitted",
              "color": "black"
            }
            """;
        var expectedObject = new global::Candid.Net.Tags.Tag
        {
            CreatorId = "00EB5A46-35C6-441B-9751-AF307AEF5888",
            TagId = "void-claim-submitted",
            Description = "to indicate claims where a void claim has been submitted",
            Color = TagColorEnum.Black,
        };
        var deserializedObject = JsonUtils.Deserialize<global::Candid.Net.Tags.Tag>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "creator_id": "00EB5A46-35C6-441B-9751-AF307AEF5888",
              "tag_id": "void-claim-submitted",
              "description": "to indicate claims where a void claim has been submitted",
              "color": "black"
            }
            """;
        var actualObj = new global::Candid.Net.Tags.Tag
        {
            CreatorId = "00EB5A46-35C6-441B-9751-AF307AEF5888",
            TagId = "void-claim-submitted",
            Description = "to indicate claims where a void claim has been submitted",
            Color = TagColorEnum.Black,
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
