using global::Candid.Net.Commons;
using global::Candid.Net.Core;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class StreetAddressLongZipTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "address1": "123 Main St",
              "address2": "Apt 1",
              "city": "New York",
              "state": "NY",
              "zip_code": "10001",
              "zip_plus_four_code": "1234"
            }
            """;
        var expectedObject = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        };
        var deserializedObject = JsonUtils.Deserialize<StreetAddressLongZip>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "address1": "123 Main St",
              "address2": "Apt 1",
              "city": "New York",
              "state": "NY",
              "zip_code": "10001",
              "zip_plus_four_code": "1234"
            }
            """;
        JsonAssert.Roundtrips<StreetAddressLongZip>(inputJson);
    }
}
