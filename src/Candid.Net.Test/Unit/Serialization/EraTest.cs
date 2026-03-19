using global::Candid.Net.Core;
using global::Candid.Net.Eras;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class EraTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "era_id": "4D844EF1-2253-43CD-A4F1-6DB7E65CB54B",
              "check_number": "CHK12345",
              "check_date": "2023-10-12"
            }
            """;
        var expectedObject = new Era
        {
            EraId = "4D844EF1-2253-43CD-A4F1-6DB7E65CB54B",
            CheckNumber = "CHK12345",
            CheckDate = "2023-10-12",
        };
        var deserializedObject = JsonUtils.Deserialize<Era>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "era_id": "4D844EF1-2253-43CD-A4F1-6DB7E65CB54B",
              "check_number": "CHK12345",
              "check_date": "2023-10-12"
            }
            """;
        JsonAssert.Roundtrips<Era>(inputJson);
    }
}
