using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.CustomSchemas.V1;

[TestFixture]
public class GetMultiTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "schemas": [
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/custom-schemas/v1")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.CustomSchemas.V1.GetMultiAsync();
        JsonAssert.AreEqual(response, mockResponse);
    }
}
