using global::Candid.Net.PreEncounter.Common;
using global::Candid.Net.PreEncounter.OrganizationExternalProviders.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.OrganizationExternalProviders.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": {
                "family": "family",
                "given": [
                  "given",
                  "given"
                ],
                "use": "USUAL"
              },
              "types": [
                "REFERRING",
                "REFERRING"
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "organization_id": "organization_id",
              "deactivated": true,
              "version": 1,
              "updated_at": "2024-01-15T09:30:00.000Z",
              "updating_user_id": "updating_user_id",
              "name": {
                "family": "family",
                "given": [
                  "given",
                  "given"
                ],
                "use": "USUAL",
                "period": {
                  "start": "2023-01-15",
                  "end": "2023-01-15"
                },
                "suffix": "suffix"
              },
              "types": [
                "REFERRING",
                "REFERRING"
              ],
              "npi": "npi",
              "tax_id": "tax_id",
              "taxonomy_code": "taxonomy_code",
              "phone_number": "phone_number",
              "other_phone_numbers": [
                "other_phone_numbers",
                "other_phone_numbers"
              ],
              "fax_number": "fax_number",
              "other_fax_numbers": [
                "other_fax_numbers",
                "other_fax_numbers"
              ],
              "emails": [
                "emails",
                "emails"
              ],
              "license_type": "MD",
              "addresses": [
                {
                  "use": "HOME",
                  "line": [
                    "line",
                    "line"
                  ],
                  "city": "city",
                  "state": "state",
                  "postal_code": "postal_code",
                  "country": "country",
                  "county": "county",
                  "period": {
                    "start": "2023-01-15",
                    "end": "2023-01-15"
                  }
                },
                {
                  "use": "HOME",
                  "line": [
                    "line",
                    "line"
                  ],
                  "city": "city",
                  "state": "state",
                  "postal_code": "postal_code",
                  "country": "country",
                  "county": "county",
                  "period": {
                    "start": "2023-01-15",
                    "end": "2023-01-15"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/organization-external-providers/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/version"
                    )
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.OrganizationExternalProviders.V1.UpdateAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            "version",
            new MutableOrganizationExternalProvider
            {
                Name = new HumanName
                {
                    Family = "family",
                    Given = new List<string>() { "given", "given" },
                    Use = NameUse.Usual,
                },
                Types = new List<OrganizationExternalProviderType>()
                {
                    OrganizationExternalProviderType.Referring,
                    OrganizationExternalProviderType.Referring,
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
