using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.OrganizationProviders.V2;

[JsonConverter(typeof(StringEnumSerializer<LicenseType>))]
[Serializable]
public readonly record struct LicenseType : IStringEnum
{
    public static readonly LicenseType Md = new(Values.Md);

    public static readonly LicenseType Np = new(Values.Np);

    public static readonly LicenseType Pa = new(Values.Pa);

    public static readonly LicenseType Lmft = new(Values.Lmft);

    public static readonly LicenseType Lcpc = new(Values.Lcpc);

    public static readonly LicenseType Lcsw = new(Values.Lcsw);

    public static readonly LicenseType Pmhnp = new(Values.Pmhnp);

    public static readonly LicenseType Fnp = new(Values.Fnp);

    public static readonly LicenseType Lpcc = new(Values.Lpcc);

    public static readonly LicenseType Do = new(Values.Do);

    public static readonly LicenseType Rd = new(Values.Rd);

    public static readonly LicenseType Slp = new(Values.Slp);

    public static readonly LicenseType Aprn = new(Values.Aprn);

    public static readonly LicenseType Lpc = new(Values.Lpc);

    public static readonly LicenseType Phd = new(Values.Phd);

    public static readonly LicenseType Psyd = new(Values.Psyd);

    public static readonly LicenseType Lmsw = new(Values.Lmsw);

    public static readonly LicenseType Lmhc = new(Values.Lmhc);

    public static readonly LicenseType OtherMasters = new(Values.OtherMasters);

    public static readonly LicenseType Bcba = new(Values.Bcba);

    public static readonly LicenseType Unknown = new(Values.Unknown);

    public static readonly LicenseType Rph = new(Values.Rph);

    public static readonly LicenseType Pht = new(Values.Pht);

    public static readonly LicenseType Lac = new(Values.Lac);

    public static readonly LicenseType Lmt = new(Values.Lmt);

    public static readonly LicenseType Dc = new(Values.Dc);

    public static readonly LicenseType Nd = new(Values.Nd);

    public static readonly LicenseType Ma = new(Values.Ma);

    public static readonly LicenseType Pt = new(Values.Pt);

    public static readonly LicenseType Ibclc = new(Values.Ibclc);

    public static readonly LicenseType Rn = new(Values.Rn);

    public static readonly LicenseType Dpt = new(Values.Dpt);

    public static readonly LicenseType Lcmhc = new(Values.Lcmhc);

    public static readonly LicenseType Cnm = new(Values.Cnm);

    public static readonly LicenseType Rnfa = new(Values.Rnfa);

    public static readonly LicenseType Acsw = new(Values.Acsw);

    public static readonly LicenseType Apc = new(Values.Apc);

    public static readonly LicenseType Bcaba = new(Values.Bcaba);

    public static readonly LicenseType Bha = new(Values.Bha);

    public static readonly LicenseType Od = new(Values.Od);

    public static readonly LicenseType Dpm = new(Values.Dpm);

    public static readonly LicenseType Da = new(Values.Da);

    public static readonly LicenseType Dds = new(Values.Dds);

    public static readonly LicenseType Deh = new(Values.Deh);

    public static readonly LicenseType Dmd = new(Values.Dmd);

    public static readonly LicenseType Pta = new(Values.Pta);

    public static readonly LicenseType Lcadc = new(Values.Lcadc);

    public static readonly LicenseType Lcat = new(Values.Lcat);

    public static readonly LicenseType Lcmhcs = new(Values.Lcmhcs);

    public static readonly LicenseType Lcmhca = new(Values.Lcmhca);

    public static readonly LicenseType Lcswa = new(Values.Lcswa);

    public static readonly LicenseType Licsw = new(Values.Licsw);

    public static readonly LicenseType Lisw = new(Values.Lisw);

    public static readonly LicenseType Lmfts = new(Values.Lmfts);

    public static readonly LicenseType Lmfta = new(Values.Lmfta);

    public static readonly LicenseType Lpci = new(Values.Lpci);

    public static readonly LicenseType Lscsw = new(Values.Lscsw);

    public static readonly LicenseType Mhca = new(Values.Mhca);

    public static readonly LicenseType Mht = new(Values.Mht);

    public static readonly LicenseType Rbt = new(Values.Rbt);

    public static readonly LicenseType Rcswi = new(Values.Rcswi);

    public static readonly LicenseType Rhmci = new(Values.Rhmci);

    public static readonly LicenseType Lpn = new(Values.Lpn);

    public static readonly LicenseType Otd = new(Values.Otd);

    public static readonly LicenseType Oms = new(Values.Oms);

    public static readonly LicenseType Mfta = new(Values.Mfta);

    public static readonly LicenseType Apcc = new(Values.Apcc);

    public static readonly LicenseType Dnp = new(Values.Dnp);

    public static readonly LicenseType Agnpbc = new(Values.Agnpbc);

    public static readonly LicenseType Anp = new(Values.Anp);

    public static readonly LicenseType Fnppp = new(Values.Fnppp);

    public static readonly LicenseType Lcswr = new(Values.Lcswr);

    public static readonly LicenseType Alc = new(Values.Alc);

    public static readonly LicenseType Rmfti = new(Values.Rmfti);

    public static readonly LicenseType Lamft = new(Values.Lamft);

    public static readonly LicenseType Lpca = new(Values.Lpca);

    public static readonly LicenseType Lswi = new(Values.Lswi);

    public static readonly LicenseType Csw = new(Values.Csw);

    public static readonly LicenseType Cpc = new(Values.Cpc);

    public static readonly LicenseType Lgmft = new(Values.Lgmft);

    public static readonly LicenseType Llpc = new(Values.Llpc);

    public static readonly LicenseType Plpc = new(Values.Plpc);

    public static readonly LicenseType Plmft = new(Values.Plmft);

    public static readonly LicenseType Lmhca = new(Values.Lmhca);

    public static readonly LicenseType Cit = new(Values.Cit);

    public static readonly LicenseType Ct = new(Values.Ct);

    public static readonly LicenseType Mft = new(Values.Mft);

    public static readonly LicenseType Lsw = new(Values.Lsw);

    public static readonly LicenseType Plmhp = new(Values.Plmhp);

    public static readonly LicenseType Pcmsw = new(Values.Pcmsw);

    public static readonly LicenseType Lmhp = new(Values.Lmhp);

    public static readonly LicenseType Otrl = new(Values.Otrl);

    public static readonly LicenseType Rpa = new(Values.Rpa);

    public static readonly LicenseType Cota = new(Values.Cota);

    public static readonly LicenseType Crnp = new(Values.Crnp);

    public static readonly LicenseType SlpCf = new(Values.SlpCf);

    public static readonly LicenseType NpC = new(Values.NpC);

    public static readonly LicenseType PaC = new(Values.PaC);

    public static readonly LicenseType Amft = new(Values.Amft);

    public static readonly LicenseType Cdn = new(Values.Cdn);

    public static readonly LicenseType Cns = new(Values.Cns);

    public static readonly LicenseType Mdphd = new(Values.Mdphd);

    public static readonly LicenseType Aud = new(Values.Aud);

    public static readonly LicenseType Atc = new(Values.Atc);

    public static readonly LicenseType Lat = new(Values.Lat);

    public LicenseType(string value)
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
    public static LicenseType FromCustom(string value)
    {
        return new LicenseType(value);
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

    public static bool operator ==(LicenseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LicenseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LicenseType value) => value.Value;

    public static explicit operator LicenseType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Md = "MD";

        public const string Np = "NP";

        public const string Pa = "PA";

        public const string Lmft = "LMFT";

        public const string Lcpc = "LCPC";

        public const string Lcsw = "LCSW";

        public const string Pmhnp = "PMHNP";

        public const string Fnp = "FNP";

        public const string Lpcc = "LPCC";

        public const string Do = "DO";

        public const string Rd = "RD";

        public const string Slp = "SLP";

        public const string Aprn = "APRN";

        public const string Lpc = "LPC";

        public const string Phd = "PHD";

        public const string Psyd = "PSYD";

        public const string Lmsw = "LMSW";

        public const string Lmhc = "LMHC";

        public const string OtherMasters = "OTHER_MASTERS";

        public const string Bcba = "BCBA";

        public const string Unknown = "UNKNOWN";

        public const string Rph = "RPH";

        public const string Pht = "PHT";

        public const string Lac = "LAC";

        public const string Lmt = "LMT";

        public const string Dc = "DC";

        public const string Nd = "ND";

        public const string Ma = "MA";

        public const string Pt = "PT";

        public const string Ibclc = "IBCLC";

        public const string Rn = "RN";

        public const string Dpt = "DPT";

        public const string Lcmhc = "LCMHC";

        public const string Cnm = "CNM";

        public const string Rnfa = "RNFA";

        public const string Acsw = "ACSW";

        public const string Apc = "APC";

        public const string Bcaba = "BCABA";

        public const string Bha = "BHA";

        public const string Od = "OD";

        public const string Dpm = "DPM";

        public const string Da = "DA";

        public const string Dds = "DDS";

        public const string Deh = "DEH";

        public const string Dmd = "DMD";

        public const string Pta = "PTA";

        public const string Lcadc = "LCADC";

        public const string Lcat = "LCAT";

        public const string Lcmhcs = "LCMHCS";

        public const string Lcmhca = "LCMHCA";

        public const string Lcswa = "LCSWA";

        public const string Licsw = "LICSW";

        public const string Lisw = "LISW";

        public const string Lmfts = "LMFTS";

        public const string Lmfta = "LMFTA";

        public const string Lpci = "LPCI";

        public const string Lscsw = "LSCSW";

        public const string Mhca = "MHCA";

        public const string Mht = "MHT";

        public const string Rbt = "RBT";

        public const string Rcswi = "RCSWI";

        public const string Rhmci = "RHMCI";

        public const string Lpn = "LPN";

        public const string Otd = "OTD";

        public const string Oms = "OMS";

        public const string Mfta = "MFTA";

        public const string Apcc = "APCC";

        public const string Dnp = "DNP";

        public const string Agnpbc = "AGNPBC";

        public const string Anp = "ANP";

        public const string Fnppp = "FNPPP";

        public const string Lcswr = "LCSWR";

        public const string Alc = "ALC";

        public const string Rmfti = "RMFTI";

        public const string Lamft = "LAMFT";

        public const string Lpca = "LPCA";

        public const string Lswi = "LSWI";

        public const string Csw = "CSW";

        public const string Cpc = "CPC";

        public const string Lgmft = "LGMFT";

        public const string Llpc = "LLPC";

        public const string Plpc = "PLPC";

        public const string Plmft = "PLMFT";

        public const string Lmhca = "LMHCA";

        public const string Cit = "CIT";

        public const string Ct = "CT";

        public const string Mft = "MFT";

        public const string Lsw = "LSW";

        public const string Plmhp = "PLMHP";

        public const string Pcmsw = "PCMSW";

        public const string Lmhp = "LMHP";

        public const string Otrl = "OTR/L";

        public const string Rpa = "RPA";

        public const string Cota = "COTA";

        public const string Crnp = "CRNP";

        public const string SlpCf = "SLP-CF";

        public const string NpC = "NP-C";

        public const string PaC = "PA-C";

        public const string Amft = "AMFT";

        public const string Cdn = "CDN";

        public const string Cns = "CNS";

        public const string Mdphd = "MDPHD";

        public const string Aud = "AuD";

        public const string Atc = "ATC";

        public const string Lat = "LAT";
    }
}
