using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.OrganizationServiceFacilities.V2;

[TestFixture]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "organization_service_facility_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "name": "name",
              "aliases": [
                "aliases",
                "aliases"
              ],
              "description": "description",
              "external_id": "external_id",
              "npi": "npi",
              "place_of_service_code": "01",
              "clia_number": "clia_number",
              "mammography_certification_number": "mammography_certification_number",
              "status": "active",
              "operational_status": "C",
              "mode": "instance",
              "type": "DX",
              "physical_type": "si",
              "telecoms": [
                "telecoms",
                "telecoms"
              ],
              "address": {
                "zip_plus_four_code": "zip_plus_four_code",
                "address1": "address1",
                "address2": "address2",
                "city": "city",
                "state": "AA",
                "zip_code": "zip_code"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/organization-service-facilities/v2/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.OrganizationServiceFacilities.V2.GetAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
