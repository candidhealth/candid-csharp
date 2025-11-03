using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<ProcedureModifier>))]
[Serializable]
public readonly record struct ProcedureModifier : IStringEnum
{
    /// <summary>
    /// Ambulance service provided as a volunteer ambulance service organization as defined by the state
    /// </summary>
    public static readonly ProcedureModifier Av = new(Values.Av);

    /// <summary>
    /// Item furnished in conjunction with a urological, ostomy, or tracheostomy supply
    /// </summary>
    public static readonly ProcedureModifier Au = new(Values.Au);

    /// <summary>
    /// Item furnished in conjunction with dialysis services
    /// </summary>
    public static readonly ProcedureModifier Aw = new(Values.Aw);

    public static readonly ProcedureModifier Seven = new(Values.Seven);

    public static readonly ProcedureModifier Eight = new(Values.Eight);

    public static readonly ProcedureModifier Nine = new(Values.Nine);

    public static readonly ProcedureModifier Ten = new(Values.Ten);

    public static readonly ProcedureModifier Eleven = new(Values.Eleven);

    public static readonly ProcedureModifier Twelve = new(Values.Twelve);

    public static readonly ProcedureModifier Thirteen = new(Values.Thirteen);

    public static readonly ProcedureModifier Fourteen = new(Values.Fourteen);

    public static readonly ProcedureModifier Fifteen = new(Values.Fifteen);

    public static readonly ProcedureModifier Sixteen = new(Values.Sixteen);

    /// <summary>
    /// Increased Procedural Services
    /// </summary>
    public static readonly ProcedureModifier TwentyTwo = new(Values.TwentyTwo);

    /// <summary>
    /// Unusual Anesthesia
    /// </summary>
    public static readonly ProcedureModifier TwentyThree = new(Values.TwentyThree);

    /// <summary>
    /// Unrelated Evaluation and Management Service by the Same Physician or Other Qualified Health Care Professional During a Postoperative Period
    /// </summary>
    public static readonly ProcedureModifier TwentyFour = new(Values.TwentyFour);

    /// <summary>
    /// Significant, Separately Identifiable Evaluation and Management Service by the Same Physician or Other Qualified Health Care Professional on the Same Day of the Procedure or Other Service
    /// </summary>
    public static readonly ProcedureModifier TwentyFive = new(Values.TwentyFive);

    /// <summary>
    /// Professional Component
    /// </summary>
    public static readonly ProcedureModifier TwentySix = new(Values.TwentySix);

    /// <summary>
    /// Multiple Outpatient Hospital E/M Encounters on the Same Date
    /// </summary>
    public static readonly ProcedureModifier TwentySeven = new(Values.TwentySeven);

    public static readonly ProcedureModifier TwentyEight = new(Values.TwentyEight);

    /// <summary>
    /// Mandated Services
    /// </summary>
    public static readonly ProcedureModifier ThirtyTwo = new(Values.ThirtyTwo);

    /// <summary>
    /// Preventive Services
    /// </summary>
    public static readonly ProcedureModifier ThirtyThree = new(Values.ThirtyThree);

    /// <summary>
    /// Anesthesia by Surgeon
    /// </summary>
    public static readonly ProcedureModifier FortySeven = new(Values.FortySeven);

    /// <summary>
    /// Bilateral Procedure
    /// </summary>
    public static readonly ProcedureModifier Fifty = new(Values.Fifty);

    /// <summary>
    /// Multiple Procedures
    /// </summary>
    public static readonly ProcedureModifier FiftyOne = new(Values.FiftyOne);

    /// <summary>
    /// Reduced Services
    /// </summary>
    public static readonly ProcedureModifier FiftyTwo = new(Values.FiftyTwo);

    /// <summary>
    /// Discontinued Procedure
    /// </summary>
    public static readonly ProcedureModifier FiftyThree = new(Values.FiftyThree);

    /// <summary>
    /// Surgical Care Only
    /// </summary>
    public static readonly ProcedureModifier FiftyFour = new(Values.FiftyFour);

    /// <summary>
    /// Postoperative Management Only
    /// </summary>
    public static readonly ProcedureModifier FiftyFive = new(Values.FiftyFive);

    /// <summary>
    /// Preoperative Management Only
    /// </summary>
    public static readonly ProcedureModifier FiftySix = new(Values.FiftySix);

    /// <summary>
    /// Decision for Surgery
    /// </summary>
    public static readonly ProcedureModifier FiftySeven = new(Values.FiftySeven);

    /// <summary>
    /// Staged or Related Procedure or Service by the Same Physician or Other Qualified Health Care Professional During the Postoperative Period
    /// </summary>
    public static readonly ProcedureModifier FiftyEight = new(Values.FiftyEight);

    /// <summary>
    /// Distinct Procedural Service
    /// </summary>
    public static readonly ProcedureModifier FiftyNine = new(Values.FiftyNine);

    /// <summary>
    /// Two Surgeons
    /// </summary>
    public static readonly ProcedureModifier SixtyTwo = new(Values.SixtyTwo);

    /// <summary>
    /// Procedure Performed on Infants less than 4 kg
    /// </summary>
    public static readonly ProcedureModifier SixtyThree = new(Values.SixtyThree);

    /// <summary>
    /// Surgical Team
    /// </summary>
    public static readonly ProcedureModifier SixtySix = new(Values.SixtySix);

    /// <summary>
    /// Discontinued Outpatient Hospital/Ambulatory Surgery Center (ASC) Procedure After Administration of Anesthesia
    /// </summary>
    public static readonly ProcedureModifier SeventyFour = new(Values.SeventyFour);

    /// <summary>
    /// Repeat Procedure or Service by Same Physician or Other Qualified Health Care Professional
    /// </summary>
    public static readonly ProcedureModifier SeventySix = new(Values.SeventySix);

    /// <summary>
    /// Repeat Procedure by Another Physician or Other Qualified Health Care Professional
    /// </summary>
    public static readonly ProcedureModifier SeventySeven = new(Values.SeventySeven);

    /// <summary>
    /// Unplanned Return to the Operating/Procedure Room by the Same Physician or Other Qualified Health Care Professional Following Initial Procedure for a Related Procedure During the Postoperative Period
    /// </summary>
    public static readonly ProcedureModifier SeventyEight = new(Values.SeventyEight);

    /// <summary>
    /// Unrelated Procedure or Service by the Same Physician or Other Qualified Health Care Professional During the Postoperative Period
    /// </summary>
    public static readonly ProcedureModifier SeventyNine = new(Values.SeventyNine);

    /// <summary>
    /// Assistant Surgeon
    /// </summary>
    public static readonly ProcedureModifier Eighty = new(Values.Eighty);

    /// <summary>
    /// Minimum Assistant Surgeon
    /// </summary>
    public static readonly ProcedureModifier EightyOne = new(Values.EightyOne);

    /// <summary>
    /// Assistant Surgeon (when qualified resident surgeon not available)
    /// </summary>
    public static readonly ProcedureModifier EightyTwo = new(Values.EightyTwo);

    /// <summary>
    /// Reference (Outside) Laboratory
    /// </summary>
    public static readonly ProcedureModifier Ninety = new(Values.Ninety);

    /// <summary>
    /// Repeat Clinical Diagnostic Laboratory Test
    /// </summary>
    public static readonly ProcedureModifier NinetyOne = new(Values.NinetyOne);

    /// <summary>
    /// Alternative Laboratory Platform Testing
    /// </summary>
    public static readonly ProcedureModifier NinetyTwo = new(Values.NinetyTwo);

    /// <summary>
    /// Synchronous Telemedicine Service Rendered Via Telephone or Other Real-Time Interactive Audio-Only Telecommunications System
    /// </summary>
    public static readonly ProcedureModifier NinetyThree = new(Values.NinetyThree);

    /// <summary>
    /// Synchronous Telemedicine Service Rendered via a Real-Time Interactive Audio and Video Telecommunications System
    /// </summary>
    public static readonly ProcedureModifier NinetyFive = new(Values.NinetyFive);

    /// <summary>
    /// Habilitative Services
    /// </summary>
    public static readonly ProcedureModifier NinetySix = new(Values.NinetySix);

    /// <summary>
    /// Rehabilitative Services
    /// </summary>
    public static readonly ProcedureModifier NinetySeven = new(Values.NinetySeven);

    /// <summary>
    /// Multiple Modifiers
    /// </summary>
    public static readonly ProcedureModifier NinetyNine = new(Values.NinetyNine);

    /// <summary>
    /// Dressing for one wound
    /// </summary>
    public static readonly ProcedureModifier A1 = new(Values.A1);

    /// <summary>
    /// Dressing for two wounds
    /// </summary>
    public static readonly ProcedureModifier A2 = new(Values.A2);

    /// <summary>
    /// Dressing for three wounds
    /// </summary>
    public static readonly ProcedureModifier A3 = new(Values.A3);

    /// <summary>
    /// Dressing for four wounds
    /// </summary>
    public static readonly ProcedureModifier A4 = new(Values.A4);

    /// <summary>
    /// Dressing for five wounds
    /// </summary>
    public static readonly ProcedureModifier A5 = new(Values.A5);

    /// <summary>
    /// Dressing for six wounds
    /// </summary>
    public static readonly ProcedureModifier A6 = new(Values.A6);

    /// <summary>
    /// Dressing for seven wounds
    /// </summary>
    public static readonly ProcedureModifier A7 = new(Values.A7);

    /// <summary>
    /// Dressing for eight wounds
    /// </summary>
    public static readonly ProcedureModifier A8 = new(Values.A8);

    /// <summary>
    /// Dressing for nine wounds
    /// </summary>
    public static readonly ProcedureModifier A9 = new(Values.A9);

    /// <summary>
    /// Anesthesia services performed personally by anesthesiologist
    /// </summary>
    public static readonly ProcedureModifier Aa = new(Values.Aa);

    /// <summary>
    /// Audiology service furnished personally by an audiologist without a physician/npp order for non-acute hearing assessment ...
    /// </summary>
    public static readonly ProcedureModifier Ab = new(Values.Ab);

    /// <summary>
    /// Medical supervision by a physician: more than four concurrent anesthesia procedures
    /// </summary>
    public static readonly ProcedureModifier Ad = new(Values.Ad);

    /// <summary>
    /// Registered dietician
    /// </summary>
    public static readonly ProcedureModifier Ae = new(Values.Ae);

    /// <summary>
    /// Specialty physician
    /// </summary>
    public static readonly ProcedureModifier Af = new(Values.Af);

    /// <summary>
    /// Primary physician
    /// </summary>
    public static readonly ProcedureModifier Ag = new(Values.Ag);

    /// <summary>
    /// Clinical psychologist
    /// </summary>
    public static readonly ProcedureModifier Ah = new(Values.Ah);

    /// <summary>
    /// Principal physician of record
    /// </summary>
    public static readonly ProcedureModifier Ai = new(Values.Ai);

    /// <summary>
    /// Clinical social worker
    /// </summary>
    public static readonly ProcedureModifier Aj = new(Values.Aj);

    /// <summary>
    /// Non participating physician
    /// </summary>
    public static readonly ProcedureModifier Ak = new(Values.Ak);

    /// <summary>
    /// Physician, team member service
    /// </summary>
    public static readonly ProcedureModifier Am = new(Values.Am);

    /// <summary>
    /// Alternate payment method declined by provider of service
    /// </summary>
    public static readonly ProcedureModifier Ao = new(Values.Ao);

    /// <summary>
    /// Determination of refractive state was not performed in the course of diagnostic ophthalmological examination
    /// </summary>
    public static readonly ProcedureModifier Ap = new(Values.Ap);

    /// <summary>
    /// Physician providing a service in an unlisted health professional shortage area (hpsa)
    /// </summary>
    public static readonly ProcedureModifier Aq = new(Values.Aq);

    /// <summary>
    /// Physician provider services in a physician scarcity area
    /// </summary>
    public static readonly ProcedureModifier Ar = new(Values.Ar);

    /// <summary>
    /// Physician assistant, nurse practitioner, or clinical nurse specialist services for assistant at surgery
    /// </summary>
    public static readonly ProcedureModifier As = new(Values.As);

    /// <summary>
    /// Acute treatment
    /// </summary>
    public static readonly ProcedureModifier At = new(Values.At);

    /// <summary>
    /// Physician providing a service in a dental health professional shortage area for the purpose of an EHR incentive payment
    /// </summary>
    public static readonly ProcedureModifier Az = new(Values.Az);

    /// <summary>
    /// Item furnished in conjunction with parenteral enteral nutrition (pen) services
    /// </summary>
    public static readonly ProcedureModifier Ba = new(Values.Ba);

    /// <summary>
    /// Special acquisition of blood and blood products
    /// </summary>
    public static readonly ProcedureModifier Bl = new(Values.Bl);

    /// <summary>
    /// Orally administered nutrition, not by feeding tube
    /// </summary>
    public static readonly ProcedureModifier Bo = new(Values.Bo);

    /// <summary>
    /// The beneficiary has been informed of the purchase and rental options and has elected to purchase the item
    /// </summary>
    public static readonly ProcedureModifier Bp = new(Values.Bp);

    /// <summary>
    /// The beneficiary has been informed of the purchase and rental options and has elected to rent the item
    /// </summary>
    public static readonly ProcedureModifier Br = new(Values.Br);

    /// <summary>
    /// The beneficiary has been informed of the purchase and rental options and after 30 days has not informed the supplier
    /// </summary>
    public static readonly ProcedureModifier Bu = new(Values.Bu);

    /// <summary>
    /// Procedure payable only in the inpatient setting when performed emergently on an outpatient who expires prior to admission
    /// </summary>
    public static readonly ProcedureModifier Ca = new(Values.Ca);

    /// <summary>
    /// Service ordered by a renal dialysis facility (rdf) physician as part of the ESRD beneficiary's dialysis benefit
    /// </summary>
    public static readonly ProcedureModifier Cb = new(Values.Cb);

    /// <summary>
    /// Procedure code change
    /// </summary>
    public static readonly ProcedureModifier Cc = new(Values.Cc);

    /// <summary>
    /// Amcc test has been ordered by an ESRD facility or MCP physician that is not separately billable
    /// </summary>
    public static readonly ProcedureModifier Cd = new(Values.Cd);

    /// <summary>
    /// Amcc test has been ordered by an esrd facility or mcp physician that is beyond the normal frequency covered
    /// </summary>
    public static readonly ProcedureModifier Ce = new(Values.Ce);

    /// <summary>
    /// Amcc test has been ordered by an esrd facility or mcp physician that is separately billable
    /// </summary>
    public static readonly ProcedureModifier Cf = new(Values.Cf);

    /// <summary>
    /// Policy criteria applied
    /// </summary>
    public static readonly ProcedureModifier Cg = new(Values.Cg);

    /// <summary>
    /// 0 percent impaired, limited or restricted
    /// </summary>
    public static readonly ProcedureModifier Ch = new(Values.Ch);

    /// <summary>
    /// At least 1 percent but less than 20 percent impaired, limited or restricted
    /// </summary>
    public static readonly ProcedureModifier Ci = new(Values.Ci);

    /// <summary>
    /// At least 20 percent but less than 40 percent impaired, limited or restricted
    /// </summary>
    public static readonly ProcedureModifier Cj = new(Values.Cj);

    /// <summary>
    /// At least 40 percent but less than 60 percent impaired, limited or restricted
    /// </summary>
    public static readonly ProcedureModifier Ck = new(Values.Ck);

    /// <summary>
    /// At least 60 percent but less than 80 percent impaired, limited or restricted
    /// </summary>
    public static readonly ProcedureModifier Cl = new(Values.Cl);

    /// <summary>
    /// At least 80 percent but less than 100 percent impaired, limited or restricted
    /// </summary>
    public static readonly ProcedureModifier Cm = new(Values.Cm);

    /// <summary>
    /// 100 percent impaired, limited or restricted
    /// </summary>
    public static readonly ProcedureModifier Cn = new(Values.Cn);

    /// <summary>
    /// Catastrophe/disaster related
    /// </summary>
    public static readonly ProcedureModifier Cr = new(Values.Cr);

    /// <summary>
    /// Cost sharing for COVID-19 testing
    /// </summary>
    public static readonly ProcedureModifier Cs = new(Values.Cs);

    /// <summary>
    /// Computed tomography services furnished using equipment that does not meet xr-29-2013 standard
    /// </summary>
    public static readonly ProcedureModifier Ct = new(Values.Ct);

    /// <summary>
    /// Outpatient physical therapy services furnished in whole or in part by a occupational therapist assistant
    /// </summary>
    public static readonly ProcedureModifier Co = new(Values.Co);

    /// <summary>
    /// Outpatient physical therapy services furnished in whole or in part by a physical therapist assistant
    /// </summary>
    public static readonly ProcedureModifier Cq = new(Values.Cq);

    /// <summary>
    /// Oral health assessment by a licensed health professional other than a dentist
    /// </summary>
    public static readonly ProcedureModifier Da = new(Values.Da);

    /// <summary>
    /// Upper left, eyelid
    /// </summary>
    public static readonly ProcedureModifier E1 = new(Values.E1);

    /// <summary>
    /// Lower left, eyelid
    /// </summary>
    public static readonly ProcedureModifier E2 = new(Values.E2);

    /// <summary>
    /// Upper right, eyelid
    /// </summary>
    public static readonly ProcedureModifier E3 = new(Values.E3);

    /// <summary>
    /// Lower right, eyelid
    /// </summary>
    public static readonly ProcedureModifier E4 = new(Values.E4);

    /// <summary>
    /// Erythropoetic stimulating agent (esa) administered to treat anemia due to anti-cancer chemotherapy
    /// </summary>
    public static readonly ProcedureModifier Ea = new(Values.Ea);

    /// <summary>
    /// Erythropoetic stimulating agent (esa) administered to treat anemia due to anti-cancer radiotherapy
    /// </summary>
    public static readonly ProcedureModifier Eb = new(Values.Eb);

    /// <summary>
    /// Erythropoetic stimulating agent (esa) administered to treat anemia not due to anti-cancer radiotherapy or chemotherapy
    /// </summary>
    public static readonly ProcedureModifier Ec = new(Values.Ec);

    /// <summary>
    /// Hematocrit level has exceeded 39% (or hemoglobin level has exceeded 13.0 g/dl) for 3 or more consecutive billing cycles
    /// </summary>
    public static readonly ProcedureModifier Ed = new(Values.Ed);

    /// <summary>
    /// Hematocrit level has not exceeded 39% (or hemoglobin level has not exceeded 13.0 g/dl) for 3 or more billing cycles
    /// </summary>
    public static readonly ProcedureModifier Ee = new(Values.Ee);

    /// <summary>
    /// Subsequent claims for a defined course of therapy, e.g., epo, sodium hyaluronate, infliximab
    /// </summary>
    public static readonly ProcedureModifier Ej = new(Values.Ej);

    /// <summary>
    /// Emergency reserve supply (for esrd benefit only)
    /// </summary>
    public static readonly ProcedureModifier Em = new(Values.Em);

    /// <summary>
    /// Service provided as part of medicaid early periodic screening diagnosis and treatment (epsdt) program
    /// </summary>
    public static readonly ProcedureModifier Ep = new(Values.Ep);

    /// <summary>
    /// Items and services furnished by a provider-based, off-campus emergency department
    /// </summary>
    public static readonly ProcedureModifier Er = new(Values.Er);

    /// <summary>
    /// Emergency services
    /// </summary>
    public static readonly ProcedureModifier Et = new(Values.Et);

    /// <summary>
    /// Electronic visit verification
    /// </summary>
    public static readonly ProcedureModifier Ev = new(Values.Ev);

    /// <summary>
    /// Expatriate beneficiary
    /// </summary>
    public static readonly ProcedureModifier Ex = new(Values.Ex);

    /// <summary>
    /// No physician or other licensed health care provider order for this item or service
    /// </summary>
    public static readonly ProcedureModifier Ey = new(Values.Ey);

    /// <summary>
    /// Left hand, second digit
    /// </summary>
    public static readonly ProcedureModifier F1 = new(Values.F1);

    /// <summary>
    /// Left hand, third digit
    /// </summary>
    public static readonly ProcedureModifier F2 = new(Values.F2);

    /// <summary>
    /// Left hand, fourth digit
    /// </summary>
    public static readonly ProcedureModifier F3 = new(Values.F3);

    /// <summary>
    /// Left hand, fifth digit
    /// </summary>
    public static readonly ProcedureModifier F4 = new(Values.F4);

    /// <summary>
    /// Right hand, thumb
    /// </summary>
    public static readonly ProcedureModifier F5 = new(Values.F5);

    /// <summary>
    /// Right hand, second digit
    /// </summary>
    public static readonly ProcedureModifier F6 = new(Values.F6);

    /// <summary>
    /// Right hand, third digit
    /// </summary>
    public static readonly ProcedureModifier F7 = new(Values.F7);

    /// <summary>
    /// Right hand, fourth digit
    /// </summary>
    public static readonly ProcedureModifier F8 = new(Values.F8);

    /// <summary>
    /// Right hand, fifth digit
    /// </summary>
    public static readonly ProcedureModifier F9 = new(Values.F9);

    /// <summary>
    /// Right hand, thumb
    /// </summary>
    public static readonly ProcedureModifier Fa = new(Values.Fa);

    /// <summary>
    /// Item provided without cost to provider, supplier or practitioner, or full credit received for replaced device
    /// </summary>
    public static readonly ProcedureModifier Fb = new(Values.Fb);

    /// <summary>
    /// Partial credit received for replaced device
    /// </summary>
    public static readonly ProcedureModifier Fc = new(Values.Fc);

    /// <summary>
    /// Service provided as part of family planning program
    /// </summary>
    public static readonly ProcedureModifier Fp = new(Values.Fp);

    /// <summary>
    /// Telehealth service furnished using real-time audio-only communication technology.
    /// </summary>
    public static readonly ProcedureModifier Fq = new(Values.Fq);

    /// <summary>
    /// A supervising practitioner was present through a real-time two-way, audio/video communication technology.
    /// </summary>
    public static readonly ProcedureModifier Fr = new(Values.Fr);

    /// <summary>
    /// Split (or shared) evaluation and management visit.
    /// </summary>
    public static readonly ProcedureModifier Fs = new(Values.Fs);

    /// <summary>
    /// Unrelated evaluation and management (e/m) visit on the same day as another e/m visit or during a global procedure
    /// </summary>
    public static readonly ProcedureModifier Ft = new(Values.Ft);

    /// <summary>
    /// X-ray taken using film
    /// </summary>
    public static readonly ProcedureModifier Fx = new(Values.Fx);

    /// <summary>
    /// X-ray taken using computed radiography technology/cassette-based imaging
    /// </summary>
    public static readonly ProcedureModifier Fy = new(Values.Fy);

    /// <summary>
    /// Telehealth Services For Diagnosis, Evaluation, Or Treatment, Of Symptoms Of An Acute Stroke
    /// </summary>
    public static readonly ProcedureModifier G0 = new(Values.G0);

    /// <summary>
    /// Most recent urr reading of less than 60
    /// </summary>
    public static readonly ProcedureModifier G1 = new(Values.G1);

    /// <summary>
    /// Most recent urr reading of 60 to 64.9
    /// </summary>
    public static readonly ProcedureModifier G2 = new(Values.G2);

    /// <summary>
    /// Most recent urr reading of 65 to 69.9
    /// </summary>
    public static readonly ProcedureModifier G3 = new(Values.G3);

    /// <summary>
    /// Most recent urr reading of 70 to 74.9
    /// </summary>
    public static readonly ProcedureModifier G4 = new(Values.G4);

    /// <summary>
    /// Most recent urr reading of 75 or greater
    /// </summary>
    public static readonly ProcedureModifier G5 = new(Values.G5);

    /// <summary>
    /// ESRD patient for whom less than six dialysis sessions have been provided in a month
    /// </summary>
    public static readonly ProcedureModifier G6 = new(Values.G6);

    /// <summary>
    /// Pregnancy resulted from rape or incest or pregnancy certified by physician as life threatening
    /// </summary>
    public static readonly ProcedureModifier G7 = new(Values.G7);

    /// <summary>
    /// Monitored anesthesia care (mac) for deep complex, complicated, or markedly invasive surgical procedure
    /// </summary>
    public static readonly ProcedureModifier G8 = new(Values.G8);

    /// <summary>
    /// Monitored anesthesia care for patient who has history of severe cardio-pulmonary condition
    /// </summary>
    public static readonly ProcedureModifier G9 = new(Values.G9);

    /// <summary>
    /// Waiver of liability statement issued as required by payer policy, individual case
    /// </summary>
    public static readonly ProcedureModifier Ga = new(Values.Ga);

    /// <summary>
    /// Claim being re-submitted for payment because it is no longer covered under a global payment demonstration
    /// </summary>
    public static readonly ProcedureModifier Gb = new(Values.Gb);

    /// <summary>
    /// This service has been performed in part by a resident under the direction of a teaching physician
    /// </summary>
    public static readonly ProcedureModifier Gc = new(Values.Gc);

    /// <summary>
    /// This service has been performed by a resident without the presence of a teaching physician under the primary care exception
    /// </summary>
    public static readonly ProcedureModifier Ge = new(Values.Ge);

    /// <summary>
    /// Non-physician (e.g. nurse practitioner (np), certified registered nurse anesthetist (crna), certified registered nurse (crn), clinical nurse specialist (cns), physician assistant (pa)) services in a critical access hospital
    /// </summary>
    public static readonly ProcedureModifier Gf = new(Values.Gf);

    /// <summary>
    /// Performance and payment of a screening mammogram and diagnostic mammogram on the same patient, same day
    /// </summary>
    public static readonly ProcedureModifier Gg = new(Values.Gg);

    /// <summary>
    /// Diagnostic mammogram converted from screening mammogram on same day
    /// </summary>
    public static readonly ProcedureModifier Gh = new(Values.Gh);

    /// <summary>
    /// opt out physician or practitioner emergency or urgent service
    /// </summary>
    public static readonly ProcedureModifier Gj = new(Values.Gj);

    /// <summary>
    /// Reasonable and necessary item/service associated with a ga or gz modifier
    /// </summary>
    public static readonly ProcedureModifier Gk = new(Values.Gk);

    /// <summary>
    /// Medically unnecessary upgrade provided instead of non-upgraded item, no charge, no advance beneficiary notice (abn)
    /// </summary>
    public static readonly ProcedureModifier Gl = new(Values.Gl);

    /// <summary>
    /// Multiple patients on one ambulance trip
    /// </summary>
    public static readonly ProcedureModifier Gm = new(Values.Gm);

    /// <summary>
    /// Services delivered under an outpatient speech-language pathology plan of care
    /// </summary>
    public static readonly ProcedureModifier Gn = new(Values.Gn);

    /// <summary>
    /// Service delivered personally by an occupational therapist or under an outpatient occupational therapy plan of care
    /// </summary>
    public static readonly ProcedureModifier Go = new(Values.Go);

    /// <summary>
    /// Service delivered personally by a physical therapist or under an outpatient physical therapy plan of care
    /// </summary>
    public static readonly ProcedureModifier Gp = new(Values.Gp);

    /// <summary>
    /// Services provided via an asynchronous telecommunications system
    /// </summary>
    public static readonly ProcedureModifier Gq = new(Values.Gq);

    /// <summary>
    /// This service was performed in whole or in part by a resident in a department of veterans affairs medical center or clinic, supervised in accordance with va policy
    /// </summary>
    public static readonly ProcedureModifier Gr = new(Values.Gr);

    /// <summary>
    /// Dosage of erythropoietin stimulating agent has been reduced and maintained in response to hematocrit or hemoglobin level
    /// </summary>
    public static readonly ProcedureModifier Gs = new(Values.Gs);

    /// <summary>
    /// Services took place via an interactive audio and video telecommunications system
    /// </summary>
    public static readonly ProcedureModifier Gt = new(Values.Gt);

    /// <summary>
    /// Waiver of liability statement issued as required by payer policy, routine notice
    /// </summary>
    public static readonly ProcedureModifier Gu = new(Values.Gu);

    /// <summary>
    /// Attending physician not employed or paid under arrangement by the patient's hospice provider
    /// </summary>
    public static readonly ProcedureModifier Gv = new(Values.Gv);

    /// <summary>
    /// Service not related to the hospice patient's terminal condition
    /// </summary>
    public static readonly ProcedureModifier Gw = new(Values.Gw);

    /// <summary>
    /// Notice of liability issued, voluntary under payer policy
    /// </summary>
    public static readonly ProcedureModifier Gx = new(Values.Gx);

    /// <summary>
    /// Not a covered benefit
    /// </summary>
    public static readonly ProcedureModifier Gy = new(Values.Gy);

    /// <summary>
    /// Item or service expected to be denied as not reasonable and necessary
    /// </summary>
    public static readonly ProcedureModifier Gz = new(Values.Gz);

    /// <summary>
    /// Child/adolescent program
    /// </summary>
    public static readonly ProcedureModifier Ha = new(Values.Ha);

    /// <summary>
    /// Adult program, non geriatric
    /// </summary>
    public static readonly ProcedureModifier Hb = new(Values.Hb);

    /// <summary>
    /// Adult program, geriatric
    /// </summary>
    public static readonly ProcedureModifier Hc = new(Values.Hc);

    /// <summary>
    /// Pregnant/parenting women's program
    /// </summary>
    public static readonly ProcedureModifier Hd = new(Values.Hd);

    /// <summary>
    /// Mental health program
    /// </summary>
    public static readonly ProcedureModifier He = new(Values.He);

    /// <summary>
    /// Substance abuse program
    /// </summary>
    public static readonly ProcedureModifier Hf = new(Values.Hf);

    /// <summary>
    /// Opioid addiction treatment program
    /// </summary>
    public static readonly ProcedureModifier Hg = new(Values.Hg);

    /// <summary>
    /// Integrated mental health/substance abuse program
    /// </summary>
    public static readonly ProcedureModifier Hh = new(Values.Hh);

    /// <summary>
    /// Integrated mental health and intellectual disability/developmental disabilities program
    /// </summary>
    public static readonly ProcedureModifier Hi = new(Values.Hi);

    /// <summary>
    /// Employee assistance program
    /// </summary>
    public static readonly ProcedureModifier Hj = new(Values.Hj);

    /// <summary>
    /// Specialized mental health programs for high-risk populations
    /// </summary>
    public static readonly ProcedureModifier Hk = new(Values.Hk);

    /// <summary>
    /// Intern
    /// </summary>
    public static readonly ProcedureModifier Hl = new(Values.Hl);

    /// <summary>
    /// The rendering provider has a highest educational attainment of less than a bachelor's degree
    /// </summary>
    public static readonly ProcedureModifier Hm = new(Values.Hm);

    /// <summary>
    /// The rendering provider has a highest educational attainment of a bachelor's degree
    /// </summary>
    public static readonly ProcedureModifier Hn = new(Values.Hn);

    /// <summary>
    /// The rendering provider has a highest educational attainment of a master's degree
    /// </summary>
    public static readonly ProcedureModifier Ho = new(Values.Ho);

    /// <summary>
    /// The rendering provider has a highest educational attainment of a doctoral degree
    /// </summary>
    public static readonly ProcedureModifier Hp = new(Values.Hp);

    /// <summary>
    /// Group setting
    /// </summary>
    public static readonly ProcedureModifier Hq = new(Values.Hq);

    /// <summary>
    /// Family/couple with client present
    /// </summary>
    public static readonly ProcedureModifier Hr = new(Values.Hr);

    /// <summary>
    /// Family/couple without client present
    /// </summary>
    public static readonly ProcedureModifier Hs = new(Values.Hs);

    /// <summary>
    /// Multi-disciplinary team
    /// </summary>
    public static readonly ProcedureModifier Ht = new(Values.Ht);

    /// <summary>
    /// Funded by child welfare agency
    /// </summary>
    public static readonly ProcedureModifier Hu = new(Values.Hu);

    /// <summary>
    /// Funded by state addictions agency
    /// </summary>
    public static readonly ProcedureModifier Hv = new(Values.Hv);

    /// <summary>
    /// Funded by state mental health agency
    /// </summary>
    public static readonly ProcedureModifier Hw = new(Values.Hw);

    /// <summary>
    /// Funded by county/local agency
    /// </summary>
    public static readonly ProcedureModifier Hx = new(Values.Hx);

    /// <summary>
    /// Funded by juvenile justice agency
    /// </summary>
    public static readonly ProcedureModifier Hy = new(Values.Hy);

    /// <summary>
    /// Funded by criminal justice agency
    /// </summary>
    public static readonly ProcedureModifier Hz = new(Values.Hz);

    /// <summary>
    /// Competitive acquisition program no-pay submission for a prescription number
    /// </summary>
    public static readonly ProcedureModifier J1 = new(Values.J1);

    /// <summary>
    /// Competitive acquisition program, restocking of emergency drugs after emergency administration
    /// </summary>
    public static readonly ProcedureModifier J2 = new(Values.J2);

    /// <summary>
    /// Competitive acquisition program (cap) reimbursed under average sales price methodology
    /// </summary>
    public static readonly ProcedureModifier J3 = new(Values.J3);

    /// <summary>
    /// DMEPOS item subject to DMEPOS competitive bidding program that is furnished by a hospital upon discharge
    /// </summary>
    public static readonly ProcedureModifier J4 = new(Values.J4);

    /// <summary>
    /// Off-the-shelf orthotic subject to DMEPOS competitive bidding program
    /// </summary>
    public static readonly ProcedureModifier J5 = new(Values.J5);

    /// <summary>
    /// Administered intravenously
    /// </summary>
    public static readonly ProcedureModifier Ja = new(Values.Ja);

    /// <summary>
    /// Administered subcutaneously
    /// </summary>
    public static readonly ProcedureModifier Jb = new(Values.Jb);

    /// <summary>
    /// Skin substitute used as a graft
    /// </summary>
    public static readonly ProcedureModifier Jc = new(Values.Jc);

    /// <summary>
    /// Skin substitute not used as a graft
    /// </summary>
    public static readonly ProcedureModifier Jd = new(Values.Jd);

    /// <summary>
    /// Administered via dialysate
    /// </summary>
    public static readonly ProcedureModifier Je = new(Values.Je);

    /// <summary>
    /// Drug or biological acquired with 340b drug pricing program discount
    /// </summary>
    public static readonly ProcedureModifier Jg = new(Values.Jg);

    /// <summary>
    /// Drug amount discarded/not administered to any patient
    /// </summary>
    public static readonly ProcedureModifier Jw = new(Values.Jw);

    /// <summary>
    /// Zero drug amount discarded/not administered to any patient
    /// </summary>
    public static readonly ProcedureModifier Jz = new(Values.Jz);

    /// <summary>
    /// Lower extremity prosthesis functional level 0
    /// </summary>
    public static readonly ProcedureModifier K0 = new(Values.K0);

    /// <summary>
    /// Lower extremity prosthesis functional level 1
    /// </summary>
    public static readonly ProcedureModifier K1 = new(Values.K1);

    /// <summary>
    /// Lower extremity prosthesis functional level 2
    /// </summary>
    public static readonly ProcedureModifier K2 = new(Values.K2);

    /// <summary>
    /// Lower extremity prosthesis functional level 3
    /// </summary>
    public static readonly ProcedureModifier K3 = new(Values.K3);

    /// <summary>
    /// Lower extremity prosthesis functional level 4
    /// </summary>
    public static readonly ProcedureModifier K4 = new(Values.K4);

    /// <summary>
    /// Add on option/accessory for wheelchair
    /// </summary>
    public static readonly ProcedureModifier Ka = new(Values.Ka);

    /// <summary>
    /// Beneficiary requested upgrade for abn, more than 4 modifiers identified on claim
    /// </summary>
    public static readonly ProcedureModifier Kb = new(Values.Kb);

    /// <summary>
    /// Replacement of special power wheelchair interface
    /// </summary>
    public static readonly ProcedureModifier Kc = new(Values.Kc);

    /// <summary>
    /// Drug or biological infused through DME
    /// </summary>
    public static readonly ProcedureModifier Kd = new(Values.Kd);

    /// <summary>
    /// Bid under round one of the DMEPOS competitive bidding program
    /// </summary>
    public static readonly ProcedureModifier Ke = new(Values.Ke);

    /// <summary>
    /// Item designated by FDA as class III device
    /// </summary>
    public static readonly ProcedureModifier Kf = new(Values.Kf);

    /// <summary>
    /// DMEPOS item subject to DMEPOS competitive bidding program number 1
    /// </summary>
    public static readonly ProcedureModifier Kg = new(Values.Kg);

    /// <summary>
    /// DMEPOS item, initial claim, purchase or first month rental
    /// </summary>
    public static readonly ProcedureModifier Kh = new(Values.Kh);

    /// <summary>
    /// DMEPOS item, second or third month rental
    /// </summary>
    public static readonly ProcedureModifier Ki = new(Values.Ki);

    /// <summary>
    /// DMEPOS item, parenteral enteral nutrition (pen) pump or capped rental, months four to fifteen
    /// </summary>
    public static readonly ProcedureModifier Kj = new(Values.Kj);

    /// <summary>
    /// DMEPOS item subject to DMEPOS competitive bidding program number 2
    /// </summary>
    public static readonly ProcedureModifier Kk = new(Values.Kk);

    /// <summary>
    /// DMEPOS item delivered via mail
    /// </summary>
    public static readonly ProcedureModifier Kl = new(Values.Kl);

    /// <summary>
    /// Replacement of facial prosthesis including new impression/moulage
    /// </summary>
    public static readonly ProcedureModifier Km = new(Values.Km);

    /// <summary>
    /// Replacement of facial prosthesis using previous master model
    /// </summary>
    public static readonly ProcedureModifier Kn = new(Values.Kn);

    /// <summary>
    /// Single drug unit dose formulation
    /// </summary>
    public static readonly ProcedureModifier Ko = new(Values.Ko);

    /// <summary>
    /// First drug of a multiple drug unit dose formulation
    /// </summary>
    public static readonly ProcedureModifier Kp = new(Values.Kp);

    /// <summary>
    /// Second or subsequent drug of a multiple drug unit dose formulation
    /// </summary>
    public static readonly ProcedureModifier Kq = new(Values.Kq);

    /// <summary>
    /// Rental item, billing for partial month
    /// </summary>
    public static readonly ProcedureModifier Kr = new(Values.Kr);

    /// <summary>
    /// Glucose monitor supply for diabetic beneficiary not treated with insulin
    /// </summary>
    public static readonly ProcedureModifier Ks = new(Values.Ks);

    /// <summary>
    /// Beneficiary resides in a competitive bidding area and travels outside that competitive bidding area
    /// </summary>
    public static readonly ProcedureModifier Kt = new(Values.Kt);

    /// <summary>
    /// DMEPOS item subject to DMEPOS competitive bidding program number 3
    /// </summary>
    public static readonly ProcedureModifier Ku = new(Values.Ku);

    /// <summary>
    /// DMEPOS item subject to DMEPOS competitive bidding program that is furnished as part of a professional service
    /// </summary>
    public static readonly ProcedureModifier Kv = new(Values.Kv);

    /// <summary>
    /// DMEPOS item subject to DMEPOS competitive bidding program number 4
    /// </summary>
    public static readonly ProcedureModifier Kw = new(Values.Kw);

    /// <summary>
    /// Requirements specified in the medical policy have been met
    /// </summary>
    public static readonly ProcedureModifier Kx = new(Values.Kx);

    /// <summary>
    /// DMEPOS item subject to DMEPOS competitive bidding program number 5
    /// </summary>
    public static readonly ProcedureModifier Ky = new(Values.Ky);

    /// <summary>
    /// New coverage not implemented by managed care
    /// </summary>
    public static readonly ProcedureModifier Kz = new(Values.Kz);

    /// <summary>
    /// Left circumflex coronary artery
    /// </summary>
    public static readonly ProcedureModifier Lc = new(Values.Lc);

    /// <summary>
    /// Left anterior descending coronary artery
    /// </summary>
    public static readonly ProcedureModifier Ld = new(Values.Ld);

    /// <summary>
    /// Lease/rental
    /// </summary>
    public static readonly ProcedureModifier Ll = new(Values.Ll);

    /// <summary>
    /// Left main coronary artery
    /// </summary>
    public static readonly ProcedureModifier Lm = new(Values.Lm);

    /// <summary>
    /// Laboratory round trip
    /// </summary>
    public static readonly ProcedureModifier Lr = new(Values.Lr);

    /// <summary>
    /// FDA-monitored intraocular lens implant
    /// </summary>
    public static readonly ProcedureModifier Ls = new(Values.Ls);

    /// <summary>
    /// Left side (used to identify procedures performed on the left side of the body)
    /// </summary>
    public static readonly ProcedureModifier Lt = new(Values.Lt);

    /// <summary>
    /// Fractionated payment of CAR-T therapy
    /// </summary>
    public static readonly ProcedureModifier Lu = new(Values.Lu);

    /// <summary>
    /// Medicare secondary payer
    /// </summary>
    public static readonly ProcedureModifier M2 = new(Values.M2);

    /// <summary>
    /// Not required to consult clinical decision support... for patient with a suspected or confirmed emergency medical condition
    /// </summary>
    public static readonly ProcedureModifier Ma = new(Values.Ma);

    /// <summary>
    /// Not required to consult clinical decision support mechanism due to insufficient internet access
    /// </summary>
    public static readonly ProcedureModifier Mb = new(Values.Mb);

    /// <summary>
    /// Not required to consult clinical decision support mechanism due to electronic health record vendor issues
    /// </summary>
    public static readonly ProcedureModifier Mc = new(Values.Mc);

    /// <summary>
    /// Not required to consult clinical decision support mechanism due to extreme/uncontrollable circumstances
    /// </summary>
    public static readonly ProcedureModifier Md = new(Values.Md);

    /// <summary>
    /// Adheres to appropriate use criteria in the clinical decision support mechanism consulted by the ordering professional
    /// </summary>
    public static readonly ProcedureModifier Me = new(Values.Me);

    /// <summary>
    /// Does not adhere to the criteria in the clinical decision support mechanism consulted by the ordering professional
    /// </summary>
    public static readonly ProcedureModifier Mf = new(Values.Mf);

    /// <summary>
    /// Does not have appropriate use criteria in the clinical decision support mechanism consulted by the ordering professional
    /// </summary>
    public static readonly ProcedureModifier Mg = new(Values.Mg);

    /// <summary>
    /// Unknown if ordering professional consulted a clinical decision support mechanism for this service
    /// </summary>
    public static readonly ProcedureModifier Mh = new(Values.Mh);

    /// <summary>
    /// Six month maintenance and servicing fee for parts and labor, not covered under any manufacturer or supplier warranty
    /// </summary>
    public static readonly ProcedureModifier Ms = new(Values.Ms);

    /// <summary>
    /// Group 1 oxygen coverage criteria met
    /// </summary>
    public static readonly ProcedureModifier N1 = new(Values.N1);

    /// <summary>
    /// Group 2 oxygen coverage criteria met
    /// </summary>
    public static readonly ProcedureModifier N2 = new(Values.N2);

    /// <summary>
    /// Group 3 oxygen coverage criteria met
    /// </summary>
    public static readonly ProcedureModifier N3 = new(Values.N3);

    /// <summary>
    /// Nebulizer system, any type, FDA-cleared for use with specific drug
    /// </summary>
    public static readonly ProcedureModifier Nb = new(Values.Nb);

    /// <summary>
    /// New when rented
    /// </summary>
    public static readonly ProcedureModifier Nr = new(Values.Nr);

    /// <summary>
    /// New durable medical equipment purchase
    /// </summary>
    public static readonly ProcedureModifier Nu = new(Values.Nu);

    /// <summary>
    /// A normal healthy patient
    /// </summary>
    public static readonly ProcedureModifier P1 = new(Values.P1);

    /// <summary>
    /// A patient with a mild systemic disease
    /// </summary>
    public static readonly ProcedureModifier P2 = new(Values.P2);

    /// <summary>
    /// A patient with severe systemic disease
    /// </summary>
    public static readonly ProcedureModifier P3 = new(Values.P3);

    /// <summary>
    /// A patient with severe systemic disease that is a constant threat to life
    /// </summary>
    public static readonly ProcedureModifier P4 = new(Values.P4);

    /// <summary>
    /// A moribund patient who is not expected to survive without the operation
    /// </summary>
    public static readonly ProcedureModifier P5 = new(Values.P5);

    /// <summary>
    /// A declared brain-dead patient whose organs are being removed for donor purposes
    /// </summary>
    public static readonly ProcedureModifier P6 = new(Values.P6);

    /// <summary>
    /// Surgical or other invasive procedure on wrong body part
    /// </summary>
    public static readonly ProcedureModifier Pa = new(Values.Pa);

    /// <summary>
    /// Surgical or other invasive procedure on wrong patient
    /// </summary>
    public static readonly ProcedureModifier Pb = new(Values.Pb);

    /// <summary>
    /// Wrong surgery or other invasive procedure on patient
    /// </summary>
    public static readonly ProcedureModifier Pc = new(Values.Pc);

    /// <summary>
    /// Diagnostic or related non diagnostic item or service provided in a wholly owned or operated entity to a patient who is admitted as an inpatient within 3 days
    /// </summary>
    public static readonly ProcedureModifier Pd = new(Values.Pd);

    /// <summary>
    /// Positron emission tomography (PET) or PET/computed tomography (CT)
    /// </summary>
    public static readonly ProcedureModifier Pi = new(Values.Pi);

    /// <summary>
    /// Progressive addition lenses
    /// </summary>
    public static readonly ProcedureModifier Pl = new(Values.Pl);

    /// <summary>
    /// Post-mortem
    /// </summary>
    public static readonly ProcedureModifier Pm = new(Values.Pm);

    /// <summary>
    /// Non-excepted service provided at an off-campus, outpatient, provider-based department of a hospital
    /// </summary>
    public static readonly ProcedureModifier Pn = new(Values.Pn);

    /// <summary>
    /// Excepted service provided at an off-campus, outpatient, provider-based department of a hospital
    /// </summary>
    public static readonly ProcedureModifier Po = new(Values.Po);

    /// <summary>
    /// Positron emission tomography (PET) or pet/computed tomography (CT) to inform the treatment strategy of cancerous tumors
    /// </summary>
    public static readonly ProcedureModifier Ps = new(Values.Ps);

    /// <summary>
    /// Colorectal cancer screening test; converted to diagnostic test or other procedure
    /// </summary>
    public static readonly ProcedureModifier Pt = new(Values.Pt);

    /// <summary>
    /// Investigational clinical service provided in a clinical research study that is in an approved clinical research study
    /// </summary>
    public static readonly ProcedureModifier Q0 = new(Values.Q0);

    /// <summary>
    /// Routine clinical service provided in a clinical research study that is in an approved clinical research study
    /// </summary>
    public static readonly ProcedureModifier Q1 = new(Values.Q1);

    /// <summary>
    /// Demonstration procedure/service
    /// </summary>
    public static readonly ProcedureModifier Q2 = new(Values.Q2);

    /// <summary>
    /// Live kidney donor surgery and related services
    /// </summary>
    public static readonly ProcedureModifier Q3 = new(Values.Q3);

    /// <summary>
    /// Service for ordering/referring physician qualifies as a service exemption
    /// </summary>
    public static readonly ProcedureModifier Q4 = new(Values.Q4);

    /// <summary>
    /// Service furnished under a reciprocal billing arrangement by a substitute physician; or by a substitute physical therapist furnishing outpatient physical therapy services in a health professional shortage area, a medically underserved area, or a rural area
    /// </summary>
    public static readonly ProcedureModifier Q5 = new(Values.Q5);

    /// <summary>
    /// Service furnished under a fee-for-time compensation arrangement by a substitute physician; or by a substitute physical therapist furnishing outpatient physical therapy services in a health professional shortage area, a medically underserved area, or a rural area
    /// </summary>
    public static readonly ProcedureModifier Q6 = new(Values.Q6);

    /// <summary>
    /// One Class A finding
    /// </summary>
    public static readonly ProcedureModifier Q7 = new(Values.Q7);

    /// <summary>
    /// Two Class A findings
    /// </summary>
    public static readonly ProcedureModifier Q8 = new(Values.Q8);

    /// <summary>
    /// One Class B and two Class C findings
    /// </summary>
    public static readonly ProcedureModifier Q9 = new(Values.Q9);

    /// <summary>
    /// Prescribed amounts of stationary oxygen for daytime use differ ... &lt;1 liter per minute
    /// </summary>
    public static readonly ProcedureModifier Qa = new(Values.Qa);

    /// <summary>
    /// Prescribed amounts of stationary oxygen for daytime use differ ... &gt;4 liters per minute
    /// </summary>
    public static readonly ProcedureModifier Qb = new(Values.Qb);

    /// <summary>
    /// Single channel monitoring
    /// </summary>
    public static readonly ProcedureModifier Qc = new(Values.Qc);

    /// <summary>
    /// Recording and storage in solid state memory by a digital recorder
    /// </summary>
    public static readonly ProcedureModifier Qd = new(Values.Qd);

    /// <summary>
    /// Prescribed amount of stationary oxygen while at rest is less than 1 liter per minute (lpm)
    /// </summary>
    public static readonly ProcedureModifier Qe = new(Values.Qe);

    /// <summary>
    /// Prescribed amount of stationary oxygen while at rest exceeds 4 liters per minute (lpm) and portable oxygen is prescribed
    /// </summary>
    public static readonly ProcedureModifier Qf = new(Values.Qf);

    /// <summary>
    /// Prescribed amount of stationary oxygen while at rest is greater than 4 liters per minute (lpm)
    /// </summary>
    public static readonly ProcedureModifier Qg = new(Values.Qg);

    /// <summary>
    /// Oxygen conserving device is being used with an oxygen delivery system
    /// </summary>
    public static readonly ProcedureModifier Qh = new(Values.Qh);

    /// <summary>
    /// Services/items provided to a prisoner or patient in state or local custody, however the state or local government, as applicable, meets the requirements in 42 cfr 411.4 (b)
    /// </summary>
    public static readonly ProcedureModifier Qj = new(Values.Qj);

    /// <summary>
    /// Medical direction of two, three, or four concurrent anesthesia procedure involving qualified individuals
    /// </summary>
    public static readonly ProcedureModifier Qk = new(Values.Qk);

    /// <summary>
    /// Patient pronounced dead after ambulance called
    /// </summary>
    public static readonly ProcedureModifier Ql = new(Values.Ql);

    /// <summary>
    /// Ambulance service provided under arrangement by a provider of services
    /// </summary>
    public static readonly ProcedureModifier Qm = new(Values.Qm);

    /// <summary>
    /// Ambulance service furnished directly by a provider of services
    /// </summary>
    public static readonly ProcedureModifier Qn = new(Values.Qn);

    /// <summary>
    /// Laboratory test(s) was ordered individually or ordered as a cpt-recognized panel other than automated profile codes
    /// </summary>
    public static readonly ProcedureModifier Qp = new(Values.Qp);

    /// <summary>
    /// Ordering professional consulted a qualified clinical decision support mechanism for this service
    /// </summary>
    public static readonly ProcedureModifier Qq = new(Values.Qq);

    /// <summary>
    /// Amounts of stationary oxygen for daytime use and nighttime use differ; average of the amounts &gt;4 liters per minute
    /// </summary>
    public static readonly ProcedureModifier Qr = new(Values.Qr);

    /// <summary>
    /// Monitored anesthesia care service
    /// </summary>
    public static readonly ProcedureModifier Qs = new(Values.Qs);

    /// <summary>
    /// Recording and storage on tape by an analog tape recorder
    /// </summary>
    public static readonly ProcedureModifier Qt = new(Values.Qt);

    /// <summary>
    /// CLIA waived
    /// </summary>
    public static readonly ProcedureModifier Qw = new(Values.Qw);

    /// <summary>
    /// CRNA service: with medical direction by a physician
    /// </summary>
    public static readonly ProcedureModifier Qx = new(Values.Qx);

    /// <summary>
    /// Medical direction of one certified registered nurse anesthetist (CRNA) by an anesthesiologist
    /// </summary>
    public static readonly ProcedureModifier Qy = new(Values.Qy);

    /// <summary>
    /// CRNA service: without medical direction by a physician
    /// </summary>
    public static readonly ProcedureModifier Qz = new(Values.Qz);

    /// <summary>
    /// Replacement of a DME, orthotic or prosthetic item
    /// </summary>
    public static readonly ProcedureModifier Ra = new(Values.Ra);

    /// <summary>
    /// Replacement of a part of a DME, orthotic or prosthetic item
    /// </summary>
    public static readonly ProcedureModifier Rb = new(Values.Rb);

    /// <summary>
    /// Right coronary artery
    /// </summary>
    public static readonly ProcedureModifier Rc = new(Values.Rc);

    /// <summary>
    /// Drug provided to beneficiary, but not administered 'incident-to'
    /// </summary>
    public static readonly ProcedureModifier Rd = new(Values.Rd);

    /// <summary>
    /// Furnished in full compliance with FDA-mandated risk evaluation and mitigation strategy (REMS)
    /// </summary>
    public static readonly ProcedureModifier Re = new(Values.Re);

    /// <summary>
    /// Ramus intermedius coronary artery
    /// </summary>
    public static readonly ProcedureModifier Ri = new(Values.Ri);

    /// <summary>
    /// Rental (Use this ‘RR' modifier when DME is to be rented)
    /// </summary>
    public static readonly ProcedureModifier Rr = new(Values.Rr);

    /// <summary>
    /// Right side (used to identify procedures performed on the right side of the body)
    /// </summary>
    public static readonly ProcedureModifier Rt = new(Values.Rt);

    /// <summary>
    /// Physician assistant, nurse practitioner, or clinical nurse specialist services for non-surgical services
    /// </summary>
    public static readonly ProcedureModifier Sa = new(Values.Sa);

    /// <summary>
    /// Nurse midwife
    /// </summary>
    public static readonly ProcedureModifier Sb = new(Values.Sb);

    /// <summary>
    /// Medically necessary service or supply
    /// </summary>
    public static readonly ProcedureModifier Sc = new(Values.Sc);

    /// <summary>
    /// Services provided by registered nurse with specialized, highly technical home infusion training
    /// </summary>
    public static readonly ProcedureModifier Sd = new(Values.Sd);

    /// <summary>
    /// State- and/or federally-funded programs/services
    /// </summary>
    public static readonly ProcedureModifier Se = new(Values.Se);

    /// <summary>
    /// Second opinion ordered by a professional review organization (PRO) per section 9401, p.l. 99-272
    /// </summary>
    public static readonly ProcedureModifier Sf = new(Values.Sf);

    /// <summary>
    /// Ambulatory surgical center (ASC) facility service
    /// </summary>
    public static readonly ProcedureModifier Sg = new(Values.Sg);

    /// <summary>
    /// Second concurrently administered infusion therapy
    /// </summary>
    public static readonly ProcedureModifier Sh = new(Values.Sh);

    /// <summary>
    /// Third or more concurrently administered infusion therapy
    /// </summary>
    public static readonly ProcedureModifier Sj = new(Values.Sj);

    /// <summary>
    /// Addresses reimbursement guidelines for vaccines provided at no cost to the provider by a state or federal agency
    /// </summary>
    public static readonly ProcedureModifier Sl = new(Values.Sl);

    /// <summary>
    /// Second surgical opinion
    /// </summary>
    public static readonly ProcedureModifier Sm = new(Values.Sm);

    /// <summary>
    /// Third surgical opinion
    /// </summary>
    public static readonly ProcedureModifier Sn = new(Values.Sn);

    /// <summary>
    /// Item ordered by home health
    /// </summary>
    public static readonly ProcedureModifier Sq = new(Values.Sq);

    /// <summary>
    /// Home infusion services provided in the infusion suite of the IV therapy provider
    /// </summary>
    public static readonly ProcedureModifier Ss = new(Values.Ss);

    /// <summary>
    /// Related to trauma or injury
    /// </summary>
    public static readonly ProcedureModifier St = new(Values.St);

    /// <summary>
    /// Procedure performed in physician's office (to denote use of facility and equipment)
    /// </summary>
    public static readonly ProcedureModifier Su = new(Values.Su);

    /// <summary>
    /// Pharamceuticals delivered to patient's home but not utilized
    /// </summary>
    public static readonly ProcedureModifier Sv = new(Values.Sv);

    /// <summary>
    /// Services provided by a certified diabetic educator
    /// </summary>
    public static readonly ProcedureModifier Sw = new(Values.Sw);

    /// <summary>
    /// Persons who are in close contact with member of high-risk population (use only with codes for immunization)
    /// </summary>
    public static readonly ProcedureModifier Sy = new(Values.Sy);

    /// <summary>
    /// Left foot, second digit
    /// </summary>
    public static readonly ProcedureModifier T1 = new(Values.T1);

    /// <summary>
    /// Left foot, third digit
    /// </summary>
    public static readonly ProcedureModifier T2 = new(Values.T2);

    /// <summary>
    /// Left foot, fourth digit
    /// </summary>
    public static readonly ProcedureModifier T3 = new(Values.T3);

    /// <summary>
    /// Left foot, fifth digit
    /// </summary>
    public static readonly ProcedureModifier T4 = new(Values.T4);

    /// <summary>
    /// Right foot, great toe
    /// </summary>
    public static readonly ProcedureModifier T5 = new(Values.T5);

    /// <summary>
    /// Right foot, second digit
    /// </summary>
    public static readonly ProcedureModifier T6 = new(Values.T6);

    /// <summary>
    /// Right foot, third digit
    /// </summary>
    public static readonly ProcedureModifier T7 = new(Values.T7);

    /// <summary>
    /// Right foot, fourth digit
    /// </summary>
    public static readonly ProcedureModifier T8 = new(Values.T8);

    /// <summary>
    /// Right foot, fifth digit
    /// </summary>
    public static readonly ProcedureModifier T9 = new(Values.T9);

    /// <summary>
    /// Left foot, great toe
    /// </summary>
    public static readonly ProcedureModifier Ta = new(Values.Ta);

    /// <summary>
    /// Drug or biological acquired with 340b drug pricing program discount, reported for informational purposes
    /// </summary>
    public static readonly ProcedureModifier Tb = new(Values.Tb);

    /// <summary>
    /// Technical Component
    /// </summary>
    public static readonly ProcedureModifier Tc = new(Values.Tc);

    /// <summary>
    /// Registered nurse (RN)
    /// </summary>
    public static readonly ProcedureModifier Td = new(Values.Td);

    /// <summary>
    /// Licensed vocational nurse (LVN) or licensed practical nurse (LPN)
    /// </summary>
    public static readonly ProcedureModifier Te = new(Values.Te);

    /// <summary>
    /// Intermediate level of care
    /// </summary>
    public static readonly ProcedureModifier Tf = new(Values.Tf);

    /// <summary>
    /// Complex/high tech level of care
    /// </summary>
    public static readonly ProcedureModifier Tg = new(Values.Tg);

    /// <summary>
    /// Obstetrical treatment/services, prenatal or postpart
    /// </summary>
    public static readonly ProcedureModifier Th = new(Values.Th);

    /// <summary>
    /// Program group, child and/or adolescent
    /// </summary>
    public static readonly ProcedureModifier Tj = new(Values.Tj);

    /// <summary>
    /// Extra patient or passenger, non-ambulance
    /// </summary>
    public static readonly ProcedureModifier Tk = new(Values.Tk);

    /// <summary>
    /// Early Intervention/Individualized Family Service Plan
    /// </summary>
    public static readonly ProcedureModifier Tl = new(Values.Tl);

    /// <summary>
    /// Individualized education program (IEP)
    /// </summary>
    public static readonly ProcedureModifier Tm = new(Values.Tm);

    /// <summary>
    /// Rural/outside providers' customary service area
    /// </summary>
    public static readonly ProcedureModifier Tn = new(Values.Tn);

    /// <summary>
    /// Medical transport, unloaded vehicle
    /// </summary>
    public static readonly ProcedureModifier Tp = new(Values.Tp);

    /// <summary>
    /// Basic life support transport by a volunteer ambulance provider
    /// </summary>
    public static readonly ProcedureModifier Tq = new(Values.Tq);

    /// <summary>
    /// School-based individualized education program (IEP) services provided outside the public school district
    /// </summary>
    public static readonly ProcedureModifier Tr = new(Values.Tr);

    /// <summary>
    /// Follow-up service
    /// </summary>
    public static readonly ProcedureModifier Ts = new(Values.Ts);

    /// <summary>
    /// Individualized service provided to more than one patient in same setting
    /// </summary>
    public static readonly ProcedureModifier Tt = new(Values.Tt);

    /// <summary>
    /// Special payment rate, overtime
    /// </summary>
    public static readonly ProcedureModifier Tu = new(Values.Tu);

    /// <summary>
    /// Special payment rates, holidays/weekends
    /// </summary>
    public static readonly ProcedureModifier Tv = new(Values.Tv);

    /// <summary>
    /// Back-up equipment
    /// </summary>
    public static readonly ProcedureModifier Tw = new(Values.Tw);

    /// <summary>
    /// Medicaid level of care 1, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier U1 = new(Values.U1);

    /// <summary>
    /// Medicaid level of care 2, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier U2 = new(Values.U2);

    /// <summary>
    /// Medicaid level of care 3, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier U3 = new(Values.U3);

    /// <summary>
    /// Medicaid level of care 4, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier U4 = new(Values.U4);

    /// <summary>
    /// Medicaid level of care 5, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier U5 = new(Values.U5);

    /// <summary>
    /// Medicaid level of care 6, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier U6 = new(Values.U6);

    /// <summary>
    /// Medicaid level of care 7, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier U7 = new(Values.U7);

    /// <summary>
    /// Medicaid level of care 8, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier U8 = new(Values.U8);

    /// <summary>
    /// Medicaid level of care 9, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier U9 = new(Values.U9);

    /// <summary>
    /// Medicaid level of care 10, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier Ua = new(Values.Ua);

    /// <summary>
    /// Medicaid level of care 11, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier Ub = new(Values.Ub);

    /// <summary>
    /// Medicaid level of care 12, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier Uc = new(Values.Uc);

    /// <summary>
    /// Medicaid level of care 13, as defined by each state
    /// </summary>
    public static readonly ProcedureModifier Ud = new(Values.Ud);

    /// <summary>
    /// Used durable medical equipment
    /// </summary>
    public static readonly ProcedureModifier Ue = new(Values.Ue);

    /// <summary>
    /// Services provided in the morning
    /// </summary>
    public static readonly ProcedureModifier Uf = new(Values.Uf);

    /// <summary>
    /// Services provided in the afternoon
    /// </summary>
    public static readonly ProcedureModifier Ug = new(Values.Ug);

    /// <summary>
    /// Services provided in the evening
    /// </summary>
    public static readonly ProcedureModifier Uh = new(Values.Uh);

    /// <summary>
    /// Services provided at night
    /// </summary>
    public static readonly ProcedureModifier Uj = new(Values.Uj);

    /// <summary>
    /// Services provided on behalf of the client to someone other than the client (collateral relationship)
    /// </summary>
    public static readonly ProcedureModifier Uk = new(Values.Uk);

    /// <summary>
    /// Two patients served
    /// </summary>
    public static readonly ProcedureModifier Un = new(Values.Un);

    /// <summary>
    /// Three patients served
    /// </summary>
    public static readonly ProcedureModifier Up = new(Values.Up);

    /// <summary>
    /// Four patients served
    /// </summary>
    public static readonly ProcedureModifier Uq = new(Values.Uq);

    /// <summary>
    /// Five patients served
    /// </summary>
    public static readonly ProcedureModifier Ur = new(Values.Ur);

    /// <summary>
    /// Six patients served
    /// </summary>
    public static readonly ProcedureModifier Us = new(Values.Us);

    /// <summary>
    /// One patient visit in a month
    /// </summary>
    public static readonly ProcedureModifier V1 = new(Values.V1);

    /// <summary>
    /// Two patient visits in a month
    /// </summary>
    public static readonly ProcedureModifier V2 = new(Values.V2);

    /// <summary>
    /// Three patient visits in a month
    /// </summary>
    public static readonly ProcedureModifier V3 = new(Values.V3);

    /// <summary>
    /// Indicates that the service was provided under a state-mandated reimbursement rate for workers' compensation claims
    /// </summary>
    public static readonly ProcedureModifier W1 = new(Values.W1);

    /// <summary>
    /// Used when a Medicare Set-Aside (MSA) account is used to pay for services related to a workers' compensation settlement
    /// </summary>
    public static readonly ProcedureModifier W2 = new(Values.W2);

    /// <summary>
    /// The treatment was approved under the workers’ compensation plan
    /// </summary>
    public static readonly ProcedureModifier W3 = new(Values.W3);

    /// <summary>
    /// Episodic/Focused Services - Reported by a specialty focused clinician who provides care that is time-limited
    /// </summary>
    public static readonly ProcedureModifier X4 = new(Values.X4);

    /// <summary>
    /// Two or more separate patient visits on the same date of service
    /// </summary>
    public static readonly ProcedureModifier Xe = new(Values.Xe);

    /// <summary>
    /// A service that is distinct because it was performed by a different practitioner
    /// </summary>
    public static readonly ProcedureModifier Xp = new(Values.Xp);

    /// <summary>
    /// A service that is distinct because it was performed on a separate organ/structure
    /// </summary>
    public static readonly ProcedureModifier Xs = new(Values.Xs);

    /// <summary>
    /// The use of a service that is distinct because it does not overlap usual components of the main service
    /// </summary>
    public static readonly ProcedureModifier Xu = new(Values.Xu);

    /// <summary>
    /// Custom modifier
    /// </summary>
    public static readonly ProcedureModifier Xy = new(Values.Xy);

    public ProcedureModifier(string value)
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
    public static ProcedureModifier FromCustom(string value)
    {
        return new ProcedureModifier(value);
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

    public static bool operator ==(ProcedureModifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ProcedureModifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ProcedureModifier value) => value.Value;

    public static explicit operator ProcedureModifier(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Ambulance service provided as a volunteer ambulance service organization as defined by the state
        /// </summary>
        public const string Av = "AV";

        /// <summary>
        /// Item furnished in conjunction with a urological, ostomy, or tracheostomy supply
        /// </summary>
        public const string Au = "AU";

        /// <summary>
        /// Item furnished in conjunction with dialysis services
        /// </summary>
        public const string Aw = "AW";

        public const string Seven = "07";

        public const string Eight = "08";

        public const string Nine = "09";

        public const string Ten = "10";

        public const string Eleven = "11";

        public const string Twelve = "12";

        public const string Thirteen = "13";

        public const string Fourteen = "14";

        public const string Fifteen = "15";

        public const string Sixteen = "16";

        /// <summary>
        /// Increased Procedural Services
        /// </summary>
        public const string TwentyTwo = "22";

        /// <summary>
        /// Unusual Anesthesia
        /// </summary>
        public const string TwentyThree = "23";

        /// <summary>
        /// Unrelated Evaluation and Management Service by the Same Physician or Other Qualified Health Care Professional During a Postoperative Period
        /// </summary>
        public const string TwentyFour = "24";

        /// <summary>
        /// Significant, Separately Identifiable Evaluation and Management Service by the Same Physician or Other Qualified Health Care Professional on the Same Day of the Procedure or Other Service
        /// </summary>
        public const string TwentyFive = "25";

        /// <summary>
        /// Professional Component
        /// </summary>
        public const string TwentySix = "26";

        /// <summary>
        /// Multiple Outpatient Hospital E/M Encounters on the Same Date
        /// </summary>
        public const string TwentySeven = "27";

        public const string TwentyEight = "28";

        /// <summary>
        /// Mandated Services
        /// </summary>
        public const string ThirtyTwo = "32";

        /// <summary>
        /// Preventive Services
        /// </summary>
        public const string ThirtyThree = "33";

        /// <summary>
        /// Anesthesia by Surgeon
        /// </summary>
        public const string FortySeven = "47";

        /// <summary>
        /// Bilateral Procedure
        /// </summary>
        public const string Fifty = "50";

        /// <summary>
        /// Multiple Procedures
        /// </summary>
        public const string FiftyOne = "51";

        /// <summary>
        /// Reduced Services
        /// </summary>
        public const string FiftyTwo = "52";

        /// <summary>
        /// Discontinued Procedure
        /// </summary>
        public const string FiftyThree = "53";

        /// <summary>
        /// Surgical Care Only
        /// </summary>
        public const string FiftyFour = "54";

        /// <summary>
        /// Postoperative Management Only
        /// </summary>
        public const string FiftyFive = "55";

        /// <summary>
        /// Preoperative Management Only
        /// </summary>
        public const string FiftySix = "56";

        /// <summary>
        /// Decision for Surgery
        /// </summary>
        public const string FiftySeven = "57";

        /// <summary>
        /// Staged or Related Procedure or Service by the Same Physician or Other Qualified Health Care Professional During the Postoperative Period
        /// </summary>
        public const string FiftyEight = "58";

        /// <summary>
        /// Distinct Procedural Service
        /// </summary>
        public const string FiftyNine = "59";

        /// <summary>
        /// Two Surgeons
        /// </summary>
        public const string SixtyTwo = "62";

        /// <summary>
        /// Procedure Performed on Infants less than 4 kg
        /// </summary>
        public const string SixtyThree = "63";

        /// <summary>
        /// Surgical Team
        /// </summary>
        public const string SixtySix = "66";

        /// <summary>
        /// Discontinued Outpatient Hospital/Ambulatory Surgery Center (ASC) Procedure After Administration of Anesthesia
        /// </summary>
        public const string SeventyFour = "74";

        /// <summary>
        /// Repeat Procedure or Service by Same Physician or Other Qualified Health Care Professional
        /// </summary>
        public const string SeventySix = "76";

        /// <summary>
        /// Repeat Procedure by Another Physician or Other Qualified Health Care Professional
        /// </summary>
        public const string SeventySeven = "77";

        /// <summary>
        /// Unplanned Return to the Operating/Procedure Room by the Same Physician or Other Qualified Health Care Professional Following Initial Procedure for a Related Procedure During the Postoperative Period
        /// </summary>
        public const string SeventyEight = "78";

        /// <summary>
        /// Unrelated Procedure or Service by the Same Physician or Other Qualified Health Care Professional During the Postoperative Period
        /// </summary>
        public const string SeventyNine = "79";

        /// <summary>
        /// Assistant Surgeon
        /// </summary>
        public const string Eighty = "80";

        /// <summary>
        /// Minimum Assistant Surgeon
        /// </summary>
        public const string EightyOne = "81";

        /// <summary>
        /// Assistant Surgeon (when qualified resident surgeon not available)
        /// </summary>
        public const string EightyTwo = "82";

        /// <summary>
        /// Reference (Outside) Laboratory
        /// </summary>
        public const string Ninety = "90";

        /// <summary>
        /// Repeat Clinical Diagnostic Laboratory Test
        /// </summary>
        public const string NinetyOne = "91";

        /// <summary>
        /// Alternative Laboratory Platform Testing
        /// </summary>
        public const string NinetyTwo = "92";

        /// <summary>
        /// Synchronous Telemedicine Service Rendered Via Telephone or Other Real-Time Interactive Audio-Only Telecommunications System
        /// </summary>
        public const string NinetyThree = "93";

        /// <summary>
        /// Synchronous Telemedicine Service Rendered via a Real-Time Interactive Audio and Video Telecommunications System
        /// </summary>
        public const string NinetyFive = "95";

        /// <summary>
        /// Habilitative Services
        /// </summary>
        public const string NinetySix = "96";

        /// <summary>
        /// Rehabilitative Services
        /// </summary>
        public const string NinetySeven = "97";

        /// <summary>
        /// Multiple Modifiers
        /// </summary>
        public const string NinetyNine = "99";

        /// <summary>
        /// Dressing for one wound
        /// </summary>
        public const string A1 = "A1";

        /// <summary>
        /// Dressing for two wounds
        /// </summary>
        public const string A2 = "A2";

        /// <summary>
        /// Dressing for three wounds
        /// </summary>
        public const string A3 = "A3";

        /// <summary>
        /// Dressing for four wounds
        /// </summary>
        public const string A4 = "A4";

        /// <summary>
        /// Dressing for five wounds
        /// </summary>
        public const string A5 = "A5";

        /// <summary>
        /// Dressing for six wounds
        /// </summary>
        public const string A6 = "A6";

        /// <summary>
        /// Dressing for seven wounds
        /// </summary>
        public const string A7 = "A7";

        /// <summary>
        /// Dressing for eight wounds
        /// </summary>
        public const string A8 = "A8";

        /// <summary>
        /// Dressing for nine wounds
        /// </summary>
        public const string A9 = "A9";

        /// <summary>
        /// Anesthesia services performed personally by anesthesiologist
        /// </summary>
        public const string Aa = "AA";

        /// <summary>
        /// Audiology service furnished personally by an audiologist without a physician/npp order for non-acute hearing assessment ...
        /// </summary>
        public const string Ab = "AB";

        /// <summary>
        /// Medical supervision by a physician: more than four concurrent anesthesia procedures
        /// </summary>
        public const string Ad = "AD";

        /// <summary>
        /// Registered dietician
        /// </summary>
        public const string Ae = "AE";

        /// <summary>
        /// Specialty physician
        /// </summary>
        public const string Af = "AF";

        /// <summary>
        /// Primary physician
        /// </summary>
        public const string Ag = "AG";

        /// <summary>
        /// Clinical psychologist
        /// </summary>
        public const string Ah = "AH";

        /// <summary>
        /// Principal physician of record
        /// </summary>
        public const string Ai = "AI";

        /// <summary>
        /// Clinical social worker
        /// </summary>
        public const string Aj = "AJ";

        /// <summary>
        /// Non participating physician
        /// </summary>
        public const string Ak = "AK";

        /// <summary>
        /// Physician, team member service
        /// </summary>
        public const string Am = "AM";

        /// <summary>
        /// Alternate payment method declined by provider of service
        /// </summary>
        public const string Ao = "AO";

        /// <summary>
        /// Determination of refractive state was not performed in the course of diagnostic ophthalmological examination
        /// </summary>
        public const string Ap = "AP";

        /// <summary>
        /// Physician providing a service in an unlisted health professional shortage area (hpsa)
        /// </summary>
        public const string Aq = "AQ";

        /// <summary>
        /// Physician provider services in a physician scarcity area
        /// </summary>
        public const string Ar = "AR";

        /// <summary>
        /// Physician assistant, nurse practitioner, or clinical nurse specialist services for assistant at surgery
        /// </summary>
        public const string As = "AS";

        /// <summary>
        /// Acute treatment
        /// </summary>
        public const string At = "AT";

        /// <summary>
        /// Physician providing a service in a dental health professional shortage area for the purpose of an EHR incentive payment
        /// </summary>
        public const string Az = "AZ";

        /// <summary>
        /// Item furnished in conjunction with parenteral enteral nutrition (pen) services
        /// </summary>
        public const string Ba = "BA";

        /// <summary>
        /// Special acquisition of blood and blood products
        /// </summary>
        public const string Bl = "BL";

        /// <summary>
        /// Orally administered nutrition, not by feeding tube
        /// </summary>
        public const string Bo = "BO";

        /// <summary>
        /// The beneficiary has been informed of the purchase and rental options and has elected to purchase the item
        /// </summary>
        public const string Bp = "BP";

        /// <summary>
        /// The beneficiary has been informed of the purchase and rental options and has elected to rent the item
        /// </summary>
        public const string Br = "BR";

        /// <summary>
        /// The beneficiary has been informed of the purchase and rental options and after 30 days has not informed the supplier
        /// </summary>
        public const string Bu = "BU";

        /// <summary>
        /// Procedure payable only in the inpatient setting when performed emergently on an outpatient who expires prior to admission
        /// </summary>
        public const string Ca = "CA";

        /// <summary>
        /// Service ordered by a renal dialysis facility (rdf) physician as part of the ESRD beneficiary's dialysis benefit
        /// </summary>
        public const string Cb = "CB";

        /// <summary>
        /// Procedure code change
        /// </summary>
        public const string Cc = "CC";

        /// <summary>
        /// Amcc test has been ordered by an ESRD facility or MCP physician that is not separately billable
        /// </summary>
        public const string Cd = "CD";

        /// <summary>
        /// Amcc test has been ordered by an esrd facility or mcp physician that is beyond the normal frequency covered
        /// </summary>
        public const string Ce = "CE";

        /// <summary>
        /// Amcc test has been ordered by an esrd facility or mcp physician that is separately billable
        /// </summary>
        public const string Cf = "CF";

        /// <summary>
        /// Policy criteria applied
        /// </summary>
        public const string Cg = "CG";

        /// <summary>
        /// 0 percent impaired, limited or restricted
        /// </summary>
        public const string Ch = "CH";

        /// <summary>
        /// At least 1 percent but less than 20 percent impaired, limited or restricted
        /// </summary>
        public const string Ci = "CI";

        /// <summary>
        /// At least 20 percent but less than 40 percent impaired, limited or restricted
        /// </summary>
        public const string Cj = "CJ";

        /// <summary>
        /// At least 40 percent but less than 60 percent impaired, limited or restricted
        /// </summary>
        public const string Ck = "CK";

        /// <summary>
        /// At least 60 percent but less than 80 percent impaired, limited or restricted
        /// </summary>
        public const string Cl = "CL";

        /// <summary>
        /// At least 80 percent but less than 100 percent impaired, limited or restricted
        /// </summary>
        public const string Cm = "CM";

        /// <summary>
        /// 100 percent impaired, limited or restricted
        /// </summary>
        public const string Cn = "CN";

        /// <summary>
        /// Catastrophe/disaster related
        /// </summary>
        public const string Cr = "CR";

        /// <summary>
        /// Cost sharing for COVID-19 testing
        /// </summary>
        public const string Cs = "CS";

        /// <summary>
        /// Computed tomography services furnished using equipment that does not meet xr-29-2013 standard
        /// </summary>
        public const string Ct = "CT";

        /// <summary>
        /// Outpatient physical therapy services furnished in whole or in part by a occupational therapist assistant
        /// </summary>
        public const string Co = "CO";

        /// <summary>
        /// Outpatient physical therapy services furnished in whole or in part by a physical therapist assistant
        /// </summary>
        public const string Cq = "CQ";

        /// <summary>
        /// Oral health assessment by a licensed health professional other than a dentist
        /// </summary>
        public const string Da = "DA";

        /// <summary>
        /// Upper left, eyelid
        /// </summary>
        public const string E1 = "E1";

        /// <summary>
        /// Lower left, eyelid
        /// </summary>
        public const string E2 = "E2";

        /// <summary>
        /// Upper right, eyelid
        /// </summary>
        public const string E3 = "E3";

        /// <summary>
        /// Lower right, eyelid
        /// </summary>
        public const string E4 = "E4";

        /// <summary>
        /// Erythropoetic stimulating agent (esa) administered to treat anemia due to anti-cancer chemotherapy
        /// </summary>
        public const string Ea = "EA";

        /// <summary>
        /// Erythropoetic stimulating agent (esa) administered to treat anemia due to anti-cancer radiotherapy
        /// </summary>
        public const string Eb = "EB";

        /// <summary>
        /// Erythropoetic stimulating agent (esa) administered to treat anemia not due to anti-cancer radiotherapy or chemotherapy
        /// </summary>
        public const string Ec = "EC";

        /// <summary>
        /// Hematocrit level has exceeded 39% (or hemoglobin level has exceeded 13.0 g/dl) for 3 or more consecutive billing cycles
        /// </summary>
        public const string Ed = "ED";

        /// <summary>
        /// Hematocrit level has not exceeded 39% (or hemoglobin level has not exceeded 13.0 g/dl) for 3 or more billing cycles
        /// </summary>
        public const string Ee = "EE";

        /// <summary>
        /// Subsequent claims for a defined course of therapy, e.g., epo, sodium hyaluronate, infliximab
        /// </summary>
        public const string Ej = "EJ";

        /// <summary>
        /// Emergency reserve supply (for esrd benefit only)
        /// </summary>
        public const string Em = "EM";

        /// <summary>
        /// Service provided as part of medicaid early periodic screening diagnosis and treatment (epsdt) program
        /// </summary>
        public const string Ep = "EP";

        /// <summary>
        /// Items and services furnished by a provider-based, off-campus emergency department
        /// </summary>
        public const string Er = "ER";

        /// <summary>
        /// Emergency services
        /// </summary>
        public const string Et = "ET";

        /// <summary>
        /// Electronic visit verification
        /// </summary>
        public const string Ev = "EV";

        /// <summary>
        /// Expatriate beneficiary
        /// </summary>
        public const string Ex = "EX";

        /// <summary>
        /// No physician or other licensed health care provider order for this item or service
        /// </summary>
        public const string Ey = "EY";

        /// <summary>
        /// Left hand, second digit
        /// </summary>
        public const string F1 = "F1";

        /// <summary>
        /// Left hand, third digit
        /// </summary>
        public const string F2 = "F2";

        /// <summary>
        /// Left hand, fourth digit
        /// </summary>
        public const string F3 = "F3";

        /// <summary>
        /// Left hand, fifth digit
        /// </summary>
        public const string F4 = "F4";

        /// <summary>
        /// Right hand, thumb
        /// </summary>
        public const string F5 = "F5";

        /// <summary>
        /// Right hand, second digit
        /// </summary>
        public const string F6 = "F6";

        /// <summary>
        /// Right hand, third digit
        /// </summary>
        public const string F7 = "F7";

        /// <summary>
        /// Right hand, fourth digit
        /// </summary>
        public const string F8 = "F8";

        /// <summary>
        /// Right hand, fifth digit
        /// </summary>
        public const string F9 = "F9";

        /// <summary>
        /// Right hand, thumb
        /// </summary>
        public const string Fa = "FA";

        /// <summary>
        /// Item provided without cost to provider, supplier or practitioner, or full credit received for replaced device
        /// </summary>
        public const string Fb = "FB";

        /// <summary>
        /// Partial credit received for replaced device
        /// </summary>
        public const string Fc = "FC";

        /// <summary>
        /// Service provided as part of family planning program
        /// </summary>
        public const string Fp = "FP";

        /// <summary>
        /// Telehealth service furnished using real-time audio-only communication technology.
        /// </summary>
        public const string Fq = "FQ";

        /// <summary>
        /// A supervising practitioner was present through a real-time two-way, audio/video communication technology.
        /// </summary>
        public const string Fr = "FR";

        /// <summary>
        /// Split (or shared) evaluation and management visit.
        /// </summary>
        public const string Fs = "FS";

        /// <summary>
        /// Unrelated evaluation and management (e/m) visit on the same day as another e/m visit or during a global procedure
        /// </summary>
        public const string Ft = "FT";

        /// <summary>
        /// X-ray taken using film
        /// </summary>
        public const string Fx = "FX";

        /// <summary>
        /// X-ray taken using computed radiography technology/cassette-based imaging
        /// </summary>
        public const string Fy = "FY";

        /// <summary>
        /// Telehealth Services For Diagnosis, Evaluation, Or Treatment, Of Symptoms Of An Acute Stroke
        /// </summary>
        public const string G0 = "G0";

        /// <summary>
        /// Most recent urr reading of less than 60
        /// </summary>
        public const string G1 = "G1";

        /// <summary>
        /// Most recent urr reading of 60 to 64.9
        /// </summary>
        public const string G2 = "G2";

        /// <summary>
        /// Most recent urr reading of 65 to 69.9
        /// </summary>
        public const string G3 = "G3";

        /// <summary>
        /// Most recent urr reading of 70 to 74.9
        /// </summary>
        public const string G4 = "G4";

        /// <summary>
        /// Most recent urr reading of 75 or greater
        /// </summary>
        public const string G5 = "G5";

        /// <summary>
        /// ESRD patient for whom less than six dialysis sessions have been provided in a month
        /// </summary>
        public const string G6 = "G6";

        /// <summary>
        /// Pregnancy resulted from rape or incest or pregnancy certified by physician as life threatening
        /// </summary>
        public const string G7 = "G7";

        /// <summary>
        /// Monitored anesthesia care (mac) for deep complex, complicated, or markedly invasive surgical procedure
        /// </summary>
        public const string G8 = "G8";

        /// <summary>
        /// Monitored anesthesia care for patient who has history of severe cardio-pulmonary condition
        /// </summary>
        public const string G9 = "G9";

        /// <summary>
        /// Waiver of liability statement issued as required by payer policy, individual case
        /// </summary>
        public const string Ga = "GA";

        /// <summary>
        /// Claim being re-submitted for payment because it is no longer covered under a global payment demonstration
        /// </summary>
        public const string Gb = "GB";

        /// <summary>
        /// This service has been performed in part by a resident under the direction of a teaching physician
        /// </summary>
        public const string Gc = "GC";

        /// <summary>
        /// This service has been performed by a resident without the presence of a teaching physician under the primary care exception
        /// </summary>
        public const string Ge = "GE";

        /// <summary>
        /// Non-physician (e.g. nurse practitioner (np), certified registered nurse anesthetist (crna), certified registered nurse (crn), clinical nurse specialist (cns), physician assistant (pa)) services in a critical access hospital
        /// </summary>
        public const string Gf = "GF";

        /// <summary>
        /// Performance and payment of a screening mammogram and diagnostic mammogram on the same patient, same day
        /// </summary>
        public const string Gg = "GG";

        /// <summary>
        /// Diagnostic mammogram converted from screening mammogram on same day
        /// </summary>
        public const string Gh = "GH";

        /// <summary>
        /// opt out physician or practitioner emergency or urgent service
        /// </summary>
        public const string Gj = "GJ";

        /// <summary>
        /// Reasonable and necessary item/service associated with a ga or gz modifier
        /// </summary>
        public const string Gk = "GK";

        /// <summary>
        /// Medically unnecessary upgrade provided instead of non-upgraded item, no charge, no advance beneficiary notice (abn)
        /// </summary>
        public const string Gl = "GL";

        /// <summary>
        /// Multiple patients on one ambulance trip
        /// </summary>
        public const string Gm = "GM";

        /// <summary>
        /// Services delivered under an outpatient speech-language pathology plan of care
        /// </summary>
        public const string Gn = "GN";

        /// <summary>
        /// Service delivered personally by an occupational therapist or under an outpatient occupational therapy plan of care
        /// </summary>
        public const string Go = "GO";

        /// <summary>
        /// Service delivered personally by a physical therapist or under an outpatient physical therapy plan of care
        /// </summary>
        public const string Gp = "GP";

        /// <summary>
        /// Services provided via an asynchronous telecommunications system
        /// </summary>
        public const string Gq = "GQ";

        /// <summary>
        /// This service was performed in whole or in part by a resident in a department of veterans affairs medical center or clinic, supervised in accordance with va policy
        /// </summary>
        public const string Gr = "GR";

        /// <summary>
        /// Dosage of erythropoietin stimulating agent has been reduced and maintained in response to hematocrit or hemoglobin level
        /// </summary>
        public const string Gs = "GS";

        /// <summary>
        /// Services took place via an interactive audio and video telecommunications system
        /// </summary>
        public const string Gt = "GT";

        /// <summary>
        /// Waiver of liability statement issued as required by payer policy, routine notice
        /// </summary>
        public const string Gu = "GU";

        /// <summary>
        /// Attending physician not employed or paid under arrangement by the patient's hospice provider
        /// </summary>
        public const string Gv = "GV";

        /// <summary>
        /// Service not related to the hospice patient's terminal condition
        /// </summary>
        public const string Gw = "GW";

        /// <summary>
        /// Notice of liability issued, voluntary under payer policy
        /// </summary>
        public const string Gx = "GX";

        /// <summary>
        /// Not a covered benefit
        /// </summary>
        public const string Gy = "GY";

        /// <summary>
        /// Item or service expected to be denied as not reasonable and necessary
        /// </summary>
        public const string Gz = "GZ";

        /// <summary>
        /// Child/adolescent program
        /// </summary>
        public const string Ha = "HA";

        /// <summary>
        /// Adult program, non geriatric
        /// </summary>
        public const string Hb = "HB";

        /// <summary>
        /// Adult program, geriatric
        /// </summary>
        public const string Hc = "HC";

        /// <summary>
        /// Pregnant/parenting women's program
        /// </summary>
        public const string Hd = "HD";

        /// <summary>
        /// Mental health program
        /// </summary>
        public const string He = "HE";

        /// <summary>
        /// Substance abuse program
        /// </summary>
        public const string Hf = "HF";

        /// <summary>
        /// Opioid addiction treatment program
        /// </summary>
        public const string Hg = "HG";

        /// <summary>
        /// Integrated mental health/substance abuse program
        /// </summary>
        public const string Hh = "HH";

        /// <summary>
        /// Integrated mental health and intellectual disability/developmental disabilities program
        /// </summary>
        public const string Hi = "HI";

        /// <summary>
        /// Employee assistance program
        /// </summary>
        public const string Hj = "HJ";

        /// <summary>
        /// Specialized mental health programs for high-risk populations
        /// </summary>
        public const string Hk = "HK";

        /// <summary>
        /// Intern
        /// </summary>
        public const string Hl = "HL";

        /// <summary>
        /// The rendering provider has a highest educational attainment of less than a bachelor's degree
        /// </summary>
        public const string Hm = "HM";

        /// <summary>
        /// The rendering provider has a highest educational attainment of a bachelor's degree
        /// </summary>
        public const string Hn = "HN";

        /// <summary>
        /// The rendering provider has a highest educational attainment of a master's degree
        /// </summary>
        public const string Ho = "HO";

        /// <summary>
        /// The rendering provider has a highest educational attainment of a doctoral degree
        /// </summary>
        public const string Hp = "HP";

        /// <summary>
        /// Group setting
        /// </summary>
        public const string Hq = "HQ";

        /// <summary>
        /// Family/couple with client present
        /// </summary>
        public const string Hr = "HR";

        /// <summary>
        /// Family/couple without client present
        /// </summary>
        public const string Hs = "HS";

        /// <summary>
        /// Multi-disciplinary team
        /// </summary>
        public const string Ht = "HT";

        /// <summary>
        /// Funded by child welfare agency
        /// </summary>
        public const string Hu = "HU";

        /// <summary>
        /// Funded by state addictions agency
        /// </summary>
        public const string Hv = "HV";

        /// <summary>
        /// Funded by state mental health agency
        /// </summary>
        public const string Hw = "HW";

        /// <summary>
        /// Funded by county/local agency
        /// </summary>
        public const string Hx = "HX";

        /// <summary>
        /// Funded by juvenile justice agency
        /// </summary>
        public const string Hy = "HY";

        /// <summary>
        /// Funded by criminal justice agency
        /// </summary>
        public const string Hz = "HZ";

        /// <summary>
        /// Competitive acquisition program no-pay submission for a prescription number
        /// </summary>
        public const string J1 = "J1";

        /// <summary>
        /// Competitive acquisition program, restocking of emergency drugs after emergency administration
        /// </summary>
        public const string J2 = "J2";

        /// <summary>
        /// Competitive acquisition program (cap) reimbursed under average sales price methodology
        /// </summary>
        public const string J3 = "J3";

        /// <summary>
        /// DMEPOS item subject to DMEPOS competitive bidding program that is furnished by a hospital upon discharge
        /// </summary>
        public const string J4 = "J4";

        /// <summary>
        /// Off-the-shelf orthotic subject to DMEPOS competitive bidding program
        /// </summary>
        public const string J5 = "J5";

        /// <summary>
        /// Administered intravenously
        /// </summary>
        public const string Ja = "JA";

        /// <summary>
        /// Administered subcutaneously
        /// </summary>
        public const string Jb = "JB";

        /// <summary>
        /// Skin substitute used as a graft
        /// </summary>
        public const string Jc = "JC";

        /// <summary>
        /// Skin substitute not used as a graft
        /// </summary>
        public const string Jd = "JD";

        /// <summary>
        /// Administered via dialysate
        /// </summary>
        public const string Je = "JE";

        /// <summary>
        /// Drug or biological acquired with 340b drug pricing program discount
        /// </summary>
        public const string Jg = "JG";

        /// <summary>
        /// Drug amount discarded/not administered to any patient
        /// </summary>
        public const string Jw = "JW";

        /// <summary>
        /// Zero drug amount discarded/not administered to any patient
        /// </summary>
        public const string Jz = "JZ";

        /// <summary>
        /// Lower extremity prosthesis functional level 0
        /// </summary>
        public const string K0 = "K0";

        /// <summary>
        /// Lower extremity prosthesis functional level 1
        /// </summary>
        public const string K1 = "K1";

        /// <summary>
        /// Lower extremity prosthesis functional level 2
        /// </summary>
        public const string K2 = "K2";

        /// <summary>
        /// Lower extremity prosthesis functional level 3
        /// </summary>
        public const string K3 = "K3";

        /// <summary>
        /// Lower extremity prosthesis functional level 4
        /// </summary>
        public const string K4 = "K4";

        /// <summary>
        /// Add on option/accessory for wheelchair
        /// </summary>
        public const string Ka = "KA";

        /// <summary>
        /// Beneficiary requested upgrade for abn, more than 4 modifiers identified on claim
        /// </summary>
        public const string Kb = "KB";

        /// <summary>
        /// Replacement of special power wheelchair interface
        /// </summary>
        public const string Kc = "KC";

        /// <summary>
        /// Drug or biological infused through DME
        /// </summary>
        public const string Kd = "KD";

        /// <summary>
        /// Bid under round one of the DMEPOS competitive bidding program
        /// </summary>
        public const string Ke = "KE";

        /// <summary>
        /// Item designated by FDA as class III device
        /// </summary>
        public const string Kf = "KF";

        /// <summary>
        /// DMEPOS item subject to DMEPOS competitive bidding program number 1
        /// </summary>
        public const string Kg = "KG";

        /// <summary>
        /// DMEPOS item, initial claim, purchase or first month rental
        /// </summary>
        public const string Kh = "KH";

        /// <summary>
        /// DMEPOS item, second or third month rental
        /// </summary>
        public const string Ki = "KI";

        /// <summary>
        /// DMEPOS item, parenteral enteral nutrition (pen) pump or capped rental, months four to fifteen
        /// </summary>
        public const string Kj = "KJ";

        /// <summary>
        /// DMEPOS item subject to DMEPOS competitive bidding program number 2
        /// </summary>
        public const string Kk = "KK";

        /// <summary>
        /// DMEPOS item delivered via mail
        /// </summary>
        public const string Kl = "KL";

        /// <summary>
        /// Replacement of facial prosthesis including new impression/moulage
        /// </summary>
        public const string Km = "KM";

        /// <summary>
        /// Replacement of facial prosthesis using previous master model
        /// </summary>
        public const string Kn = "KN";

        /// <summary>
        /// Single drug unit dose formulation
        /// </summary>
        public const string Ko = "KO";

        /// <summary>
        /// First drug of a multiple drug unit dose formulation
        /// </summary>
        public const string Kp = "KP";

        /// <summary>
        /// Second or subsequent drug of a multiple drug unit dose formulation
        /// </summary>
        public const string Kq = "KQ";

        /// <summary>
        /// Rental item, billing for partial month
        /// </summary>
        public const string Kr = "KR";

        /// <summary>
        /// Glucose monitor supply for diabetic beneficiary not treated with insulin
        /// </summary>
        public const string Ks = "KS";

        /// <summary>
        /// Beneficiary resides in a competitive bidding area and travels outside that competitive bidding area
        /// </summary>
        public const string Kt = "KT";

        /// <summary>
        /// DMEPOS item subject to DMEPOS competitive bidding program number 3
        /// </summary>
        public const string Ku = "KU";

        /// <summary>
        /// DMEPOS item subject to DMEPOS competitive bidding program that is furnished as part of a professional service
        /// </summary>
        public const string Kv = "KV";

        /// <summary>
        /// DMEPOS item subject to DMEPOS competitive bidding program number 4
        /// </summary>
        public const string Kw = "KW";

        /// <summary>
        /// Requirements specified in the medical policy have been met
        /// </summary>
        public const string Kx = "KX";

        /// <summary>
        /// DMEPOS item subject to DMEPOS competitive bidding program number 5
        /// </summary>
        public const string Ky = "KY";

        /// <summary>
        /// New coverage not implemented by managed care
        /// </summary>
        public const string Kz = "KZ";

        /// <summary>
        /// Left circumflex coronary artery
        /// </summary>
        public const string Lc = "LC";

        /// <summary>
        /// Left anterior descending coronary artery
        /// </summary>
        public const string Ld = "LD";

        /// <summary>
        /// Lease/rental
        /// </summary>
        public const string Ll = "LL";

        /// <summary>
        /// Left main coronary artery
        /// </summary>
        public const string Lm = "LM";

        /// <summary>
        /// Laboratory round trip
        /// </summary>
        public const string Lr = "LR";

        /// <summary>
        /// FDA-monitored intraocular lens implant
        /// </summary>
        public const string Ls = "LS";

        /// <summary>
        /// Left side (used to identify procedures performed on the left side of the body)
        /// </summary>
        public const string Lt = "LT";

        /// <summary>
        /// Fractionated payment of CAR-T therapy
        /// </summary>
        public const string Lu = "LU";

        /// <summary>
        /// Medicare secondary payer
        /// </summary>
        public const string M2 = "M2";

        /// <summary>
        /// Not required to consult clinical decision support... for patient with a suspected or confirmed emergency medical condition
        /// </summary>
        public const string Ma = "MA";

        /// <summary>
        /// Not required to consult clinical decision support mechanism due to insufficient internet access
        /// </summary>
        public const string Mb = "MB";

        /// <summary>
        /// Not required to consult clinical decision support mechanism due to electronic health record vendor issues
        /// </summary>
        public const string Mc = "MC";

        /// <summary>
        /// Not required to consult clinical decision support mechanism due to extreme/uncontrollable circumstances
        /// </summary>
        public const string Md = "MD";

        /// <summary>
        /// Adheres to appropriate use criteria in the clinical decision support mechanism consulted by the ordering professional
        /// </summary>
        public const string Me = "ME";

        /// <summary>
        /// Does not adhere to the criteria in the clinical decision support mechanism consulted by the ordering professional
        /// </summary>
        public const string Mf = "MF";

        /// <summary>
        /// Does not have appropriate use criteria in the clinical decision support mechanism consulted by the ordering professional
        /// </summary>
        public const string Mg = "MG";

        /// <summary>
        /// Unknown if ordering professional consulted a clinical decision support mechanism for this service
        /// </summary>
        public const string Mh = "MH";

        /// <summary>
        /// Six month maintenance and servicing fee for parts and labor, not covered under any manufacturer or supplier warranty
        /// </summary>
        public const string Ms = "MS";

        /// <summary>
        /// Group 1 oxygen coverage criteria met
        /// </summary>
        public const string N1 = "N1";

        /// <summary>
        /// Group 2 oxygen coverage criteria met
        /// </summary>
        public const string N2 = "N2";

        /// <summary>
        /// Group 3 oxygen coverage criteria met
        /// </summary>
        public const string N3 = "N3";

        /// <summary>
        /// Nebulizer system, any type, FDA-cleared for use with specific drug
        /// </summary>
        public const string Nb = "NB";

        /// <summary>
        /// New when rented
        /// </summary>
        public const string Nr = "NR";

        /// <summary>
        /// New durable medical equipment purchase
        /// </summary>
        public const string Nu = "NU";

        /// <summary>
        /// A normal healthy patient
        /// </summary>
        public const string P1 = "P1";

        /// <summary>
        /// A patient with a mild systemic disease
        /// </summary>
        public const string P2 = "P2";

        /// <summary>
        /// A patient with severe systemic disease
        /// </summary>
        public const string P3 = "P3";

        /// <summary>
        /// A patient with severe systemic disease that is a constant threat to life
        /// </summary>
        public const string P4 = "P4";

        /// <summary>
        /// A moribund patient who is not expected to survive without the operation
        /// </summary>
        public const string P5 = "P5";

        /// <summary>
        /// A declared brain-dead patient whose organs are being removed for donor purposes
        /// </summary>
        public const string P6 = "P6";

        /// <summary>
        /// Surgical or other invasive procedure on wrong body part
        /// </summary>
        public const string Pa = "PA";

        /// <summary>
        /// Surgical or other invasive procedure on wrong patient
        /// </summary>
        public const string Pb = "PB";

        /// <summary>
        /// Wrong surgery or other invasive procedure on patient
        /// </summary>
        public const string Pc = "PC";

        /// <summary>
        /// Diagnostic or related non diagnostic item or service provided in a wholly owned or operated entity to a patient who is admitted as an inpatient within 3 days
        /// </summary>
        public const string Pd = "PD";

        /// <summary>
        /// Positron emission tomography (PET) or PET/computed tomography (CT)
        /// </summary>
        public const string Pi = "PI";

        /// <summary>
        /// Progressive addition lenses
        /// </summary>
        public const string Pl = "PL";

        /// <summary>
        /// Post-mortem
        /// </summary>
        public const string Pm = "PM";

        /// <summary>
        /// Non-excepted service provided at an off-campus, outpatient, provider-based department of a hospital
        /// </summary>
        public const string Pn = "PN";

        /// <summary>
        /// Excepted service provided at an off-campus, outpatient, provider-based department of a hospital
        /// </summary>
        public const string Po = "PO";

        /// <summary>
        /// Positron emission tomography (PET) or pet/computed tomography (CT) to inform the treatment strategy of cancerous tumors
        /// </summary>
        public const string Ps = "PS";

        /// <summary>
        /// Colorectal cancer screening test; converted to diagnostic test or other procedure
        /// </summary>
        public const string Pt = "PT";

        /// <summary>
        /// Investigational clinical service provided in a clinical research study that is in an approved clinical research study
        /// </summary>
        public const string Q0 = "Q0";

        /// <summary>
        /// Routine clinical service provided in a clinical research study that is in an approved clinical research study
        /// </summary>
        public const string Q1 = "Q1";

        /// <summary>
        /// Demonstration procedure/service
        /// </summary>
        public const string Q2 = "Q2";

        /// <summary>
        /// Live kidney donor surgery and related services
        /// </summary>
        public const string Q3 = "Q3";

        /// <summary>
        /// Service for ordering/referring physician qualifies as a service exemption
        /// </summary>
        public const string Q4 = "Q4";

        /// <summary>
        /// Service furnished under a reciprocal billing arrangement by a substitute physician; or by a substitute physical therapist furnishing outpatient physical therapy services in a health professional shortage area, a medically underserved area, or a rural area
        /// </summary>
        public const string Q5 = "Q5";

        /// <summary>
        /// Service furnished under a fee-for-time compensation arrangement by a substitute physician; or by a substitute physical therapist furnishing outpatient physical therapy services in a health professional shortage area, a medically underserved area, or a rural area
        /// </summary>
        public const string Q6 = "Q6";

        /// <summary>
        /// One Class A finding
        /// </summary>
        public const string Q7 = "Q7";

        /// <summary>
        /// Two Class A findings
        /// </summary>
        public const string Q8 = "Q8";

        /// <summary>
        /// One Class B and two Class C findings
        /// </summary>
        public const string Q9 = "Q9";

        /// <summary>
        /// Prescribed amounts of stationary oxygen for daytime use differ ... &lt;1 liter per minute
        /// </summary>
        public const string Qa = "QA";

        /// <summary>
        /// Prescribed amounts of stationary oxygen for daytime use differ ... &gt;4 liters per minute
        /// </summary>
        public const string Qb = "QB";

        /// <summary>
        /// Single channel monitoring
        /// </summary>
        public const string Qc = "QC";

        /// <summary>
        /// Recording and storage in solid state memory by a digital recorder
        /// </summary>
        public const string Qd = "QD";

        /// <summary>
        /// Prescribed amount of stationary oxygen while at rest is less than 1 liter per minute (lpm)
        /// </summary>
        public const string Qe = "QE";

        /// <summary>
        /// Prescribed amount of stationary oxygen while at rest exceeds 4 liters per minute (lpm) and portable oxygen is prescribed
        /// </summary>
        public const string Qf = "QF";

        /// <summary>
        /// Prescribed amount of stationary oxygen while at rest is greater than 4 liters per minute (lpm)
        /// </summary>
        public const string Qg = "QG";

        /// <summary>
        /// Oxygen conserving device is being used with an oxygen delivery system
        /// </summary>
        public const string Qh = "QH";

        /// <summary>
        /// Services/items provided to a prisoner or patient in state or local custody, however the state or local government, as applicable, meets the requirements in 42 cfr 411.4 (b)
        /// </summary>
        public const string Qj = "QJ";

        /// <summary>
        /// Medical direction of two, three, or four concurrent anesthesia procedure involving qualified individuals
        /// </summary>
        public const string Qk = "QK";

        /// <summary>
        /// Patient pronounced dead after ambulance called
        /// </summary>
        public const string Ql = "QL";

        /// <summary>
        /// Ambulance service provided under arrangement by a provider of services
        /// </summary>
        public const string Qm = "QM";

        /// <summary>
        /// Ambulance service furnished directly by a provider of services
        /// </summary>
        public const string Qn = "QN";

        /// <summary>
        /// Laboratory test(s) was ordered individually or ordered as a cpt-recognized panel other than automated profile codes
        /// </summary>
        public const string Qp = "QP";

        /// <summary>
        /// Ordering professional consulted a qualified clinical decision support mechanism for this service
        /// </summary>
        public const string Qq = "QQ";

        /// <summary>
        /// Amounts of stationary oxygen for daytime use and nighttime use differ; average of the amounts &gt;4 liters per minute
        /// </summary>
        public const string Qr = "QR";

        /// <summary>
        /// Monitored anesthesia care service
        /// </summary>
        public const string Qs = "QS";

        /// <summary>
        /// Recording and storage on tape by an analog tape recorder
        /// </summary>
        public const string Qt = "QT";

        /// <summary>
        /// CLIA waived
        /// </summary>
        public const string Qw = "QW";

        /// <summary>
        /// CRNA service: with medical direction by a physician
        /// </summary>
        public const string Qx = "QX";

        /// <summary>
        /// Medical direction of one certified registered nurse anesthetist (CRNA) by an anesthesiologist
        /// </summary>
        public const string Qy = "QY";

        /// <summary>
        /// CRNA service: without medical direction by a physician
        /// </summary>
        public const string Qz = "QZ";

        /// <summary>
        /// Replacement of a DME, orthotic or prosthetic item
        /// </summary>
        public const string Ra = "RA";

        /// <summary>
        /// Replacement of a part of a DME, orthotic or prosthetic item
        /// </summary>
        public const string Rb = "RB";

        /// <summary>
        /// Right coronary artery
        /// </summary>
        public const string Rc = "RC";

        /// <summary>
        /// Drug provided to beneficiary, but not administered 'incident-to'
        /// </summary>
        public const string Rd = "RD";

        /// <summary>
        /// Furnished in full compliance with FDA-mandated risk evaluation and mitigation strategy (REMS)
        /// </summary>
        public const string Re = "RE";

        /// <summary>
        /// Ramus intermedius coronary artery
        /// </summary>
        public const string Ri = "RI";

        /// <summary>
        /// Rental (Use this ‘RR' modifier when DME is to be rented)
        /// </summary>
        public const string Rr = "RR";

        /// <summary>
        /// Right side (used to identify procedures performed on the right side of the body)
        /// </summary>
        public const string Rt = "RT";

        /// <summary>
        /// Physician assistant, nurse practitioner, or clinical nurse specialist services for non-surgical services
        /// </summary>
        public const string Sa = "SA";

        /// <summary>
        /// Nurse midwife
        /// </summary>
        public const string Sb = "SB";

        /// <summary>
        /// Medically necessary service or supply
        /// </summary>
        public const string Sc = "SC";

        /// <summary>
        /// Services provided by registered nurse with specialized, highly technical home infusion training
        /// </summary>
        public const string Sd = "SD";

        /// <summary>
        /// State- and/or federally-funded programs/services
        /// </summary>
        public const string Se = "SE";

        /// <summary>
        /// Second opinion ordered by a professional review organization (PRO) per section 9401, p.l. 99-272
        /// </summary>
        public const string Sf = "SF";

        /// <summary>
        /// Ambulatory surgical center (ASC) facility service
        /// </summary>
        public const string Sg = "SG";

        /// <summary>
        /// Second concurrently administered infusion therapy
        /// </summary>
        public const string Sh = "SH";

        /// <summary>
        /// Third or more concurrently administered infusion therapy
        /// </summary>
        public const string Sj = "SJ";

        /// <summary>
        /// Addresses reimbursement guidelines for vaccines provided at no cost to the provider by a state or federal agency
        /// </summary>
        public const string Sl = "SL";

        /// <summary>
        /// Second surgical opinion
        /// </summary>
        public const string Sm = "SM";

        /// <summary>
        /// Third surgical opinion
        /// </summary>
        public const string Sn = "SN";

        /// <summary>
        /// Item ordered by home health
        /// </summary>
        public const string Sq = "SQ";

        /// <summary>
        /// Home infusion services provided in the infusion suite of the IV therapy provider
        /// </summary>
        public const string Ss = "SS";

        /// <summary>
        /// Related to trauma or injury
        /// </summary>
        public const string St = "ST";

        /// <summary>
        /// Procedure performed in physician's office (to denote use of facility and equipment)
        /// </summary>
        public const string Su = "SU";

        /// <summary>
        /// Pharamceuticals delivered to patient's home but not utilized
        /// </summary>
        public const string Sv = "SV";

        /// <summary>
        /// Services provided by a certified diabetic educator
        /// </summary>
        public const string Sw = "SW";

        /// <summary>
        /// Persons who are in close contact with member of high-risk population (use only with codes for immunization)
        /// </summary>
        public const string Sy = "SY";

        /// <summary>
        /// Left foot, second digit
        /// </summary>
        public const string T1 = "T1";

        /// <summary>
        /// Left foot, third digit
        /// </summary>
        public const string T2 = "T2";

        /// <summary>
        /// Left foot, fourth digit
        /// </summary>
        public const string T3 = "T3";

        /// <summary>
        /// Left foot, fifth digit
        /// </summary>
        public const string T4 = "T4";

        /// <summary>
        /// Right foot, great toe
        /// </summary>
        public const string T5 = "T5";

        /// <summary>
        /// Right foot, second digit
        /// </summary>
        public const string T6 = "T6";

        /// <summary>
        /// Right foot, third digit
        /// </summary>
        public const string T7 = "T7";

        /// <summary>
        /// Right foot, fourth digit
        /// </summary>
        public const string T8 = "T8";

        /// <summary>
        /// Right foot, fifth digit
        /// </summary>
        public const string T9 = "T9";

        /// <summary>
        /// Left foot, great toe
        /// </summary>
        public const string Ta = "TA";

        /// <summary>
        /// Drug or biological acquired with 340b drug pricing program discount, reported for informational purposes
        /// </summary>
        public const string Tb = "TB";

        /// <summary>
        /// Technical Component
        /// </summary>
        public const string Tc = "TC";

        /// <summary>
        /// Registered nurse (RN)
        /// </summary>
        public const string Td = "TD";

        /// <summary>
        /// Licensed vocational nurse (LVN) or licensed practical nurse (LPN)
        /// </summary>
        public const string Te = "TE";

        /// <summary>
        /// Intermediate level of care
        /// </summary>
        public const string Tf = "TF";

        /// <summary>
        /// Complex/high tech level of care
        /// </summary>
        public const string Tg = "TG";

        /// <summary>
        /// Obstetrical treatment/services, prenatal or postpart
        /// </summary>
        public const string Th = "TH";

        /// <summary>
        /// Program group, child and/or adolescent
        /// </summary>
        public const string Tj = "TJ";

        /// <summary>
        /// Extra patient or passenger, non-ambulance
        /// </summary>
        public const string Tk = "TK";

        /// <summary>
        /// Early Intervention/Individualized Family Service Plan
        /// </summary>
        public const string Tl = "TL";

        /// <summary>
        /// Individualized education program (IEP)
        /// </summary>
        public const string Tm = "TM";

        /// <summary>
        /// Rural/outside providers' customary service area
        /// </summary>
        public const string Tn = "TN";

        /// <summary>
        /// Medical transport, unloaded vehicle
        /// </summary>
        public const string Tp = "TP";

        /// <summary>
        /// Basic life support transport by a volunteer ambulance provider
        /// </summary>
        public const string Tq = "TQ";

        /// <summary>
        /// School-based individualized education program (IEP) services provided outside the public school district
        /// </summary>
        public const string Tr = "TR";

        /// <summary>
        /// Follow-up service
        /// </summary>
        public const string Ts = "TS";

        /// <summary>
        /// Individualized service provided to more than one patient in same setting
        /// </summary>
        public const string Tt = "TT";

        /// <summary>
        /// Special payment rate, overtime
        /// </summary>
        public const string Tu = "TU";

        /// <summary>
        /// Special payment rates, holidays/weekends
        /// </summary>
        public const string Tv = "TV";

        /// <summary>
        /// Back-up equipment
        /// </summary>
        public const string Tw = "TW";

        /// <summary>
        /// Medicaid level of care 1, as defined by each state
        /// </summary>
        public const string U1 = "U1";

        /// <summary>
        /// Medicaid level of care 2, as defined by each state
        /// </summary>
        public const string U2 = "U2";

        /// <summary>
        /// Medicaid level of care 3, as defined by each state
        /// </summary>
        public const string U3 = "U3";

        /// <summary>
        /// Medicaid level of care 4, as defined by each state
        /// </summary>
        public const string U4 = "U4";

        /// <summary>
        /// Medicaid level of care 5, as defined by each state
        /// </summary>
        public const string U5 = "U5";

        /// <summary>
        /// Medicaid level of care 6, as defined by each state
        /// </summary>
        public const string U6 = "U6";

        /// <summary>
        /// Medicaid level of care 7, as defined by each state
        /// </summary>
        public const string U7 = "U7";

        /// <summary>
        /// Medicaid level of care 8, as defined by each state
        /// </summary>
        public const string U8 = "U8";

        /// <summary>
        /// Medicaid level of care 9, as defined by each state
        /// </summary>
        public const string U9 = "U9";

        /// <summary>
        /// Medicaid level of care 10, as defined by each state
        /// </summary>
        public const string Ua = "UA";

        /// <summary>
        /// Medicaid level of care 11, as defined by each state
        /// </summary>
        public const string Ub = "UB";

        /// <summary>
        /// Medicaid level of care 12, as defined by each state
        /// </summary>
        public const string Uc = "UC";

        /// <summary>
        /// Medicaid level of care 13, as defined by each state
        /// </summary>
        public const string Ud = "UD";

        /// <summary>
        /// Used durable medical equipment
        /// </summary>
        public const string Ue = "UE";

        /// <summary>
        /// Services provided in the morning
        /// </summary>
        public const string Uf = "UF";

        /// <summary>
        /// Services provided in the afternoon
        /// </summary>
        public const string Ug = "UG";

        /// <summary>
        /// Services provided in the evening
        /// </summary>
        public const string Uh = "UH";

        /// <summary>
        /// Services provided at night
        /// </summary>
        public const string Uj = "UJ";

        /// <summary>
        /// Services provided on behalf of the client to someone other than the client (collateral relationship)
        /// </summary>
        public const string Uk = "UK";

        /// <summary>
        /// Two patients served
        /// </summary>
        public const string Un = "UN";

        /// <summary>
        /// Three patients served
        /// </summary>
        public const string Up = "UP";

        /// <summary>
        /// Four patients served
        /// </summary>
        public const string Uq = "UQ";

        /// <summary>
        /// Five patients served
        /// </summary>
        public const string Ur = "UR";

        /// <summary>
        /// Six patients served
        /// </summary>
        public const string Us = "US";

        /// <summary>
        /// One patient visit in a month
        /// </summary>
        public const string V1 = "V1";

        /// <summary>
        /// Two patient visits in a month
        /// </summary>
        public const string V2 = "V2";

        /// <summary>
        /// Three patient visits in a month
        /// </summary>
        public const string V3 = "V3";

        /// <summary>
        /// Indicates that the service was provided under a state-mandated reimbursement rate for workers' compensation claims
        /// </summary>
        public const string W1 = "W1";

        /// <summary>
        /// Used when a Medicare Set-Aside (MSA) account is used to pay for services related to a workers' compensation settlement
        /// </summary>
        public const string W2 = "W2";

        /// <summary>
        /// The treatment was approved under the workers’ compensation plan
        /// </summary>
        public const string W3 = "W3";

        /// <summary>
        /// Episodic/Focused Services - Reported by a specialty focused clinician who provides care that is time-limited
        /// </summary>
        public const string X4 = "X4";

        /// <summary>
        /// Two or more separate patient visits on the same date of service
        /// </summary>
        public const string Xe = "XE";

        /// <summary>
        /// A service that is distinct because it was performed by a different practitioner
        /// </summary>
        public const string Xp = "XP";

        /// <summary>
        /// A service that is distinct because it was performed on a separate organ/structure
        /// </summary>
        public const string Xs = "XS";

        /// <summary>
        /// The use of a service that is distinct because it does not overlap usual components of the main service
        /// </summary>
        public const string Xu = "XU";

        /// <summary>
        /// Custom modifier
        /// </summary>
        public const string Xy = "XY";
    }
}
