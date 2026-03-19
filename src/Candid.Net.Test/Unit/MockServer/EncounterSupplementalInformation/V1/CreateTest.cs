using global::Candid.Net.Commons;
using global::Candid.Net.EncounterSupplementalInformation.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.EncounterSupplementalInformation.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "attachment_report_type_code": "03",
              "attachment_transmission_code": "BM",
              "attachment_inclusion": "not_included"
            }
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
                        "/api/encounter-supplemental-information/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.EncounterSupplementalInformation.V1.CreateAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new CreateSupplementalInformationRequest
            {
                AttachmentReportTypeCode = ReportTypeCode.C03,
                AttachmentTransmissionCode = ReportTransmissionCode.Cbm,
                AttachmentInclusion = AttachmentInclusion.NotIncluded,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
