using global::Candid.Net.Core;
using global::Candid.Net.Test.Utils;
using global::Candid.Net.Users.V2;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AuthZeroMetadataTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "auth0_id": "auth0|5f9b3b5a7b0b0d006a2b0b0b"
            }
            """;
        var expectedObject = new AuthZeroMetadata { Auth0Id = "auth0|5f9b3b5a7b0b0d006a2b0b0b" };
        var deserializedObject = JsonUtils.Deserialize<AuthZeroMetadata>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "auth0_id": "auth0|5f9b3b5a7b0b0d006a2b0b0b"
            }
            """;
        JsonAssert.Roundtrips<AuthZeroMetadata>(inputJson);
    }
}
