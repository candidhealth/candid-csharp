using System.Text.Json;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.EncounterProviders.V2;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class EncounterProviderTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "address": {
                "address1": "123 Main St",
                "address2": "Apt 1",
                "city": "New York",
                "state": "NY",
                "zip_code": "10001",
                "zip_plus_four_code": "1234"
              },
              "tax_id": "123456789",
              "npi": "1234567890",
              "taxonomy_code": "207Q00000X",
              "first_name": "John",
              "last_name": "Doe",
              "organization_name": "Organization Name"
            }
            """;
        var expectedObject = new EncounterProvider
        {
            ProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            TaxId = "123456789",
            Npi = "1234567890",
            TaxonomyCode = "207Q00000X",
            FirstName = "John",
            LastName = "Doe",
            OrganizationName = "Organization Name",
        };
        var deserializedObject = JsonUtils.Deserialize<EncounterProvider>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "address": {
                "address1": "123 Main St",
                "address2": "Apt 1",
                "city": "New York",
                "state": "NY",
                "zip_code": "10001",
                "zip_plus_four_code": "1234"
              },
              "tax_id": "123456789",
              "npi": "1234567890",
              "taxonomy_code": "207Q00000X",
              "first_name": "John",
              "last_name": "Doe",
              "organization_name": "Organization Name"
            }
            """;
        var actualObj = new EncounterProvider
        {
            ProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            TaxId = "123456789",
            Npi = "1234567890",
            TaxonomyCode = "207Q00000X",
            FirstName = "John",
            LastName = "Doe",
            OrganizationName = "Organization Name",
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
