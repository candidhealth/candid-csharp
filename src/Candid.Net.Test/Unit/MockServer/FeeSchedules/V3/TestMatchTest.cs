using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.FeeSchedules.V3;

[TestFixture]
public class TestMatchTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "dimensions": {
                "payer": {
                  "value": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "match": true,
                  "explanation": "explanation"
                },
                "geography": {
                  "zip_code": "zip_code",
                  "state": "AA",
                  "match": true,
                  "explanation": "explanation"
                },
                "organization_billing_provider": {
                  "value": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "match": true,
                  "explanation": "explanation"
                },
                "date_of_service": {
                  "value": "2023-01-15",
                  "match": true,
                  "explanation": "explanation"
                },
                "cpt_code": {
                  "value": "value",
                  "match": true,
                  "explanation": "explanation"
                },
                "modifiers": {
                  "value": [
                    "AV"
                  ],
                  "match": true,
                  "explanation": "explanation"
                },
                "license_type": {
                  "value": "MD",
                  "match": true,
                  "explanation": "explanation"
                },
                "facility_type_code": {
                  "value": "01",
                  "match": true,
                  "explanation": "explanation"
                },
                "network_types": {
                  "value": [
                    "12"
                  ],
                  "match": true,
                  "explanation": "explanation"
                },
                "payer_plan_groups": {
                  "value": [
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  ],
                  "match": true,
                  "explanation": "explanation"
                }
              },
              "threshold": {
                "threshold": {
                  "upper_threshold_cents": 1,
                  "lower_threshold_cents": 1,
                  "disable_paid_incorrectly": true
                },
                "rate_cents": 1,
                "match": true,
                "explanation": "explanation"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/fee-schedules/v3/service-line/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/match/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FeeSchedules.V3.TestMatchAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
