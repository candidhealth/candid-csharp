using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Users.V2;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class HumanUserMetadataTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "first_name": "John",
              "last_name": "Doe",
              "email": "john.doe@example.com"
            }
            """;
        var expectedObject = new HumanUserMetadata
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
        };
        var deserializedObject = JsonUtils.Deserialize<HumanUserMetadata>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "first_name": "John",
              "last_name": "Doe",
              "email": "john.doe@example.com"
            }
            """;
        var actualObj = new HumanUserMetadata
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
