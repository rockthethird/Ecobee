﻿using Ecobee.Protocol.Objects;
using System;
using System.Runtime.Serialization;

namespace Ecobee.Protocol.Thermostat
{
    [DataContract]
    public class ThermostatSummaryRequest : RequestBase
    {
        /// <summary>
        /// Request URI.
        /// </summary>
        public override string Uri { get { return "/thermostatSummary"; } }

        /// <summary>
        /// Request type (GET or POST).
        /// </summary>
        public override RequestType RequestType { get { return RequestType.GET; } }

        /// <summary>
        /// Type to deserialize the response to.
        /// </summary>
        public override Type ResponseType { get { return typeof(ThermostatSummaryResponse); } }

        /// <summary>
        /// The selection criteria for update.
        /// </summary>
        [DataMember(Name = "selection")]
        public Selection Selection { get; set; }
    }
}
