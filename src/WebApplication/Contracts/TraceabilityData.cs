using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Contracts
{
    /// <summary>
    /// measurement
    /// </summary>
    public class TraceabilityData
    {
        /// <summary>
        /// start time
        /// </summary>
        public DateTimeOffset? startTime { get; set; }

        /// <summary>
        /// end time
        /// </summary>
        public DateTimeOffset? endTime { get; set; }

        /// <summary>
        /// line
        /// </summary>
        public string line { get; set; }

        /// <summary>
        /// operation Id
        /// </summary>
        public string operationId { get; set; }

        /// <summary>
        /// part Number
        /// </summary>
        public string partNumber { get; set; }

        /// <summary>
        /// part Revision
        /// </summary>
        public string partRevision { get; set; }

        /// <summary>
        /// asset
        /// </summary>
        public string asset { get; set; }

        /// <summary>
        /// identifier and type
        /// </summary>
        public KeyValuePair<IdentifierType, string> identifier { get; set; }

    }
}
