using Candid.Net.Contracts.V3;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Contracts.V3;

[TestFixture]
public class CreateContractServiceFacilityTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "service_facility_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "provider_ids": [
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              ]
            }
            """;

        const string mockResponse = """
            {
              "contract_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "contract_service_facility_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "service_facility_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "provider_ids": [
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/contracts/v3/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/service-facilities"
                    )
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Contracts.V3.CreateContractServiceFacilityAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new ContractServiceFacilityCreate
            {
                ServiceFacilityId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                ProviderIds = new HashSet<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
