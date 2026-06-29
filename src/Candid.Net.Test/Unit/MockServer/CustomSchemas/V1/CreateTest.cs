using global::Candid.Net.Commons;
using global::Candid.Net.CustomSchemas.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.CustomSchemas.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "General Medicine",
              "description": "Values associated with a generic visit",
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
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "ec096b13-f80a-471d-aaeb-54b021c9d582",
              "name": "General Medicine",
              "description": "Values associated with a generic visit",
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
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/custom-schemas/v1")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.CustomSchemas.V1.CreateAsync(
            new SchemaCreate
            {
                Name = "General Medicine",
                Description = "Values associated with a generic visit",
                Fields = new List<SchemaField>()
                {
                    new SchemaField { Key = "provider_category", Type = Primitive.String },
                    new SchemaField { Key = "is_urgent_care", Type = Primitive.Boolean },
                    new SchemaField { Key = "bmi", Type = Primitive.Double },
                    new SchemaField { Key = "age", Type = Primitive.Integer },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
