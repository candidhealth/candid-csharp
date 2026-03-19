using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.CustomSchemas.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
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
                    .WithPath("/api/custom-schemas/v1/ec096b13-f80a-471d-aaeb-54b021c9d582")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.CustomSchemas.V1.GetAsync(
            "ec096b13-f80a-471d-aaeb-54b021c9d582"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
