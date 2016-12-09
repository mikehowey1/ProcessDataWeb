using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Contracts
{
    /// <summary>
    /// measurement
    /// </summary>
    public class Measurement
    {
        /// <summary>
        /// name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// value
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// upper limit
        /// </summary>
        public string upperLimit { get; set; }

        /// <summary>
        /// lower limit
        /// </summary>
        public string lowerLimit { get; set; }

        /// <summary>
        /// result
        /// </summary>
        public bool? result { get; set; }

        public override bool Equals(object obj)
        {
            //TODO:Put Conditional logic in to check type
            return ((Measurement)obj).name.Equals(this.name);
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }
    }
}
