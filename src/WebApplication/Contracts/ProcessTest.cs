using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Contracts
{
    /// <summary>
    /// process test
    /// </summary>
    public class ProcessTest
    {
        /// <summary>
        /// overall result of test
        /// </summary>
        public bool? testResult { get; set; }

        /// <summary>
        /// clientName 
        /// </summary>
        public string clientName { get; set; }

        /// <summary>
        /// traceability data
        /// </summary>
        public TraceabilityData traceAbility { get; set; }

        /// <summary>
        /// custom Attributes
        /// </summary>
        /// <remarks>Not indexed for search</remarks>
        public Dictionary<string, string> customAttributes { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// measurements
        /// </summary>
        public HashSet<Measurement> measurements { get; set; } = new HashSet<Measurement>();
            
    }
}
