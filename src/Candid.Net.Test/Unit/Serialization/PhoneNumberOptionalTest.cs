using System.Text.Json;
using Candid.Net.Commons;
using Candid.Net.Core;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class PhoneNumberOptionalTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "number": "1234567890",
              "type": "Home"
            }
            """;
        var expectedObject = new PhoneNumberOptional
        {
            Number = "1234567890",
            Type = PhoneNumberType.Home,
        };
        var deserializedObject = JsonUtils.Deserialize<PhoneNumberOptional>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "number": "1234567890",
              "type": "Home"
            }
            """;
        var actualObj = new PhoneNumberOptional
        {
            Number = "1234567890",
            Type = PhoneNumberType.Home,
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
