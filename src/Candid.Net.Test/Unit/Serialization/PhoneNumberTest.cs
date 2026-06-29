using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PhoneNumberTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "number": "1234567890",
              "type": "Home"
            }
            """;
        var expectedObject = new PhoneNumber { Number = "1234567890", Type = PhoneNumberType.Home };
        var deserializedObject = JsonUtils.Deserialize<PhoneNumber>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "number": "1234567890",
              "type": "Home"
            }
            """;
        JsonAssert.Roundtrips<PhoneNumber>(inputJson);
    }
}
