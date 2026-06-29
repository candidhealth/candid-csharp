using global::Candid.Net.Core;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ResourcePageTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "prev_page_token": "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
              "next_page_token": "eyAiZm9vIjogImJhciJ9o8dj3FU83fFJe8dalz4A"
            }
            """;
        var expectedObject = new global::Candid.Net.Commons.ResourcePage
        {
            PrevPageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
            NextPageToken = "eyAiZm9vIjogImJhciJ9o8dj3FU83fFJe8dalz4A",
        };
        var deserializedObject = JsonUtils.Deserialize<global::Candid.Net.Commons.ResourcePage>(
            json
        );
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "prev_page_token": "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
              "next_page_token": "eyAiZm9vIjogImJhciJ9o8dj3FU83fFJe8dalz4A"
            }
            """;
        JsonAssert.Roundtrips<global::Candid.Net.Commons.ResourcePage>(inputJson);
    }
}
