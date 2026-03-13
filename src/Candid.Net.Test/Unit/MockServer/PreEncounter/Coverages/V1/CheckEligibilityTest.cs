using Candid.Net.PreEncounter.Coverages.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Coverages.V1;

[TestFixture]
public class CheckEligibilityTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "service_code": "1",
              "date_of_service": "2023-01-15",
              "npi": "npi"
            }
            """;

        const string mockResponse = """
            {
              "check_id": "check_id",
              "service_code": "1",
              "status": "COMPLETED",
              "initiated_by": "initiated_by",
              "initiated_at": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/coverages/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/eligibility")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Coverages.V1.CheckEligibilityAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new CheckEligibilityRequest
            {
                ServiceCode = ServiceTypeCode.MedicalCare,
                DateOfService = new DateOnly(2023, 1, 15),
                Npi = "npi",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
