using global::Candid.Net.Diagnoses;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Diagnoses;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "diagnosis_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "created_at": "2024-01-15T09:30:00.000Z",
              "updated_at": "2024-01-15T09:30:00.000Z",
              "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "name": "name",
              "code_type": "ABF",
              "code": "code",
              "present_on_admission_indicator": "YES"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/diagnoses/v2/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Diagnoses.UpdateAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new DiagnosisUpdate()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
