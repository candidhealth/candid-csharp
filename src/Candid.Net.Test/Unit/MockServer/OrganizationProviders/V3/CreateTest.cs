using Candid.Net.Commons;
using Candid.Net.Identifiers;
using Candid.Net.OrganizationProviders.V2;
using Candid.Net.OrganizationProviders.V3;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.OrganizationProviders.V3;

[TestFixture]
public class CreateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "npi": "npi",
              "is_rendering": true,
              "is_billing": true,
              "provider_type": "INDIVIDUAL",
              "license_type": "MD",
              "qualifications": [
                {
                  "identifier_code": "MCR",
                  "identifier_value": {
                    "type": "medicare_provider_identifier",
                    "state": "AA",
                    "provider_number": "provider_number"
                  }
                },
                {
                  "identifier_code": "MCR",
                  "identifier_value": {
                    "type": "medicare_provider_identifier",
                    "state": "AA",
                    "provider_number": "provider_number"
                  }
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "npi": "npi",
              "is_rendering": true,
              "is_billing": true,
              "first_name": "first_name",
              "last_name": "last_name",
              "organization_name": "organization_name",
              "provider_type": "INDIVIDUAL",
              "tax_id": "tax_id",
              "taxonomy_code": "taxonomy_code",
              "license_type": "MD",
              "addresses": [
                {
                  "address": {
                    "zip_plus_four_code": "zip_plus_four_code",
                    "address1": "address1",
                    "address2": "address2",
                    "city": "city",
                    "state": "AA",
                    "zip_code": "zip_code"
                  },
                  "address_type": "DEFAULT"
                },
                {
                  "address": {
                    "zip_plus_four_code": "zip_plus_four_code",
                    "address1": "address1",
                    "address2": "address2",
                    "city": "city",
                    "state": "AA",
                    "zip_code": "zip_code"
                  },
                  "address_type": "DEFAULT"
                }
              ],
              "employment_start_date": "2023-01-15",
              "employment_termination_date": "2023-01-15",
              "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "qualifications": [
                {
                  "identifier_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "period": {
                    "start_date": "start_date",
                    "end_date": "end_date"
                  },
                  "identifier_code": "MCR",
                  "identifier_value": {
                    "type": "medicare_provider_identifier",
                    "state": "AA",
                    "provider_number": "provider_number"
                  }
                },
                {
                  "identifier_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "period": {
                    "start_date": "start_date",
                    "end_date": "end_date"
                  },
                  "identifier_code": "MCR",
                  "identifier_value": {
                    "type": "medicare_provider_identifier",
                    "state": "AA",
                    "provider_number": "provider_number"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/organization-providers/v3")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.OrganizationProviders.V3.CreateAsync(
            new OrganizationProviderCreateV2
            {
                Npi = "npi",
                IsRendering = true,
                IsBilling = true,
                ProviderType = ProviderType.Individual,
                LicenseType = LicenseType.Md,
                Qualifications = new List<IdentifierCreate>()
                {
                    new IdentifierCreate
                    {
                        IdentifierCode = IdentifierCode.Mcr,
                        IdentifierValue = new IdentifierValue(
                            new IdentifierValue.MedicareProviderIdentifier(
                                new MedicareProviderIdentifier
                                {
                                    State = State.Aa,
                                    ProviderNumber = "provider_number",
                                }
                            )
                        ),
                    },
                    new IdentifierCreate
                    {
                        IdentifierCode = IdentifierCode.Mcr,
                        IdentifierValue = new IdentifierValue(
                            new IdentifierValue.MedicareProviderIdentifier(
                                new MedicareProviderIdentifier
                                {
                                    State = State.Aa,
                                    ProviderNumber = "provider_number",
                                }
                            )
                        ),
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
