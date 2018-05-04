/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 4.6.0
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
    /// FloodHazardPreferences
    /// </summary>
    [DataContract]
    public partial class FloodHazardPreferences :  IEquatable<FloodHazardPreferences>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloodHazardPreferences" /> class.
        /// </summary>
        /// <param name="SearchDistanceUnit">SearchDistanceUnit.</param>
        /// <param name="SearchDistance">SearchDistance.</param>
        /// <param name="WaterBodyType">WaterBodyType.</param>
        /// <param name="MaxCandidates">MaxCandidates.</param>
        public FloodHazardPreferences(string SearchDistanceUnit = null, string SearchDistance = null, string WaterBodyType = null, string MaxCandidates = null)
        {
            this.SearchDistanceUnit = SearchDistanceUnit;
            this.SearchDistance = SearchDistance;
            this.WaterBodyType = WaterBodyType;
            this.MaxCandidates = MaxCandidates;
        }
        
        /// <summary>
        /// Gets or Sets SearchDistanceUnit
        /// </summary>
        [DataMember(Name="searchDistanceUnit", EmitDefaultValue=false)]
        public string SearchDistanceUnit { get; set; }
        /// <summary>
        /// Gets or Sets SearchDistance
        /// </summary>
        [DataMember(Name="searchDistance", EmitDefaultValue=false)]
        public string SearchDistance { get; set; }
        /// <summary>
        /// Gets or Sets WaterBodyType
        /// </summary>
        [DataMember(Name="waterBodyType", EmitDefaultValue=false)]
        public string WaterBodyType { get; set; }
        /// <summary>
        /// Gets or Sets MaxCandidates
        /// </summary>
        [DataMember(Name="maxCandidates", EmitDefaultValue=false)]
        public string MaxCandidates { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FloodHazardPreferences {\n");
            sb.Append("  SearchDistanceUnit: ").Append(SearchDistanceUnit).Append("\n");
            sb.Append("  SearchDistance: ").Append(SearchDistance).Append("\n");
            sb.Append("  WaterBodyType: ").Append(WaterBodyType).Append("\n");
            sb.Append("  MaxCandidates: ").Append(MaxCandidates).Append("\n");
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
            return this.Equals(obj as FloodHazardPreferences);
        }

        /// <summary>
        /// Returns true if FloodHazardPreferences instances are equal
        /// </summary>
        /// <param name="other">Instance of FloodHazardPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FloodHazardPreferences other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SearchDistanceUnit == other.SearchDistanceUnit ||
                    this.SearchDistanceUnit != null &&
                    this.SearchDistanceUnit.Equals(other.SearchDistanceUnit)
                ) && 
                (
                    this.SearchDistance == other.SearchDistance ||
                    this.SearchDistance != null &&
                    this.SearchDistance.Equals(other.SearchDistance)
                ) && 
                (
                    this.WaterBodyType == other.WaterBodyType ||
                    this.WaterBodyType != null &&
                    this.WaterBodyType.Equals(other.WaterBodyType)
                ) && 
                (
                    this.MaxCandidates == other.MaxCandidates ||
                    this.MaxCandidates != null &&
                    this.MaxCandidates.Equals(other.MaxCandidates)
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
                if (this.SearchDistanceUnit != null)
                    hash = hash * 59 + this.SearchDistanceUnit.GetHashCode();
                if (this.SearchDistance != null)
                    hash = hash * 59 + this.SearchDistance.GetHashCode();
                if (this.WaterBodyType != null)
                    hash = hash * 59 + this.WaterBodyType.GetHashCode();
                if (this.MaxCandidates != null)
                    hash = hash * 59 + this.MaxCandidates.GetHashCode();
                return hash;
            }
        }
    }

}
