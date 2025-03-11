using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationProviders.V2;

[JsonConverter(typeof(EnumSerializer<LicenseType>))]
public enum LicenseType
{
    [EnumMember(Value = "MD")]
    Md,

    [EnumMember(Value = "NP")]
    Np,

    [EnumMember(Value = "PA")]
    Pa,

    [EnumMember(Value = "LMFT")]
    Lmft,

    [EnumMember(Value = "LCPC")]
    Lcpc,

    [EnumMember(Value = "LCSW")]
    Lcsw,

    [EnumMember(Value = "PMHNP")]
    Pmhnp,

    [EnumMember(Value = "FNP")]
    Fnp,

    [EnumMember(Value = "LPCC")]
    Lpcc,

    [EnumMember(Value = "DO")]
    Do,

    [EnumMember(Value = "RD")]
    Rd,

    [EnumMember(Value = "SLP")]
    Slp,

    [EnumMember(Value = "APRN")]
    Aprn,

    [EnumMember(Value = "LPC")]
    Lpc,

    [EnumMember(Value = "PHD")]
    Phd,

    [EnumMember(Value = "PSYD")]
    Psyd,

    [EnumMember(Value = "LMSW")]
    Lmsw,

    [EnumMember(Value = "LMHC")]
    Lmhc,

    [EnumMember(Value = "OTHER_MASTERS")]
    OtherMasters,

    [EnumMember(Value = "BCBA")]
    Bcba,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    [EnumMember(Value = "RPH")]
    Rph,

    [EnumMember(Value = "PHT")]
    Pht,

    [EnumMember(Value = "LAC")]
    Lac,

    [EnumMember(Value = "LMT")]
    Lmt,

    [EnumMember(Value = "DC")]
    Dc,

    [EnumMember(Value = "ND")]
    Nd,

    [EnumMember(Value = "MA")]
    Ma,

    [EnumMember(Value = "PT")]
    Pt,

    [EnumMember(Value = "IBCLC")]
    Ibclc,

    [EnumMember(Value = "RN")]
    Rn,

    [EnumMember(Value = "DPT")]
    Dpt,

    [EnumMember(Value = "LCMHC")]
    Lcmhc,

    [EnumMember(Value = "CNM")]
    Cnm,

    [EnumMember(Value = "RNFA")]
    Rnfa,

    [EnumMember(Value = "ACSW")]
    Acsw,

    [EnumMember(Value = "APC")]
    Apc,

    [EnumMember(Value = "BCABA")]
    Bcaba,

    [EnumMember(Value = "BHA")]
    Bha,

    [EnumMember(Value = "OD")]
    Od,

    [EnumMember(Value = "DPM")]
    Dpm,

    [EnumMember(Value = "DA")]
    Da,

    [EnumMember(Value = "DDS")]
    Dds,

    [EnumMember(Value = "DEH")]
    Deh,

    [EnumMember(Value = "DMD")]
    Dmd,

    [EnumMember(Value = "PTA")]
    Pta,

    [EnumMember(Value = "LCADC")]
    Lcadc,

    [EnumMember(Value = "LCAT")]
    Lcat,

    [EnumMember(Value = "LCMHCS")]
    Lcmhcs,

    [EnumMember(Value = "LCMHCA")]
    Lcmhca,

    [EnumMember(Value = "LCSWA")]
    Lcswa,

    [EnumMember(Value = "LICSW")]
    Licsw,

    [EnumMember(Value = "LISW")]
    Lisw,

    [EnumMember(Value = "LMFTS")]
    Lmfts,

    [EnumMember(Value = "LMFTA")]
    Lmfta,

    [EnumMember(Value = "LPCI")]
    Lpci,

    [EnumMember(Value = "LSCSW")]
    Lscsw,

    [EnumMember(Value = "MHCA")]
    Mhca,

    [EnumMember(Value = "MHT")]
    Mht,

    [EnumMember(Value = "RBT")]
    Rbt,

    [EnumMember(Value = "RCSWI")]
    Rcswi,

    [EnumMember(Value = "RHMCI")]
    Rhmci,

    [EnumMember(Value = "LPN")]
    Lpn,

    [EnumMember(Value = "OTD")]
    Otd,

    [EnumMember(Value = "OMS")]
    Oms,

    [EnumMember(Value = "MFTA")]
    Mfta,

    [EnumMember(Value = "APCC")]
    Apcc,

    [EnumMember(Value = "DNP")]
    Dnp,

    [EnumMember(Value = "AGNPBC")]
    Agnpbc,

    [EnumMember(Value = "ANP")]
    Anp,

    [EnumMember(Value = "FNPPP")]
    Fnppp,

    [EnumMember(Value = "LCSWR")]
    Lcswr,

    [EnumMember(Value = "ALC")]
    Alc,

    [EnumMember(Value = "RMFTI")]
    Rmfti,

    [EnumMember(Value = "LAMFT")]
    Lamft,

    [EnumMember(Value = "LPCA")]
    Lpca,

    [EnumMember(Value = "LSWI")]
    Lswi,

    [EnumMember(Value = "CSW")]
    Csw,

    [EnumMember(Value = "CPC")]
    Cpc,

    [EnumMember(Value = "LGMFT")]
    Lgmft,

    [EnumMember(Value = "LLPC")]
    Llpc,

    [EnumMember(Value = "PLPC")]
    Plpc,

    [EnumMember(Value = "PLMFT")]
    Plmft,

    [EnumMember(Value = "LMHCA")]
    Lmhca,

    [EnumMember(Value = "CIT")]
    Cit,

    [EnumMember(Value = "CT")]
    Ct,

    [EnumMember(Value = "MFT")]
    Mft,

    [EnumMember(Value = "LSW")]
    Lsw,

    [EnumMember(Value = "PLMHP")]
    Plmhp,

    [EnumMember(Value = "PCMSW")]
    Pcmsw,

    [EnumMember(Value = "LMHP")]
    Lmhp,

    [EnumMember(Value = "OTR/L")]
    Otrl,

    [EnumMember(Value = "RPA")]
    Rpa,

    [EnumMember(Value = "COTA")]
    Cota,

    [EnumMember(Value = "CRNP")]
    Crnp,

    [EnumMember(Value = "SLP-CF")]
    SlpCf,

    [EnumMember(Value = "NP-C")]
    NpC,

    [EnumMember(Value = "PA-C")]
    PaC,
}
