using global::Candid.Net.PreEncounter.PatientMerges.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.PatientMerges.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SearchTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "mrns": [
                "mrns",
                "mrns"
              ]
            }
            """;

        const string mockResponse = """
            {
              "items": [
                {
                  "id": "id",
                  "organization_id": "organization_id",
                  "deactivated": true,
                  "version": 1,
                  "updated_at": "2024-01-15T09:30:00.000Z",
                  "updating_user_id": "updating_user_id",
                  "alternative_patient_mrn": "alternative_patient_mrn",
                  "primary_patient_mrn": "primary_patient_mrn"
                },
                {
                  "id": "id",
                  "organization_id": "organization_id",
                  "deactivated": true,
                  "version": 1,
                  "updated_at": "2024-01-15T09:30:00.000Z",
                  "updating_user_id": "updating_user_id",
                  "alternative_patient_mrn": "alternative_patient_mrn",
                  "primary_patient_mrn": "primary_patient_mrn"
                }
              ],
              "next_page_token": "next_page_token",
              "prev_page_token": "prev_page_token",
              "total": 1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/patient-merge/v1/search")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.PatientMerges.V1.SearchAsync(
            new PatientMergeSearchRequest
            {
                Mrns = new List<string>() { "mrns", "mrns" },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
