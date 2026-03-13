using System.Text.Json;
using Candid.Net.Commons;
using Candid.Net.Core;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class StreetAddressShortZipOptionalTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "address1": "123 Main St",
              "address2": "Apt 1",
              "city": "New York",
              "state": "NY",
              "zip_code": "10001",
              "zip_plus_four_code": "1234"
            }
            """;
        var expectedObject = new StreetAddressShortZipOptional
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        };
        var deserializedObject = JsonUtils.Deserialize<StreetAddressShortZipOptional>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "address1": "123 Main St",
              "address2": "Apt 1",
              "city": "New York",
              "state": "NY",
              "zip_code": "10001",
              "zip_plus_four_code": "1234"
            }
            """;
        var actualObj = new StreetAddressShortZipOptional
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
