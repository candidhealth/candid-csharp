using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<State>))]
public enum State
{
    [EnumMember(Value = "AA")]
    Aa,

    [EnumMember(Value = "AE")]
    Ae,

    [EnumMember(Value = "AP")]
    Ap,

    [EnumMember(Value = "AL")]
    Al,

    [EnumMember(Value = "AK")]
    Ak,

    [EnumMember(Value = "AS")]
    As,

    [EnumMember(Value = "AZ")]
    Az,

    [EnumMember(Value = "AR")]
    Ar,

    [EnumMember(Value = "CA")]
    Ca,

    [EnumMember(Value = "CO")]
    Co,

    [EnumMember(Value = "CT")]
    Ct,

    [EnumMember(Value = "DC")]
    Dc,

    [EnumMember(Value = "DE")]
    De,

    [EnumMember(Value = "FL")]
    Fl,

    [EnumMember(Value = "FM")]
    Fm,

    [EnumMember(Value = "GA")]
    Ga,

    [EnumMember(Value = "GU")]
    Gu,

    [EnumMember(Value = "HI")]
    Hi,

    [EnumMember(Value = "ID")]
    Id,

    [EnumMember(Value = "IL")]
    Il,

    [EnumMember(Value = "IN")]
    In,

    [EnumMember(Value = "IA")]
    Ia,

    [EnumMember(Value = "KS")]
    Ks,

    [EnumMember(Value = "KY")]
    Ky,

    [EnumMember(Value = "LA")]
    La,

    [EnumMember(Value = "ME")]
    Me,

    [EnumMember(Value = "MD")]
    Md,

    [EnumMember(Value = "MA")]
    Ma,

    [EnumMember(Value = "MH")]
    Mh,

    [EnumMember(Value = "MI")]
    Mi,

    [EnumMember(Value = "MN")]
    Mn,

    [EnumMember(Value = "MP")]
    Mp,

    [EnumMember(Value = "MS")]
    Ms,

    [EnumMember(Value = "MO")]
    Mo,

    [EnumMember(Value = "MT")]
    Mt,

    [EnumMember(Value = "NE")]
    Ne,

    [EnumMember(Value = "NV")]
    Nv,

    [EnumMember(Value = "NH")]
    Nh,

    [EnumMember(Value = "NJ")]
    Nj,

    [EnumMember(Value = "NM")]
    Nm,

    [EnumMember(Value = "NY")]
    Ny,

    [EnumMember(Value = "NC")]
    Nc,

    [EnumMember(Value = "ND")]
    Nd,

    [EnumMember(Value = "OH")]
    Oh,

    [EnumMember(Value = "OK")]
    Ok,

    [EnumMember(Value = "OR")]
    Or,

    [EnumMember(Value = "PA")]
    Pa,

    [EnumMember(Value = "PR")]
    Pr,

    [EnumMember(Value = "PW")]
    Pw,

    [EnumMember(Value = "RI")]
    Ri,

    [EnumMember(Value = "SC")]
    Sc,

    [EnumMember(Value = "SD")]
    Sd,

    [EnumMember(Value = "TN")]
    Tn,

    [EnumMember(Value = "TX")]
    Tx,

    [EnumMember(Value = "UT")]
    Ut,

    [EnumMember(Value = "VI")]
    Vi,

    [EnumMember(Value = "VT")]
    Vt,

    [EnumMember(Value = "VA")]
    Va,

    [EnumMember(Value = "WA")]
    Wa,

    [EnumMember(Value = "WV")]
    Wv,

    [EnumMember(Value = "WI")]
    Wi,

    [EnumMember(Value = "WY")]
    Wy
}
