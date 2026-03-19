using global::Candid.Net.Core;
using global::Candid.Net.Tags;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
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
        var inputJson = """
            {
              "creator_id": "00EB5A46-35C6-441B-9751-AF307AEF5888",
              "tag_id": "void-claim-submitted",
              "description": "to indicate claims where a void claim has been submitted",
              "color": "black"
            }
            """;
        JsonAssert.Roundtrips<global::Candid.Net.Tags.Tag>(inputJson);
    }
}
