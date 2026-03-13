using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Eras;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
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
        var expectedJson = """
            {
              "era_id": "4D844EF1-2253-43CD-A4F1-6DB7E65CB54B",
              "check_number": "CHK12345",
              "check_date": "2023-10-12"
            }
            """;
        var actualObj = new Era
        {
            EraId = "4D844EF1-2253-43CD-A4F1-6DB7E65CB54B",
            CheckNumber = "CHK12345",
            CheckDate = "2023-10-12",
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
