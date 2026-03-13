using Candid.Net.Guarantor.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Guarantor.V1;

[TestFixture]
public class UpdateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "guarantor_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "phone_numbers": [
                {
                  "number": "number",
                  "type": "Home"
                },
                {
                  "number": "number",
                  "type": "Home"
                }
              ],
              "phone_consent": true,
              "email": "email",
              "email_consent": true,
              "auto_charge_consent": true,
              "first_name": "first_name",
              "last_name": "last_name",
              "external_id": "external_id",
              "date_of_birth": "2023-01-15",
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
                    .WithPath("/api/guarantors/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Guarantor.V1.UpdateAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new GuarantorUpdate()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
