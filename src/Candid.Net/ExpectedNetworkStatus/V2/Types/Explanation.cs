using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

[JsonConverter(typeof(StringEnumSerializer<Explanation>))]
[Serializable]
public readonly record struct Explanation : IStringEnum
{
    public static readonly Explanation RoutingFailed = new(Values.RoutingFailed);

    public static readonly Explanation PayerMatchFailed = new(Values.PayerMatchFailed);

    public static readonly Explanation BillingProviderMatchFailed = new(
        Values.BillingProviderMatchFailed
    );

    public static readonly Explanation CoveredGeographyMatchFailed = new(
        Values.CoveredGeographyMatchFailed
    );

    public static readonly Explanation LineOfBusinessMatchFailed = new(
        Values.LineOfBusinessMatchFailed
    );

    public static readonly Explanation InsuranceTypeMatchFailed = new(
        Values.InsuranceTypeMatchFailed
    );

    public static readonly Explanation RenderingProviderMatchFailed = new(
        Values.RenderingProviderMatchFailed
    );

    public static readonly Explanation RenderingProviderCredentialingCheckFailed = new(
        Values.RenderingProviderCredentialingCheckFailed
    );

    public Explanation(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static Explanation FromCustom(string value)
    {
        return new Explanation(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(Explanation value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(Explanation value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(Explanation value) => value.Value;

    public static explicit operator Explanation(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string RoutingFailed = "Payer Routing and/or Billing Provider Routing Failed";

        public const string PayerMatchFailed = "No Effective Contract with Payer";

        public const string BillingProviderMatchFailed =
            "No Effective Contract with Billing Provider";

        public const string CoveredGeographyMatchFailed =
            "No Effective Contract with Covered Geography";

        public const string LineOfBusinessMatchFailed =
            "No Effective Contract with Line of Business";

        public const string InsuranceTypeMatchFailed = "No Effective Contract with Insurance Type";

        public const string RenderingProviderMatchFailed =
            "No Effective Contract with Rendering Provider";

        public const string RenderingProviderCredentialingCheckFailed =
            "Rendering Provider Not Credentialed";
    }
}
