using global::Candid.Net.PreEncounter.MetadataSchemas.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.MetadataSchemas.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "name",
              "fields": [
                {
                  "key": "key",
                  "type": "STRING"
                },
                {
                  "key": "key",
                  "type": "STRING"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "organization_id": "organization_id",
              "deactivated": true,
              "version": 1,
              "updated_at": "2024-01-15T09:30:00.000Z",
              "updating_user_id": "updating_user_id",
              "name": "name",
              "description": "description",
              "fields": [
                {
                  "key": "key",
                  "type": "STRING",
                  "enum_values": [
                    "enum_values",
                    "enum_values"
                  ]
                },
                {
                  "key": "key",
                  "type": "STRING",
                  "enum_values": [
                    "enum_values",
                    "enum_values"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/metadata-schemas/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/version")
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.MetadataSchemas.V1.UpdateAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            "version",
            new MutableMetadataSchema
            {
                Name = "name",
                Fields = new List<MetadataField>()
                {
                    new MetadataField { Key = "key", Type = MetadataFieldType.String },
                    new MetadataField { Key = "key", Type = MetadataFieldType.String },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
