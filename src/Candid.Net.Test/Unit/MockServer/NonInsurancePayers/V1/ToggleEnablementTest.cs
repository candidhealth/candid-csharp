using global::Candid.Net.NonInsurancePayers.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.NonInsurancePayers.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ToggleEnablementTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "enabled": true
            }
            """;

        const string mockResponse = """
            {
              "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "name": "name",
              "description": "description",
              "category": "category",
              "enabled": true,
              "address": {
                "zip_plus_four_code": "zip_plus_four_code",
                "address1": "address1",
                "address2": "address2",
                "city": "city",
                "state": "AA",
                "zip_code": "zip_code"
              },
              "clinical_trials": [
                {
                  "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "is_active": true,
                  "name": "name",
                  "clinical_trial_number": "clinical_trial_number",
                  "clinical_trial_phase": "Phase 1"
                },
                {
                  "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "is_active": true,
                  "name": "name",
                  "clinical_trial_number": "clinical_trial_number",
                  "clinical_trial_phase": "Phase 1"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/non-insurance-payers/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/toggle_enablement"
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

        var response = await Client.NonInsurancePayers.V1.ToggleEnablementAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new ToggleNonInsurancePayerEnablementRequest { Enabled = true }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
