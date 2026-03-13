using Candid.Net.Diagnoses;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Diagnoses;

[TestFixture]
public class CreateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "code_type": "ABF",
              "code": "code"
            }
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
                    .WithPath("/api/diagnoses/v2")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Diagnoses.CreateAsync(
            new StandaloneDiagnosisCreate
            {
                EncounterId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                CodeType = DiagnosisTypeCode.Abf,
                Code = "code",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
