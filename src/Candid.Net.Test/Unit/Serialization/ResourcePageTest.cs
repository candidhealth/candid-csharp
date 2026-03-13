using System.Text.Json;
using Candid.Net.Core;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
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
        var expectedJson = """
            {
              "prev_page_token": "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
              "next_page_token": "eyAiZm9vIjogImJhciJ9o8dj3FU83fFJe8dalz4A"
            }
            """;
        var actualObj = new global::Candid.Net.Commons.ResourcePage
        {
            PrevPageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
            NextPageToken = "eyAiZm9vIjogImJhciJ9o8dj3FU83fFJe8dalz4A",
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
