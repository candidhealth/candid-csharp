using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.ChargeCaptureBundles.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetSummaryTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "charge_capture_charges_not_linked_to_claims_count": 1,
              "charge_capture_claim_creations_not_started_count": 1,
              "charge_capture_held_claim_creations_count": 1,
              "charge_capture_claim_creations_in_error_count": 1,
              "charge_capture_unresolved_change_count": 1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/charge_capture_claim_creation/v1/all/summary")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.ChargeCaptureBundles.V1.GetSummaryAsync();
        JsonAssert.AreEqual(response, mockResponse);
    }
}
