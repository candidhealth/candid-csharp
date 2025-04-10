using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(EnumSerializer<ProcedureModifier>))]
public enum ProcedureModifier
{
    [EnumMember(Value = "AV")]
    Av,

    [EnumMember(Value = "AU")]
    Au,

    [EnumMember(Value = "AW")]
    Aw,

    [EnumMember(Value = "22")]
    TwentyTwo,

    [EnumMember(Value = "23")]
    TwentyThree,

    [EnumMember(Value = "24")]
    TwentyFour,

    [EnumMember(Value = "25")]
    TwentyFive,

    [EnumMember(Value = "26")]
    TwentySix,

    [EnumMember(Value = "27")]
    TwentySeven,

    [EnumMember(Value = "32")]
    ThirtyTwo,

    [EnumMember(Value = "33")]
    ThirtyThree,

    [EnumMember(Value = "47")]
    FortySeven,

    [EnumMember(Value = "50")]
    Fifty,

    [EnumMember(Value = "51")]
    FiftyOne,

    [EnumMember(Value = "52")]
    FiftyTwo,

    [EnumMember(Value = "53")]
    FiftyThree,

    [EnumMember(Value = "54")]
    FiftyFour,

    [EnumMember(Value = "55")]
    FiftyFive,

    [EnumMember(Value = "56")]
    FiftySix,

    [EnumMember(Value = "57")]
    FiftySeven,

    [EnumMember(Value = "58")]
    FiftyEight,

    [EnumMember(Value = "59")]
    FiftyNine,

    [EnumMember(Value = "62")]
    SixtyTwo,

    [EnumMember(Value = "63")]
    SixtyThree,

    [EnumMember(Value = "66")]
    SixtySix,

    [EnumMember(Value = "74")]
    SeventyFour,

    [EnumMember(Value = "76")]
    SeventySix,

    [EnumMember(Value = "77")]
    SeventySeven,

    [EnumMember(Value = "78")]
    SeventyEight,

    [EnumMember(Value = "79")]
    SeventyNine,

    [EnumMember(Value = "80")]
    Eighty,

    [EnumMember(Value = "81")]
    EightyOne,

    [EnumMember(Value = "82")]
    EightyTwo,

    [EnumMember(Value = "90")]
    Ninety,

    [EnumMember(Value = "91")]
    NinetyOne,

    [EnumMember(Value = "92")]
    NinetyTwo,

    [EnumMember(Value = "93")]
    NinetyThree,

    [EnumMember(Value = "95")]
    NinetyFive,

    [EnumMember(Value = "96")]
    NinetySix,

    [EnumMember(Value = "97")]
    NinetySeven,

    [EnumMember(Value = "99")]
    NinetyNine,

    [EnumMember(Value = "A1")]
    A1,

    [EnumMember(Value = "A2")]
    A2,

    [EnumMember(Value = "A3")]
    A3,

    [EnumMember(Value = "A4")]
    A4,

    [EnumMember(Value = "A5")]
    A5,

    [EnumMember(Value = "A6")]
    A6,

    [EnumMember(Value = "A7")]
    A7,

    [EnumMember(Value = "A8")]
    A8,

    [EnumMember(Value = "A9")]
    A9,

    [EnumMember(Value = "AA")]
    Aa,

    [EnumMember(Value = "AB")]
    Ab,

    [EnumMember(Value = "AD")]
    Ad,

    [EnumMember(Value = "AE")]
    Ae,

    [EnumMember(Value = "AF")]
    Af,

    [EnumMember(Value = "AG")]
    Ag,

    [EnumMember(Value = "AH")]
    Ah,

    [EnumMember(Value = "AI")]
    Ai,

    [EnumMember(Value = "AJ")]
    Aj,

    [EnumMember(Value = "AK")]
    Ak,

    [EnumMember(Value = "AM")]
    Am,

    [EnumMember(Value = "AO")]
    Ao,

    [EnumMember(Value = "AP")]
    Ap,

    [EnumMember(Value = "AQ")]
    Aq,

    [EnumMember(Value = "AR")]
    Ar,

    [EnumMember(Value = "AS")]
    As,

    [EnumMember(Value = "AT")]
    At,

    [EnumMember(Value = "AZ")]
    Az,

    [EnumMember(Value = "BA")]
    Ba,

    [EnumMember(Value = "BL")]
    Bl,

    [EnumMember(Value = "BO")]
    Bo,

    [EnumMember(Value = "BP")]
    Bp,

    [EnumMember(Value = "BR")]
    Br,

    [EnumMember(Value = "BU")]
    Bu,

    [EnumMember(Value = "CA")]
    Ca,

    [EnumMember(Value = "CB")]
    Cb,

    [EnumMember(Value = "CC")]
    Cc,

    [EnumMember(Value = "CD")]
    Cd,

    [EnumMember(Value = "CE")]
    Ce,

    [EnumMember(Value = "CF")]
    Cf,

    [EnumMember(Value = "CG")]
    Cg,

    [EnumMember(Value = "CH")]
    Ch,

    [EnumMember(Value = "CI")]
    Ci,

    [EnumMember(Value = "CJ")]
    Cj,

    [EnumMember(Value = "CK")]
    Ck,

    [EnumMember(Value = "CL")]
    Cl,

    [EnumMember(Value = "CM")]
    Cm,

    [EnumMember(Value = "CN")]
    Cn,

    [EnumMember(Value = "CR")]
    Cr,

    [EnumMember(Value = "CS")]
    Cs,

    [EnumMember(Value = "CT")]
    Ct,

    [EnumMember(Value = "CO")]
    Co,

    [EnumMember(Value = "CQ")]
    Cq,

    [EnumMember(Value = "DA")]
    Da,

    [EnumMember(Value = "E1")]
    E1,

    [EnumMember(Value = "E2")]
    E2,

    [EnumMember(Value = "E3")]
    E3,

    [EnumMember(Value = "E4")]
    E4,

    [EnumMember(Value = "EA")]
    Ea,

    [EnumMember(Value = "EB")]
    Eb,

    [EnumMember(Value = "EC")]
    Ec,

    [EnumMember(Value = "ED")]
    Ed,

    [EnumMember(Value = "EE")]
    Ee,

    [EnumMember(Value = "EJ")]
    Ej,

    [EnumMember(Value = "EM")]
    Em,

    [EnumMember(Value = "EP")]
    Ep,

    [EnumMember(Value = "ER")]
    Er,

    [EnumMember(Value = "ET")]
    Et,

    [EnumMember(Value = "EX")]
    Ex,

    [EnumMember(Value = "EY")]
    Ey,

    [EnumMember(Value = "F1")]
    F1,

    [EnumMember(Value = "F2")]
    F2,

    [EnumMember(Value = "F3")]
    F3,

    [EnumMember(Value = "F4")]
    F4,

    [EnumMember(Value = "F5")]
    F5,

    [EnumMember(Value = "F6")]
    F6,

    [EnumMember(Value = "F7")]
    F7,

    [EnumMember(Value = "F8")]
    F8,

    [EnumMember(Value = "F9")]
    F9,

    [EnumMember(Value = "FA")]
    Fa,

    [EnumMember(Value = "FB")]
    Fb,

    [EnumMember(Value = "FC")]
    Fc,

    [EnumMember(Value = "FP")]
    Fp,

    [EnumMember(Value = "FQ")]
    Fq,

    [EnumMember(Value = "FR")]
    Fr,

    [EnumMember(Value = "FS")]
    Fs,

    [EnumMember(Value = "FT")]
    Ft,

    [EnumMember(Value = "FX")]
    Fx,

    [EnumMember(Value = "FY")]
    Fy,

    [EnumMember(Value = "G0")]
    G0,

    [EnumMember(Value = "G1")]
    G1,

    [EnumMember(Value = "G2")]
    G2,

    [EnumMember(Value = "G3")]
    G3,

    [EnumMember(Value = "G4")]
    G4,

    [EnumMember(Value = "G5")]
    G5,

    [EnumMember(Value = "G6")]
    G6,

    [EnumMember(Value = "G7")]
    G7,

    [EnumMember(Value = "G8")]
    G8,

    [EnumMember(Value = "G9")]
    G9,

    [EnumMember(Value = "GA")]
    Ga,

    [EnumMember(Value = "GB")]
    Gb,

    [EnumMember(Value = "GC")]
    Gc,

    [EnumMember(Value = "GE")]
    Ge,

    [EnumMember(Value = "GF")]
    Gf,

    [EnumMember(Value = "GG")]
    Gg,

    [EnumMember(Value = "GH")]
    Gh,

    [EnumMember(Value = "GJ")]
    Gj,

    [EnumMember(Value = "GK")]
    Gk,

    [EnumMember(Value = "GL")]
    Gl,

    [EnumMember(Value = "GM")]
    Gm,

    [EnumMember(Value = "GN")]
    Gn,

    [EnumMember(Value = "GO")]
    Go,

    [EnumMember(Value = "GP")]
    Gp,

    [EnumMember(Value = "GQ")]
    Gq,

    [EnumMember(Value = "GR")]
    Gr,

    [EnumMember(Value = "GS")]
    Gs,

    [EnumMember(Value = "GT")]
    Gt,

    [EnumMember(Value = "GU")]
    Gu,

    [EnumMember(Value = "GV")]
    Gv,

    [EnumMember(Value = "GW")]
    Gw,

    [EnumMember(Value = "GX")]
    Gx,

    [EnumMember(Value = "GY")]
    Gy,

    [EnumMember(Value = "GZ")]
    Gz,

    [EnumMember(Value = "HA")]
    Ha,

    [EnumMember(Value = "HB")]
    Hb,

    [EnumMember(Value = "HC")]
    Hc,

    [EnumMember(Value = "HD")]
    Hd,

    [EnumMember(Value = "HE")]
    He,

    [EnumMember(Value = "HF")]
    Hf,

    [EnumMember(Value = "HG")]
    Hg,

    [EnumMember(Value = "HH")]
    Hh,

    [EnumMember(Value = "HI")]
    Hi,

    [EnumMember(Value = "HJ")]
    Hj,

    [EnumMember(Value = "HK")]
    Hk,

    [EnumMember(Value = "HL")]
    Hl,

    [EnumMember(Value = "HM")]
    Hm,

    [EnumMember(Value = "HN")]
    Hn,

    [EnumMember(Value = "HO")]
    Ho,

    [EnumMember(Value = "HP")]
    Hp,

    [EnumMember(Value = "HQ")]
    Hq,

    [EnumMember(Value = "HR")]
    Hr,

    [EnumMember(Value = "HS")]
    Hs,

    [EnumMember(Value = "HT")]
    Ht,

    [EnumMember(Value = "HU")]
    Hu,

    [EnumMember(Value = "HV")]
    Hv,

    [EnumMember(Value = "HW")]
    Hw,

    [EnumMember(Value = "HX")]
    Hx,

    [EnumMember(Value = "HY")]
    Hy,

    [EnumMember(Value = "HZ")]
    Hz,

    [EnumMember(Value = "J1")]
    J1,

    [EnumMember(Value = "J2")]
    J2,

    [EnumMember(Value = "J3")]
    J3,

    [EnumMember(Value = "J4")]
    J4,

    [EnumMember(Value = "J5")]
    J5,

    [EnumMember(Value = "JA")]
    Ja,

    [EnumMember(Value = "JB")]
    Jb,

    [EnumMember(Value = "JC")]
    Jc,

    [EnumMember(Value = "JD")]
    Jd,

    [EnumMember(Value = "JE")]
    Je,

    [EnumMember(Value = "JG")]
    Jg,

    [EnumMember(Value = "JW")]
    Jw,

    [EnumMember(Value = "JZ")]
    Jz,

    [EnumMember(Value = "K0")]
    K0,

    [EnumMember(Value = "K1")]
    K1,

    [EnumMember(Value = "K2")]
    K2,

    [EnumMember(Value = "K3")]
    K3,

    [EnumMember(Value = "K4")]
    K4,

    [EnumMember(Value = "KA")]
    Ka,

    [EnumMember(Value = "KB")]
    Kb,

    [EnumMember(Value = "KC")]
    Kc,

    [EnumMember(Value = "KD")]
    Kd,

    [EnumMember(Value = "KE")]
    Ke,

    [EnumMember(Value = "KF")]
    Kf,

    [EnumMember(Value = "KG")]
    Kg,

    [EnumMember(Value = "KH")]
    Kh,

    [EnumMember(Value = "KI")]
    Ki,

    [EnumMember(Value = "KJ")]
    Kj,

    [EnumMember(Value = "KK")]
    Kk,

    [EnumMember(Value = "KL")]
    Kl,

    [EnumMember(Value = "KM")]
    Km,

    [EnumMember(Value = "KN")]
    Kn,

    [EnumMember(Value = "KO")]
    Ko,

    [EnumMember(Value = "KP")]
    Kp,

    [EnumMember(Value = "KQ")]
    Kq,

    [EnumMember(Value = "KR")]
    Kr,

    [EnumMember(Value = "KS")]
    Ks,

    [EnumMember(Value = "KT")]
    Kt,

    [EnumMember(Value = "KU")]
    Ku,

    [EnumMember(Value = "KV")]
    Kv,

    [EnumMember(Value = "KW")]
    Kw,

    [EnumMember(Value = "KX")]
    Kx,

    [EnumMember(Value = "KY")]
    Ky,

    [EnumMember(Value = "KZ")]
    Kz,

    [EnumMember(Value = "LC")]
    Lc,

    [EnumMember(Value = "LD")]
    Ld,

    [EnumMember(Value = "LL")]
    Ll,

    [EnumMember(Value = "LM")]
    Lm,

    [EnumMember(Value = "LR")]
    Lr,

    [EnumMember(Value = "LS")]
    Ls,

    [EnumMember(Value = "LT")]
    Lt,

    [EnumMember(Value = "LU")]
    Lu,

    [EnumMember(Value = "M2")]
    M2,

    [EnumMember(Value = "MA")]
    Ma,

    [EnumMember(Value = "MB")]
    Mb,

    [EnumMember(Value = "MC")]
    Mc,

    [EnumMember(Value = "MD")]
    Md,

    [EnumMember(Value = "ME")]
    Me,

    [EnumMember(Value = "MF")]
    Mf,

    [EnumMember(Value = "MG")]
    Mg,

    [EnumMember(Value = "MH")]
    Mh,

    [EnumMember(Value = "MS")]
    Ms,

    [EnumMember(Value = "N1")]
    N1,

    [EnumMember(Value = "N2")]
    N2,

    [EnumMember(Value = "N3")]
    N3,

    [EnumMember(Value = "NB")]
    Nb,

    [EnumMember(Value = "NR")]
    Nr,

    [EnumMember(Value = "NU")]
    Nu,

    [EnumMember(Value = "P1")]
    P1,

    [EnumMember(Value = "P2")]
    P2,

    [EnumMember(Value = "P3")]
    P3,

    [EnumMember(Value = "P4")]
    P4,

    [EnumMember(Value = "P5")]
    P5,

    [EnumMember(Value = "P6")]
    P6,

    [EnumMember(Value = "PA")]
    Pa,

    [EnumMember(Value = "PB")]
    Pb,

    [EnumMember(Value = "PC")]
    Pc,

    [EnumMember(Value = "PD")]
    Pd,

    [EnumMember(Value = "PI")]
    Pi,

    [EnumMember(Value = "PL")]
    Pl,

    [EnumMember(Value = "PM")]
    Pm,

    [EnumMember(Value = "PN")]
    Pn,

    [EnumMember(Value = "PO")]
    Po,

    [EnumMember(Value = "PS")]
    Ps,

    [EnumMember(Value = "PT")]
    Pt,

    [EnumMember(Value = "Q0")]
    Q0,

    [EnumMember(Value = "Q1")]
    Q1,

    [EnumMember(Value = "Q2")]
    Q2,

    [EnumMember(Value = "Q3")]
    Q3,

    [EnumMember(Value = "Q4")]
    Q4,

    [EnumMember(Value = "Q5")]
    Q5,

    [EnumMember(Value = "Q6")]
    Q6,

    [EnumMember(Value = "Q7")]
    Q7,

    [EnumMember(Value = "Q8")]
    Q8,

    [EnumMember(Value = "Q9")]
    Q9,

    [EnumMember(Value = "QA")]
    Qa,

    [EnumMember(Value = "QB")]
    Qb,

    [EnumMember(Value = "QC")]
    Qc,

    [EnumMember(Value = "QD")]
    Qd,

    [EnumMember(Value = "QE")]
    Qe,

    [EnumMember(Value = "QF")]
    Qf,

    [EnumMember(Value = "QG")]
    Qg,

    [EnumMember(Value = "QH")]
    Qh,

    [EnumMember(Value = "QJ")]
    Qj,

    [EnumMember(Value = "QK")]
    Qk,

    [EnumMember(Value = "QL")]
    Ql,

    [EnumMember(Value = "QM")]
    Qm,

    [EnumMember(Value = "QN")]
    Qn,

    [EnumMember(Value = "QP")]
    Qp,

    [EnumMember(Value = "QQ")]
    Qq,

    [EnumMember(Value = "QR")]
    Qr,

    [EnumMember(Value = "QS")]
    Qs,

    [EnumMember(Value = "QT")]
    Qt,

    [EnumMember(Value = "QW")]
    Qw,

    [EnumMember(Value = "QX")]
    Qx,

    [EnumMember(Value = "QY")]
    Qy,

    [EnumMember(Value = "QZ")]
    Qz,

    [EnumMember(Value = "RA")]
    Ra,

    [EnumMember(Value = "RB")]
    Rb,

    [EnumMember(Value = "RC")]
    Rc,

    [EnumMember(Value = "RD")]
    Rd,

    [EnumMember(Value = "RE")]
    Re,

    [EnumMember(Value = "RI")]
    Ri,

    [EnumMember(Value = "RR")]
    Rr,

    [EnumMember(Value = "RT")]
    Rt,

    [EnumMember(Value = "SA")]
    Sa,

    [EnumMember(Value = "SB")]
    Sb,

    [EnumMember(Value = "SC")]
    Sc,

    [EnumMember(Value = "SD")]
    Sd,

    [EnumMember(Value = "SE")]
    Se,

    [EnumMember(Value = "SF")]
    Sf,

    [EnumMember(Value = "SG")]
    Sg,

    [EnumMember(Value = "SH")]
    Sh,

    [EnumMember(Value = "SJ")]
    Sj,

    [EnumMember(Value = "SL")]
    Sl,

    [EnumMember(Value = "SM")]
    Sm,

    [EnumMember(Value = "SN")]
    Sn,

    [EnumMember(Value = "SQ")]
    Sq,

    [EnumMember(Value = "SS")]
    Ss,

    [EnumMember(Value = "ST")]
    St,

    [EnumMember(Value = "SU")]
    Su,

    [EnumMember(Value = "SV")]
    Sv,

    [EnumMember(Value = "SW")]
    Sw,

    [EnumMember(Value = "SY")]
    Sy,

    [EnumMember(Value = "T1")]
    T1,

    [EnumMember(Value = "T2")]
    T2,

    [EnumMember(Value = "T3")]
    T3,

    [EnumMember(Value = "T4")]
    T4,

    [EnumMember(Value = "T5")]
    T5,

    [EnumMember(Value = "T6")]
    T6,

    [EnumMember(Value = "T7")]
    T7,

    [EnumMember(Value = "T8")]
    T8,

    [EnumMember(Value = "T9")]
    T9,

    [EnumMember(Value = "TA")]
    Ta,

    [EnumMember(Value = "TB")]
    Tb,

    [EnumMember(Value = "TC")]
    Tc,

    [EnumMember(Value = "TD")]
    Td,

    [EnumMember(Value = "TE")]
    Te,

    [EnumMember(Value = "TF")]
    Tf,

    [EnumMember(Value = "TG")]
    Tg,

    [EnumMember(Value = "TH")]
    Th,

    [EnumMember(Value = "TJ")]
    Tj,

    [EnumMember(Value = "TK")]
    Tk,

    [EnumMember(Value = "TL")]
    Tl,

    [EnumMember(Value = "TM")]
    Tm,

    [EnumMember(Value = "TN")]
    Tn,

    [EnumMember(Value = "TP")]
    Tp,

    [EnumMember(Value = "TQ")]
    Tq,

    [EnumMember(Value = "TR")]
    Tr,

    [EnumMember(Value = "TS")]
    Ts,

    [EnumMember(Value = "TT")]
    Tt,

    [EnumMember(Value = "TU")]
    Tu,

    [EnumMember(Value = "TV")]
    Tv,

    [EnumMember(Value = "TW")]
    Tw,

    [EnumMember(Value = "U1")]
    U1,

    [EnumMember(Value = "U2")]
    U2,

    [EnumMember(Value = "U3")]
    U3,

    [EnumMember(Value = "U4")]
    U4,

    [EnumMember(Value = "U5")]
    U5,

    [EnumMember(Value = "U6")]
    U6,

    [EnumMember(Value = "U7")]
    U7,

    [EnumMember(Value = "U8")]
    U8,

    [EnumMember(Value = "U9")]
    U9,

    [EnumMember(Value = "UA")]
    Ua,

    [EnumMember(Value = "UB")]
    Ub,

    [EnumMember(Value = "UC")]
    Uc,

    [EnumMember(Value = "UD")]
    Ud,

    [EnumMember(Value = "UE")]
    Ue,

    [EnumMember(Value = "UF")]
    Uf,

    [EnumMember(Value = "UG")]
    Ug,

    [EnumMember(Value = "UH")]
    Uh,

    [EnumMember(Value = "UJ")]
    Uj,

    [EnumMember(Value = "UK")]
    Uk,

    [EnumMember(Value = "UN")]
    Un,

    [EnumMember(Value = "UP")]
    Up,

    [EnumMember(Value = "UQ")]
    Uq,

    [EnumMember(Value = "UR")]
    Ur,

    [EnumMember(Value = "US")]
    Us,

    [EnumMember(Value = "V1")]
    V1,

    [EnumMember(Value = "V2")]
    V2,

    [EnumMember(Value = "V3")]
    V3,

    [EnumMember(Value = "W1")]
    W1,

    [EnumMember(Value = "W2")]
    W2,

    [EnumMember(Value = "W3")]
    W3,

    [EnumMember(Value = "XE")]
    Xe,

    [EnumMember(Value = "XP")]
    Xp,

    [EnumMember(Value = "XS")]
    Xs,

    [EnumMember(Value = "XU")]
    Xu,
}
