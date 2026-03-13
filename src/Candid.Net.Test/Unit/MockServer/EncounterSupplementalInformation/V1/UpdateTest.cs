using Candid.Net.EncounterSupplementalInformation.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.EncounterSupplementalInformation.V1;

[TestFixture]
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
              "supplemental_information_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "attachment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "attachment_report_type_code": "03",
              "attachment_transmission_code": "BM",
              "attachment_control_number": "attachment_control_number",
              "attachment_inclusion": "not_included",
              "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/encounter-supplemental-information/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.EncounterSupplementalInformation.V1.UpdateAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new UpdateSupplementalInformationRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
