using global::Candid.Net.EncounterProviders.V2;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.EncounterProviders.V2;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateInitialReferringProviderTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "address": {
                "zip_plus_four_code": "zip_plus_four_code",
                "address1": "address1",
                "address2": "address2",
                "city": "city",
                "state": "AA",
                "zip_code": "zip_code"
              },
              "tax_id": "tax_id",
              "npi": "npi",
              "taxonomy_code": "taxonomy_code",
              "qualifier": "DQ",
              "provider_commercial_license_type": "0",
              "secondary_identification": {
                "reference_identification": "reference_identification",
                "reference_identification_qualifier": "0B"
              },
              "first_name": "first_name",
              "last_name": "last_name",
              "organization_name": "organization_name"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/encounter-providers/v2/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/initial-referring-provider"
                    )
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.EncounterProviders.V2.UpdateInitialReferringProviderAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new InitialReferringProviderUpdate()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
