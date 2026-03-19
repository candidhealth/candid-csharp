using global::Candid.Net.Auth.Default;
using global::Candid.Net.Core;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
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
        var inputJson = """
            {
              "access_token": "eyJz93a...k4laUWw",
              "expires_in": 86400,
              "token_type": "Bearer"
            }
            """;
        JsonAssert.Roundtrips<AuthGetTokenResponse>(inputJson);
    }
}
