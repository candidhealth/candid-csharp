using global::Candid.Net.Contracts.V4;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Contracts.V4;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetContractServiceFacilityProvidersTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "employment_status": "ACTIVE",
                  "employment_start_date": "employment_start_date",
                  "employment_termination_date": "employment_termination_date",
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
                  "ptan": "ptan",
                  "medicaid_provider_id": "medicaid_provider_id",
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
                  ]
                },
                {
                  "organization_provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "employment_status": "ACTIVE",
                  "employment_start_date": "employment_start_date",
                  "employment_termination_date": "employment_termination_date",
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
                  "ptan": "ptan",
                  "medicaid_provider_id": "medicaid_provider_id",
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
                  ]
                }
              ],
              "prev_page_token": "prev_page_token",
              "next_page_token": "next_page_token"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/contracts/v4/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/service-facilities/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/providers"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Contracts.V4.GetContractServiceFacilityProvidersAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new GetContractServiceFacilityProvidersRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
