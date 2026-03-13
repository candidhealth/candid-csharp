using Candid.Net.OrganizationServiceFacilities.V2;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.OrganizationServiceFacilities.V2;

[TestFixture]
public class GetMultiTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "organization_service_facility_id": "30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569",
                  "name": "Test Service Facility",
                  "aliases": [
                    "Test Service Facility Alias"
                  ],
                  "description": "Test Service Facility Description",
                  "status": "active",
                  "operational_status": "C",
                  "mode": "instance",
                  "type": "DX",
                  "physical_type": "si",
                  "telecoms": [
                    "555-555-5555"
                  ],
                  "address": {
                    "address1": "123 Main St",
                    "address2": "Apt 1",
                    "city": "New York",
                    "state": "NY",
                    "zip_code": "10001",
                    "zip_plus_four_code": "1234"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/organization-service-facilities/v2")
                    .WithParam("limit", "100")
                    .WithParam("name", "Test Service Facility")
                    .WithParam("page_token", "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.OrganizationServiceFacilities.V2.GetMultiAsync(
            new GetAllOrganizationServiceFacilitiesRequest
            {
                Limit = 100,
                Name = "Test Service Facility",
                PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
