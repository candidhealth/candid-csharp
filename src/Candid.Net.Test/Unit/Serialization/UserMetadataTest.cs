using global::Candid.Net.Core;
using global::Candid.Net.Test.Utils;
using global::Candid.Net.Users.V2;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UserMetadataTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "type": "human_user_metadata",
              "first_name": "John",
              "last_name": "Doe",
              "email": "john.doe@example.com"
            }
            """;
        var expectedObject = new UserMetadata(
            new UserMetadata.HumanUserMetadata(
                new HumanUserMetadata
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                }
            )
        );
        var deserializedObject = JsonUtils.Deserialize<UserMetadata>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "type": "human_user_metadata",
              "first_name": "John",
              "last_name": "Doe",
              "email": "john.doe@example.com"
            }
            """;
        JsonAssert.Roundtrips<UserMetadata>(inputJson);
    }
}
