using global::Candid.Net.PreEncounter.Patients.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Patients.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetEligibilityTimelineTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "id": "id",
                  "event_type": "APPOINTMENT_STATUS_CHANGED",
                  "patient_id": "patient_id",
                  "coverage_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "appointment_id": "appointment_id",
                  "appointment_date": "2024-01-15T09:30:00.000Z",
                  "timestamp": "2024-01-15T09:30:00.000Z",
                  "user_id": "user_id",
                  "user_name": "user_name",
                  "payload": {
                    "payload": {
                      "key": "value"
                    }
                  }
                },
                {
                  "id": "id",
                  "event_type": "APPOINTMENT_STATUS_CHANGED",
                  "patient_id": "patient_id",
                  "coverage_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "appointment_id": "appointment_id",
                  "appointment_date": "2024-01-15T09:30:00.000Z",
                  "timestamp": "2024-01-15T09:30:00.000Z",
                  "user_id": "user_id",
                  "user_name": "user_name",
                  "payload": {
                    "payload": {
                      "key": "value"
                    }
                  }
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
                    .WithPath("/patients/v1/id/eligibility-timeline")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Patients.V1.GetEligibilityTimelineAsync(
            "id",
            new GetEligibilityTimelineRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
