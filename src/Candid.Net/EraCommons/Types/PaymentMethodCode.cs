using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EraCommons;

[JsonConverter(typeof(PaymentMethodCode.PaymentMethodCodeSerializer))]
[Serializable]
public readonly record struct PaymentMethodCode : IStringEnum
{
    public static readonly PaymentMethodCode Ach = new(Values.Ach);

    public static readonly PaymentMethodCode Bkw = new(Values.Bkw);

    public static readonly PaymentMethodCode Bop = new(Values.Bop);

    public static readonly PaymentMethodCode Cas = new(Values.Cas);

    public static readonly PaymentMethodCode Ccc = new(Values.Ccc);

    public static readonly PaymentMethodCode Ccf = new(Values.Ccf);

    public static readonly PaymentMethodCode Cch = new(Values.Cch);

    public static readonly PaymentMethodCode Cda = new(Values.Cda);

    public static readonly PaymentMethodCode Chk = new(Values.Chk);

    public static readonly PaymentMethodCode Clh = new(Values.Clh);

    public static readonly PaymentMethodCode Cpc = new(Values.Cpc);

    public static readonly PaymentMethodCode Cwt = new(Values.Cwt);

    public static readonly PaymentMethodCode Dcc = new(Values.Dcc);

    public static readonly PaymentMethodCode Dcd = new(Values.Dcd);

    public static readonly PaymentMethodCode Ddp = new(Values.Ddp);

    public static readonly PaymentMethodCode Deb = new(Values.Deb);

    public static readonly PaymentMethodCode Dlc = new(Values.Dlc);

    public static readonly PaymentMethodCode Dld = new(Values.Dld);

    public static readonly PaymentMethodCode Dxc = new(Values.Dxc);

    public static readonly PaymentMethodCode Dxd = new(Values.Dxd);

    public static readonly PaymentMethodCode Dyc = new(Values.Dyc);

    public static readonly PaymentMethodCode Dyd = new(Values.Dyd);

    public static readonly PaymentMethodCode Dzc = new(Values.Dzc);

    public static readonly PaymentMethodCode Dzd = new(Values.Dzd);

    public static readonly PaymentMethodCode Ebx = new(Values.Ebx);

    public static readonly PaymentMethodCode Exc = new(Values.Exc);

    public static readonly PaymentMethodCode Few = new(Values.Few);

    public static readonly PaymentMethodCode Fwt = new(Values.Fwt);

    public static readonly PaymentMethodCode Fxp = new(Values.Fxp);

    public static readonly PaymentMethodCode Iwt = new(Values.Iwt);

    public static readonly PaymentMethodCode Non = new(Values.Non);

    public static readonly PaymentMethodCode Pac = new(Values.Pac);

    public static readonly PaymentMethodCode Pbd = new(Values.Pbd);

    public static readonly PaymentMethodCode Pdc = new(Values.Pdc);

    public static readonly PaymentMethodCode Pdd = new(Values.Pdd);

    public static readonly PaymentMethodCode Pde = new(Values.Pde);

    public static readonly PaymentMethodCode Pro = new(Values.Pro);

    public static readonly PaymentMethodCode Qdr = new(Values.Qdr);

    public static readonly PaymentMethodCode Qir = new(Values.Qir);

    public static readonly PaymentMethodCode Rev = new(Values.Rev);

    public static readonly PaymentMethodCode Scc = new(Values.Scc);

    public static readonly PaymentMethodCode Scd = new(Values.Scd);

    public static readonly PaymentMethodCode Sdc = new(Values.Sdc);

    public static readonly PaymentMethodCode Sdd = new(Values.Sdd);

    public static readonly PaymentMethodCode Swt = new(Values.Swt);

    public static readonly PaymentMethodCode Sxc = new(Values.Sxc);

    public static readonly PaymentMethodCode Sxd = new(Values.Sxd);

    public static readonly PaymentMethodCode Syc = new(Values.Syc);

    public static readonly PaymentMethodCode Szc = new(Values.Szc);

    public static readonly PaymentMethodCode Szd = new(Values.Szd);

    public PaymentMethodCode(string value)
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
    public static PaymentMethodCode FromCustom(string value)
    {
        return new PaymentMethodCode(value);
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

    public static bool operator ==(PaymentMethodCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PaymentMethodCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PaymentMethodCode value) => value.Value;

    public static explicit operator PaymentMethodCode(string value) => new(value);

    internal class PaymentMethodCodeSerializer : JsonConverter<PaymentMethodCode>
    {
        public override PaymentMethodCode Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new PaymentMethodCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PaymentMethodCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PaymentMethodCode ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new PaymentMethodCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PaymentMethodCode value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Ach = "ACH";

        public const string Bkw = "BKW";

        public const string Bop = "BOP";

        public const string Cas = "CAS";

        public const string Ccc = "CCC";

        public const string Ccf = "CCF";

        public const string Cch = "CCH";

        public const string Cda = "CDA";

        public const string Chk = "CHK";

        public const string Clh = "CLH";

        public const string Cpc = "CPC";

        public const string Cwt = "CWT";

        public const string Dcc = "DCC";

        public const string Dcd = "DCD";

        public const string Ddp = "DDP";

        public const string Deb = "DEB";

        public const string Dlc = "DLC";

        public const string Dld = "DLD";

        public const string Dxc = "DXC";

        public const string Dxd = "DXD";

        public const string Dyc = "DYC";

        public const string Dyd = "DYD";

        public const string Dzc = "DZC";

        public const string Dzd = "DZD";

        public const string Ebx = "EBX";

        public const string Exc = "EXC";

        public const string Few = "FEW";

        public const string Fwt = "FWT";

        public const string Fxp = "FXP";

        public const string Iwt = "IWT";

        public const string Non = "NON";

        public const string Pac = "PAC";

        public const string Pbd = "PBD";

        public const string Pdc = "PDC";

        public const string Pdd = "PDD";

        public const string Pde = "PDE";

        public const string Pro = "PRO";

        public const string Qdr = "QDR";

        public const string Qir = "QIR";

        public const string Rev = "REV";

        public const string Scc = "SCC";

        public const string Scd = "SCD";

        public const string Sdc = "SDC";

        public const string Sdd = "SDD";

        public const string Swt = "SWT";

        public const string Sxc = "SXC";

        public const string Sxd = "SXD";

        public const string Syc = "SYC";

        public const string Szc = "SZC";

        public const string Szd = "SZD";
    }
}
