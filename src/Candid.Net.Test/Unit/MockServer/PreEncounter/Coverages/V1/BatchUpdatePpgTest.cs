using Candid.Net.PreEncounter.Coverages.V1;
using Candid.Net.Test.Unit.MockServer;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Coverages.V1;

[TestFixture]
public class BatchUpdatePpgTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "payer_id": "payer_id",
              "payer_name": "payer_name",
              "plan_type": "09"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/coverages/v1/batch-update-ppg/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.PreEncounter.Coverages.V1.BatchUpdatePpgAsync(
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                new PayerPlanGroupFields
                {
                    PayerPlanGroupId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    PayerId = "payer_id",
                    PayerName = "payer_name",
                    PlanType = global::Candid.Net.PreEncounter.Coverages.V1.NetworkType.SelfPay,
                }
            )
        );
    }
}
