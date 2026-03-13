using Candid.Net.Commons;
using Candid.Net.FeeSchedules.V3;
using Candid.Net.OrganizationProviders.V2;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.FeeSchedules.V3;

[TestFixture]
public class HardDeleteRatesTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "states": [
                "AA"
              ],
              "zip_codes": [
                "zip_codes"
              ],
              "license_types": [
                "MD"
              ],
              "facility_type_codes": [
                "01"
              ],
              "network_types": [
                "12"
              ],
              "payer_plan_group_ids": [
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              ],
              "modifiers": [
                "AV"
              ]
            }
            """;

        const string mockResponse = """
            1
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/fee-schedules/v3/hard-delete")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FeeSchedules.V3.HardDeleteRatesAsync(
            new OptionalDimensions
            {
                States = new HashSet<State>() { State.Aa },
                ZipCodes = new HashSet<string>() { "zip_codes" },
                LicenseTypes = new HashSet<LicenseType>() { LicenseType.Md },
                FacilityTypeCodes = new HashSet<FacilityTypeCode>() { FacilityTypeCode.Pharmacy },
                NetworkTypes = new HashSet<global::Candid.Net.Commons.NetworkType>()
                {
                    global::Candid.Net.Commons.NetworkType.Ppo,
                },
                PayerPlanGroupIds = new HashSet<string>()
                {
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                },
                Modifiers = new HashSet<ProcedureModifier>() { ProcedureModifier.Av },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
