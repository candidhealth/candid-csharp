using global::Candid.Net.Dashboarding.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Dashboarding.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class QueryMetricsTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            [
              {
                "metric": "patient_total_balance_v1"
              },
              {
                "metric": "patient_total_balance_v1"
              }
            ]
            """;

        const string mockResponse = """
            {
              "results": [
                {
                  "metric": "patient_total_balance_v1",
                  "value": {
                    "key": "value"
                  },
                  "snapshot": "today",
                  "error": "error"
                },
                {
                  "metric": "patient_total_balance_v1",
                  "value": {
                    "key": "value"
                  },
                  "snapshot": "today",
                  "error": "error"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/dashboarding/v1/metrics")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Dashboarding.V1.QueryMetricsAsync(
            new List<MetricQuery>()
            {
                new MetricQuery { Metric = MetricName.PatientTotalBalanceV1 },
                new MetricQuery { Metric = MetricName.PatientTotalBalanceV1 },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
