using Candid.Net.NonInsurancePayers.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.NonInsurancePayers.V1;

[TestFixture]
public class GetCategoriesTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                "items",
                "items"
              ],
              "prev_page_token": "prev_page_token",
              "next_page_token": "next_page_token"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/non-insurance-payers/v1/categories")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.NonInsurancePayers.V1.GetCategoriesAsync(
            new GetNonInsurancePayersCategoriesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
