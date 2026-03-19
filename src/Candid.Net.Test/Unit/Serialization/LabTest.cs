using global::Candid.Net.Core;
using global::Candid.Net.Encounters.V4;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LabTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "name": "Genetic Health Labs",
              "code": "GH12345",
              "code_type": "quest"
            }
            """;
        var expectedObject = new Lab
        {
            Name = "Genetic Health Labs",
            Code = "GH12345",
            CodeType = LabCodeType.Quest,
        };
        var deserializedObject = JsonUtils.Deserialize<Lab>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "name": "Genetic Health Labs",
              "code": "GH12345",
              "code_type": "quest"
            }
            """;
        JsonAssert.Roundtrips<Lab>(inputJson);
    }
}
