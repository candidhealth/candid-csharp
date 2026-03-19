using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.EncountersUniversal;

namespace Candid.Net.Encounters.V4;

public partial interface IV4Client
{
    WithRawResponseTask<EncounterPage> GetAllAsync(
        GetAllEncountersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Encounter> GetAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Notice: The UB-04 Data File, 2025, is copyrighted by American Hospital Association (AHA), Chicago, Illinois.
    /// No portion of the THE UB-04 Data File, may be reproduced, stored in a retrieval system, or transmitted,
    /// in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without prior
    /// express, written consent of AHA.
    /// </summary>
    WithRawResponseTask<Encounter> CreateUniversalAsync(
        UniversalEncounterCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Encounter> CreateAsync(
        EncounterCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an encounter from a pre-encounter patient and appointment. This endpoint is intended to be used by consumers who are managing
    /// patients and appointments in the pre-encounter service and is currently under development. Consumers who are not taking advantage
    /// of the pre-encounter service should use the standard create endpoint.
    ///
    /// The endpoint will create an encounter from the provided fields, pulling information from the provided patient and appointment objects
    /// where applicable. In particular, the following fields are populated from the patient and appointment objects:
    ///   - Patient
    ///   - Referring Provider
    ///   - Subscriber Primary
    ///   - Subscriber Secondary
    ///   - Referral Number
    ///   - Responsible Party
    ///   - Guarantor
    ///
    /// Utilizing this endpoint opts you into automatic updating of the encounter when the patient or appointment is updated, assuming the
    /// encounter has not already been submitted or adjudicated.
    ///
    /// Notice: The UB-04 Data File, 2025, is copyrighted by American Hospital Association (AHA), Chicago, Illinois.
    /// No portion of the THE UB-04 Data File, may be reproduced, stored in a retrieval system, or transmitted,
    /// in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without prior
    /// express, written consent of AHA.
    /// </summary>
    WithRawResponseTask<Encounter> CreateFromPreEncounterPatientUniversalAsync(
        UniversalEncounterCreateFromPreEncounter request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an encounter from a pre-encounter patient and appointment. This endpoint is intended to be used by consumers who are managing
    /// patients and appointments in the pre-encounter service and is currently under development. Consumers who are not taking advantage
    /// of the pre-encounter service should use the standard create endpoint.
    ///
    /// The endpoint will create an encounter from the provided fields, pulling information from the provided patient and appointment objects
    /// where applicable. In particular, the following fields are populated from the patient and appointment objects:
    ///   - Patient
    ///   - Referring Provider
    ///   - Subscriber Primary
    ///   - Subscriber Secondary
    ///   - Referral Number
    ///   - Responsible Party
    ///   - Guarantor
    ///
    /// Utilizing this endpoint opts you into automatic updating of the encounter when the patient or appointment is updated, assuming the
    /// encounter has not already been submitted or adjudicated.
    /// </summary>
    WithRawResponseTask<Encounter> CreateFromPreEncounterPatientAsync(
        EncounterCreateFromPreEncounter request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Notice: The UB-04 Data File, 2025, is copyrighted by American Hospital Association (AHA), Chicago, Illinois.
    /// No portion of the THE UB-04 Data File, may be reproduced, stored in a retrieval system, or transmitted,
    /// in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without prior
    /// express, written consent of AHA.
    /// </summary>
    WithRawResponseTask<Encounter> UpdateUniversalAsync(
        string encounterId,
        UniversalEncounterUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Encounter> UpdateAsync(
        string encounterId,
        EncounterUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
