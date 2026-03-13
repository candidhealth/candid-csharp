using System.Text.Json;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.Identifiers;
using Candid.Net.OrganizationProviders.V2;
using Candid.Net.OrganizationProviders.V3;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class OrganizationProviderV2Test
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "npi": "1234567890",
              "is_rendering": true,
              "is_billing": true,
              "first_name": "John",
              "last_name": "Doe",
              "organization_name": "Acme Medical",
              "provider_type": "INDIVIDUAL",
              "tax_id": "123456789",
              "taxonomy_code": "1234567890",
              "license_type": "MD",
              "employment_start_date": "2020-10-07",
              "employment_termination_date": "2021-10-07",
              "organization_provider_id": "965A563A-0285-4910-9569-E3739C0F6EAB",
              "qualifications": [
                {
                  "identifier_id": "123e4567-e89b-12d3-a456-426614174000",
                  "identifier_code": "MCR",
                  "identifier_value": {
                    "type": "medicare_provider_identifier",
                    "state": "CA",
                    "provider_number": "1234567890"
                  }
                }
              ]
            }
            """;
        var expectedObject = new OrganizationProviderV2
        {
            Npi = "1234567890",
            IsRendering = true,
            IsBilling = true,
            FirstName = "John",
            LastName = "Doe",
            OrganizationName = "Acme Medical",
            ProviderType = ProviderType.Individual,
            TaxId = "123456789",
            TaxonomyCode = "1234567890",
            LicenseType = LicenseType.Md,
            EmploymentStartDate = new DateOnly(2020, 10, 7),
            EmploymentTerminationDate = new DateOnly(2021, 10, 7),
            OrganizationProviderId = "965A563A-0285-4910-9569-E3739C0F6EAB",
            Qualifications = new List<Identifier>()
            {
                new Identifier
                {
                    IdentifierId = "123e4567-e89b-12d3-a456-426614174000",
                    IdentifierCode = IdentifierCode.Mcr,
                    IdentifierValue = new IdentifierValue(
                        new IdentifierValue.MedicareProviderIdentifier(
                            new MedicareProviderIdentifier
                            {
                                State = State.Ca,
                                ProviderNumber = "1234567890",
                            }
                        )
                    ),
                },
            },
        };
        var deserializedObject = JsonUtils.Deserialize<OrganizationProviderV2>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "npi": "1234567890",
              "is_rendering": true,
              "is_billing": true,
              "first_name": "John",
              "last_name": "Doe",
              "organization_name": "Acme Medical",
              "provider_type": "INDIVIDUAL",
              "tax_id": "123456789",
              "taxonomy_code": "1234567890",
              "license_type": "MD",
              "employment_start_date": "2020-10-07",
              "employment_termination_date": "2021-10-07",
              "organization_provider_id": "965A563A-0285-4910-9569-E3739C0F6EAB",
              "qualifications": [
                {
                  "identifier_id": "123e4567-e89b-12d3-a456-426614174000",
                  "identifier_code": "MCR",
                  "identifier_value": {
                    "type": "medicare_provider_identifier",
                    "state": "CA",
                    "provider_number": "1234567890"
                  }
                }
              ]
            }
            """;
        var actualObj = new OrganizationProviderV2
        {
            Npi = "1234567890",
            IsRendering = true,
            IsBilling = true,
            FirstName = "John",
            LastName = "Doe",
            OrganizationName = "Acme Medical",
            ProviderType = ProviderType.Individual,
            TaxId = "123456789",
            TaxonomyCode = "1234567890",
            LicenseType = LicenseType.Md,
            EmploymentStartDate = new DateOnly(2020, 10, 7),
            EmploymentTerminationDate = new DateOnly(2021, 10, 7),
            OrganizationProviderId = "965A563A-0285-4910-9569-E3739C0F6EAB",
            Qualifications = new List<Identifier>()
            {
                new Identifier
                {
                    IdentifierId = "123e4567-e89b-12d3-a456-426614174000",
                    IdentifierCode = IdentifierCode.Mcr,
                    IdentifierValue = new IdentifierValue(
                        new IdentifierValue.MedicareProviderIdentifier(
                            new MedicareProviderIdentifier
                            {
                                State = State.Ca,
                                ProviderNumber = "1234567890",
                            }
                        )
                    ),
                },
            },
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
