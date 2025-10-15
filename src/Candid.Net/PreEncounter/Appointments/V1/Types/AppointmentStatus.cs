using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(StringEnumSerializer<AppointmentStatus>))]
[Serializable]
public readonly record struct AppointmentStatus : IStringEnum
{
    public static readonly AppointmentStatus Pending = new(Values.Pending);

    public static readonly AppointmentStatus NotReady = new(Values.NotReady);

    public static readonly AppointmentStatus Ready = new(Values.Ready);

    public static readonly AppointmentStatus CheckedIn = new(Values.CheckedIn);

    public AppointmentStatus(string value)
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
    public static AppointmentStatus FromCustom(string value)
    {
        return new AppointmentStatus(value);
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

    public static bool operator ==(AppointmentStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AppointmentStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AppointmentStatus value) => value.Value;

    public static explicit operator AppointmentStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pending = "PENDING";

        public const string NotReady = "NOT_READY";

        public const string Ready = "READY";

        public const string CheckedIn = "CHECKED_IN";
    }
}
