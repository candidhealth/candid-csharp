using global::Candid.Net.Commons;
using global::Candid.Net.CustomSchemas.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.CustomSchemas.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "General Medicine and Health",
              "description": "Values collected during all visits",
              "fields_to_add": [
                {
                  "key": "visit_type",
                  "type": "STRING"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "ec096b13-f80a-471d-aaeb-54b021c9d582",
              "name": "General Medicine and Health",
              "description": "Values collected during all visits",
              "fields": [
                {
                  "key": "provider_category",
                  "type": "STRING"
                },
                {
                  "key": "is_urgent_care",
                  "type": "BOOLEAN"
                },
                {
                  "key": "bmi",
                  "type": "DOUBLE"
                },
                {
                  "key": "age",
                  "type": "INTEGER"
                },
                {
                  "key": "visit_type",
                  "type": "STRING"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/custom-schemas/v1/ec096b13-f80a-471d-aaeb-54b021c9d582")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.CustomSchemas.V1.UpdateAsync(
            "ec096b13-f80a-471d-aaeb-54b021c9d582",
            new SchemaUpdate
            {
                Name = "General Medicine and Health",
                Description = "Values collected during all visits",
                FieldsToAdd = new List<SchemaField>()
                {
                    new SchemaField { Key = "visit_type", Type = Primitive.String },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
