using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Users.V2;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class UserV2Test
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "user_id": "1503a782-35f6-45a7-b5c3-53ca2ebe8887",
              "idp_metadata": [
                {
                  "type": "auth_zero_metadata",
                  "auth0_id": "auth0|5f9b3b5a7b0b0d006a2b0b0b"
                }
              ],
              "primary_organization_id": "83a2a782-35f6-45a7-b5c3-53ca2ebe8887",
              "user_metadata": {
                "type": "human_user_metadata",
                "first_name": "John",
                "last_name": "Doe",
                "email": "john.doe@example.com"
              }
            }
            """;
        var expectedObject = new UserV2
        {
            UserId = "1503a782-35f6-45a7-b5c3-53ca2ebe8887",
            IdpMetadata = new List<IdpUserMetadata>()
            {
                new IdpUserMetadata(
                    new IdpUserMetadata.AuthZeroMetadata(
                        new AuthZeroMetadata { Auth0Id = "auth0|5f9b3b5a7b0b0d006a2b0b0b" }
                    )
                ),
            },
            PrimaryOrganizationId = "83a2a782-35f6-45a7-b5c3-53ca2ebe8887",
            UserMetadata = new UserMetadata(
                new UserMetadata.HumanUserMetadata(
                    new HumanUserMetadata
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "john.doe@example.com",
                    }
                )
            ),
        };
        var deserializedObject = JsonUtils.Deserialize<UserV2>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "user_id": "1503a782-35f6-45a7-b5c3-53ca2ebe8887",
              "idp_metadata": [
                {
                  "type": "auth_zero_metadata",
                  "auth0_id": "auth0|5f9b3b5a7b0b0d006a2b0b0b"
                }
              ],
              "primary_organization_id": "83a2a782-35f6-45a7-b5c3-53ca2ebe8887",
              "user_metadata": {
                "type": "human_user_metadata",
                "first_name": "John",
                "last_name": "Doe",
                "email": "john.doe@example.com"
              }
            }
            """;
        var actualObj = new UserV2
        {
            UserId = "1503a782-35f6-45a7-b5c3-53ca2ebe8887",
            IdpMetadata = new List<IdpUserMetadata>()
            {
                new IdpUserMetadata(
                    new IdpUserMetadata.AuthZeroMetadata(
                        new AuthZeroMetadata { Auth0Id = "auth0|5f9b3b5a7b0b0d006a2b0b0b" }
                    )
                ),
            },
            PrimaryOrganizationId = "83a2a782-35f6-45a7-b5c3-53ca2ebe8887",
            UserMetadata = new UserMetadata(
                new UserMetadata.HumanUserMetadata(
                    new HumanUserMetadata
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "john.doe@example.com",
                    }
                )
            ),
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
