using global::Candid.Net.Contracts.V3;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Contracts.V3;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateContractServiceFacilityTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {}
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
                        "/api/contracts/v3/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/service-facilities/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
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

        var response = await Client.Contracts.V3.UpdateContractServiceFacilityAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new ContractServiceFacilityUpdate()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
