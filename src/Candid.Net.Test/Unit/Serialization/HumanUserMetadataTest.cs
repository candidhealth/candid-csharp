using global::Candid.Net.Core;
using global::Candid.Net.Test.Utils;
using global::Candid.Net.Users.V2;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class HumanUserMetadataTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "first_name": "John",
              "last_name": "Doe",
              "email": "john.doe@example.com"
            }
            """;
        var expectedObject = new HumanUserMetadata
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
        };
        var deserializedObject = JsonUtils.Deserialize<HumanUserMetadata>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "first_name": "John",
              "last_name": "Doe",
              "email": "john.doe@example.com"
            }
            """;
        JsonAssert.Roundtrips<HumanUserMetadata>(inputJson);
    }
}
