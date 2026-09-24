using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using global::System.Globalization;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Eligibility.V2;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateAvailityEligibilityCheckTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "member_id": "member_id",
              "payer_id": "payer_id",
              "provider_npi": "provider_npi",
              "date_of_service": "2024-01-15T09:30:00.000Z",
              "service_type_codes": [
                "service_type_codes",
                "service_type_codes"
              ]
            }
            """;

        const string mockResponse = """
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/eligibility/v2/avality-eligibility-check")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Eligibility.V2.CreateAvailityEligibilityCheckAsync(
            new global::Candid.Net.Eligibility.V2.EligibilityRequest
            {
                MemberId = "member_id",
                PayerId = "payer_id",
                ProviderNpi = "provider_npi",
                DateOfService = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
                ServiceTypeCodes = new List<string>()
                {
                    "service_type_codes",
                    "service_type_codes",
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
