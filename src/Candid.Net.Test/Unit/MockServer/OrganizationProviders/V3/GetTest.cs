using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.OrganizationProviders.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
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

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/organization-providers/v3/965A563A-0285-4910-9569-E3739C0F6EAB")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.OrganizationProviders.V3.GetAsync(
            "965A563A-0285-4910-9569-E3739C0F6EAB"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
