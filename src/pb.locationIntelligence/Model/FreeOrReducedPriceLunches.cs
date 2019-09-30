/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 7.5.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace pb.locationIntelligence.Model
{
    /// <summary>
    /// FreeOrReducedPriceLunches
    /// </summary>
    [DataContract]
    public partial class FreeOrReducedPriceLunches :  IEquatable<FreeOrReducedPriceLunches>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FreeOrReducedPriceLunches" /> class.
        /// </summary>
        /// <param name="FreeLunchesCount">FreeLunchesCount.</param>
        /// <param name="ReducedPriceLunchedCount">ReducedPriceLunchedCount.</param>
        /// <param name="TotalCount">TotalCount.</param>
        public FreeOrReducedPriceLunches(string FreeLunchesCount = null, string ReducedPriceLunchedCount = null, string TotalCount = null)
        {
            this.FreeLunchesCount = FreeLunchesCount;
            this.ReducedPriceLunchedCount = ReducedPriceLunchedCount;
            this.TotalCount = TotalCount;
        }
        
        /// <summary>
        /// Gets or Sets FreeLunchesCount
        /// </summary>
        [DataMember(Name="freeLunchesCount", EmitDefaultValue=false)]
        public string FreeLunchesCount { get; set; }
        /// <summary>
        /// Gets or Sets ReducedPriceLunchedCount
        /// </summary>
        [DataMember(Name="reducedPriceLunchedCount", EmitDefaultValue=false)]
        public string ReducedPriceLunchedCount { get; set; }
        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public string TotalCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FreeOrReducedPriceLunches {\n");
            sb.Append("  FreeLunchesCount: ").Append(FreeLunchesCount).Append("\n");
            sb.Append("  ReducedPriceLunchedCount: ").Append(ReducedPriceLunchedCount).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FreeOrReducedPriceLunches);
        }

        /// <summary>
        /// Returns true if FreeOrReducedPriceLunches instances are equal
        /// </summary>
        /// <param name="other">Instance of FreeOrReducedPriceLunches to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FreeOrReducedPriceLunches other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FreeLunchesCount == other.FreeLunchesCount ||
                    this.FreeLunchesCount != null &&
                    this.FreeLunchesCount.Equals(other.FreeLunchesCount)
                ) && 
                (
                    this.ReducedPriceLunchedCount == other.ReducedPriceLunchedCount ||
                    this.ReducedPriceLunchedCount != null &&
                    this.ReducedPriceLunchedCount.Equals(other.ReducedPriceLunchedCount)
                ) && 
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.FreeLunchesCount != null)
                    hash = hash * 59 + this.FreeLunchesCount.GetHashCode();
                if (this.ReducedPriceLunchedCount != null)
                    hash = hash * 59 + this.ReducedPriceLunchedCount.GetHashCode();
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
                return hash;
            }
        }
    }

}
