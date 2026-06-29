using global::Candid.Net.PreEncounter.PatientMerges.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using global::System.Globalization;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.PatientMerges.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ScanTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
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
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/patient-merge/v1/updates/scan")
                    .WithParam("since", "2024-01-15T09:30:00.000Z")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.PatientMerges.V1.ScanAsync(
            new PatientMergeScanRequest
            {
                Since = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
