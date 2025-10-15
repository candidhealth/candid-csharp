using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<DelayReasonCode>))]
[Serializable]
public readonly record struct DelayReasonCode : IStringEnum
{
    /// <summary>
    /// Proof of Eligibility Unknown or Unavailable
    /// </summary>
    public static readonly DelayReasonCode C1 = new(Values.C1);

    /// <summary>
    /// Litigation
    /// </summary>
    public static readonly DelayReasonCode C2 = new(Values.C2);

    /// <summary>
    /// Authorization Delays
    /// </summary>
    public static readonly DelayReasonCode C3 = new(Values.C3);

    /// <summary>
    /// Delay in Certifying Provider
    /// </summary>
    public static readonly DelayReasonCode C4 = new(Values.C4);

    /// <summary>
    /// Delay in Supplying Billing Forms
    /// </summary>
    public static readonly DelayReasonCode C5 = new(Values.C5);

    /// <summary>
    /// Delay in Delivery of Custom-made Appliances
    /// </summary>
    public static readonly DelayReasonCode C6 = new(Values.C6);

    /// <summary>
    /// Third Party Processing Delay
    /// </summary>
    public static readonly DelayReasonCode C7 = new(Values.C7);

    /// <summary>
    /// Delay in Eligibility Determination
    /// </summary>
    public static readonly DelayReasonCode C8 = new(Values.C8);

    /// <summary>
    /// Original Claim Rejected or Denied Due to a Reason Unrelated to the Billing Limitation Rules
    /// </summary>
    public static readonly DelayReasonCode C9 = new(Values.C9);

    /// <summary>
    /// Administration Delay in the Prior Approval Process
    /// </summary>
    public static readonly DelayReasonCode C10 = new(Values.C10);

    /// <summary>
    /// Other
    /// </summary>
    public static readonly DelayReasonCode C11 = new(Values.C11);

    /// <summary>
    /// Natural Disaster
    /// </summary>
    public static readonly DelayReasonCode C15 = new(Values.C15);

    /// <summary>
    /// Lack of Information
    /// </summary>
    public static readonly DelayReasonCode C16 = new(Values.C16);

    /// <summary>
    /// No response to initial request
    /// </summary>
    public static readonly DelayReasonCode C17 = new(Values.C17);

    public DelayReasonCode(string value)
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
    public static DelayReasonCode FromCustom(string value)
    {
        return new DelayReasonCode(value);
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

    public static bool operator ==(DelayReasonCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DelayReasonCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DelayReasonCode value) => value.Value;

    public static explicit operator DelayReasonCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Proof of Eligibility Unknown or Unavailable
        /// </summary>
        public const string C1 = "1";

        /// <summary>
        /// Litigation
        /// </summary>
        public const string C2 = "2";

        /// <summary>
        /// Authorization Delays
        /// </summary>
        public const string C3 = "3";

        /// <summary>
        /// Delay in Certifying Provider
        /// </summary>
        public const string C4 = "4";

        /// <summary>
        /// Delay in Supplying Billing Forms
        /// </summary>
        public const string C5 = "5";

        /// <summary>
        /// Delay in Delivery of Custom-made Appliances
        /// </summary>
        public const string C6 = "6";

        /// <summary>
        /// Third Party Processing Delay
        /// </summary>
        public const string C7 = "7";

        /// <summary>
        /// Delay in Eligibility Determination
        /// </summary>
        public const string C8 = "8";

        /// <summary>
        /// Original Claim Rejected or Denied Due to a Reason Unrelated to the Billing Limitation Rules
        /// </summary>
        public const string C9 = "9";

        /// <summary>
        /// Administration Delay in the Prior Approval Process
        /// </summary>
        public const string C10 = "10";

        /// <summary>
        /// Other
        /// </summary>
        public const string C11 = "11";

        /// <summary>
        /// Natural Disaster
        /// </summary>
        public const string C15 = "15";

        /// <summary>
        /// Lack of Information
        /// </summary>
        public const string C16 = "16";

        /// <summary>
        /// No response to initial request
        /// </summary>
        public const string C17 = "17";
    }
}
