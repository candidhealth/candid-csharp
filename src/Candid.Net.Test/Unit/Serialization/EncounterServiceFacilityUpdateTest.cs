using System.Text.Json;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.ServiceFacility;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class EncounterServiceFacilityUpdateTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "organization_name": "Test Organization",
              "address": {
                "address1": "123 Main St",
                "address2": "Apt 1",
                "city": "New York",
                "state": "NY",
                "zip_code": "10001",
                "zip_plus_four_code": "1234"
              }
            }
            """;
        var expectedObject = new EncounterServiceFacilityUpdate
        {
            OrganizationName = "Test Organization",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
        };
        var deserializedObject = JsonUtils.Deserialize<EncounterServiceFacilityUpdate>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "organization_name": "Test Organization",
              "address": {
                "address1": "123 Main St",
                "address2": "Apt 1",
                "city": "New York",
                "state": "NY",
                "zip_code": "10001",
                "zip_plus_four_code": "1234"
              }
            }
            """;
        var actualObj = new EncounterServiceFacilityUpdate
        {
            OrganizationName = "Test Organization",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
