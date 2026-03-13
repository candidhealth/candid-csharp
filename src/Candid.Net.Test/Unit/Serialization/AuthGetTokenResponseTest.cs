using System.Text.Json;
using Candid.Net.Auth.Default;
using Candid.Net.Core;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class AuthGetTokenResponseTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "access_token": "eyJz93a...k4laUWw",
              "expires_in": 86400,
              "token_type": "Bearer"
            }
            """;
        var expectedObject = new AuthGetTokenResponse
        {
            AccessToken = "eyJz93a...k4laUWw",
            ExpiresIn = 86400,
            TokenType = "Bearer",
        };
        var deserializedObject = JsonUtils.Deserialize<AuthGetTokenResponse>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "access_token": "eyJz93a...k4laUWw",
              "expires_in": 86400,
              "token_type": "Bearer"
            }
            """;
        var actualObj = new AuthGetTokenResponse
        {
            AccessToken = "eyJz93a...k4laUWw",
            ExpiresIn = 86400,
            TokenType = "Bearer",
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
