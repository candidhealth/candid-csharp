using Candid.Net.Superbills.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Superbills.V1;

[TestFixture]
public class CreateSuperbillTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "patient_external_id": "patient_external_id",
              "date_range_min": "2023-01-15",
              "date_range_max": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "superbills": [
                {
                  "superbill_id": "superbill_id",
                  "patient_external_id": "patient_external_id",
                  "authed_url": "authed_url",
                  "date_range_min": "2023-01-15",
                  "date_range_max": "2023-01-15",
                  "file_name": "file_name"
                },
                {
                  "superbill_id": "superbill_id",
                  "patient_external_id": "patient_external_id",
                  "authed_url": "authed_url",
                  "date_range_min": "2023-01-15",
                  "date_range_max": "2023-01-15",
                  "file_name": "file_name"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/superbill/v1")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Superbills.V1.CreateSuperbillAsync(
            new CreateSuperbillRequest
            {
                PatientExternalId = "patient_external_id",
                DateRangeMin = new DateOnly(2023, 1, 15),
                DateRangeMax = new DateOnly(2023, 1, 15),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
