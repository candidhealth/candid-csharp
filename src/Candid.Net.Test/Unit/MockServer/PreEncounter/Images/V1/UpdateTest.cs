using global::Candid.Net.PreEncounter.Images.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Images.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "file_name": "file_name",
              "display_name": "display_name",
              "file_type": "file_type",
              "status": "PENDING"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "signed_url": "signed_url",
              "organization_id": "organization_id",
              "deactivated": true,
              "version": 1,
              "updated_at": "2024-01-15T09:30:00.000Z",
              "updating_user_id": "updating_user_id",
              "file_name": "file_name",
              "display_name": "display_name",
              "file_type": "file_type",
              "status": "PENDING",
              "coverage": {
                "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "side": "FRONT"
              },
              "patient": {
                "id": "id",
                "notes": "notes"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/images/v1/id/version")
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Images.V1.UpdateAsync(
            "id",
            "version",
            new MutableImage
            {
                FileName = "file_name",
                DisplayName = "display_name",
                FileType = "file_type",
                Status = ImageStatus.Pending,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
