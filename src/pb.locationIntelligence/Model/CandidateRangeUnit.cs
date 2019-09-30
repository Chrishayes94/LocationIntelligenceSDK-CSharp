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
    /// CandidateRangeUnit
    /// </summary>
    [DataContract]
    public partial class CandidateRangeUnit :  IEquatable<CandidateRangeUnit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CandidateRangeUnit" /> class.
        /// </summary>
        /// <param name="PlaceName">PlaceName.</param>
        /// <param name="UnitType">UnitType.</param>
        /// <param name="HighUnitValue">HighUnitValue.</param>
        /// <param name="LowUnitValue">LowUnitValue.</param>
        /// <param name="CustomValues">CustomValues.</param>
        public CandidateRangeUnit(string PlaceName = null, string UnitType = null, string HighUnitValue = null, string LowUnitValue = null, Dictionary<string, Object> CustomValues = null)
        {
            this.PlaceName = PlaceName;
            this.UnitType = UnitType;
            this.HighUnitValue = HighUnitValue;
            this.LowUnitValue = LowUnitValue;
            this.CustomValues = CustomValues;
        }
        
        /// <summary>
        /// Gets or Sets PlaceName
        /// </summary>
        [DataMember(Name="placeName", EmitDefaultValue=false)]
        public string PlaceName { get; set; }
        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [DataMember(Name="unitType", EmitDefaultValue=false)]
        public string UnitType { get; set; }
        /// <summary>
        /// Gets or Sets HighUnitValue
        /// </summary>
        [DataMember(Name="highUnitValue", EmitDefaultValue=false)]
        public string HighUnitValue { get; set; }
        /// <summary>
        /// Gets or Sets LowUnitValue
        /// </summary>
        [DataMember(Name="lowUnitValue", EmitDefaultValue=false)]
        public string LowUnitValue { get; set; }
        /// <summary>
        /// Gets or Sets CustomValues
        /// </summary>
        [DataMember(Name="customValues", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomValues { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CandidateRangeUnit {\n");
            sb.Append("  PlaceName: ").Append(PlaceName).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  HighUnitValue: ").Append(HighUnitValue).Append("\n");
            sb.Append("  LowUnitValue: ").Append(LowUnitValue).Append("\n");
            sb.Append("  CustomValues: ").Append(CustomValues).Append("\n");
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
            return this.Equals(obj as CandidateRangeUnit);
        }

        /// <summary>
        /// Returns true if CandidateRangeUnit instances are equal
        /// </summary>
        /// <param name="other">Instance of CandidateRangeUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CandidateRangeUnit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PlaceName == other.PlaceName ||
                    this.PlaceName != null &&
                    this.PlaceName.Equals(other.PlaceName)
                ) && 
                (
                    this.UnitType == other.UnitType ||
                    this.UnitType != null &&
                    this.UnitType.Equals(other.UnitType)
                ) && 
                (
                    this.HighUnitValue == other.HighUnitValue ||
                    this.HighUnitValue != null &&
                    this.HighUnitValue.Equals(other.HighUnitValue)
                ) && 
                (
                    this.LowUnitValue == other.LowUnitValue ||
                    this.LowUnitValue != null &&
                    this.LowUnitValue.Equals(other.LowUnitValue)
                ) && 
                (
                    this.CustomValues == other.CustomValues ||
                    this.CustomValues != null &&
                    this.CustomValues.SequenceEqual(other.CustomValues)
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
                if (this.PlaceName != null)
                    hash = hash * 59 + this.PlaceName.GetHashCode();
                if (this.UnitType != null)
                    hash = hash * 59 + this.UnitType.GetHashCode();
                if (this.HighUnitValue != null)
                    hash = hash * 59 + this.HighUnitValue.GetHashCode();
                if (this.LowUnitValue != null)
                    hash = hash * 59 + this.LowUnitValue.GetHashCode();
                if (this.CustomValues != null)
                    hash = hash * 59 + this.CustomValues.GetHashCode();
                return hash;
            }
        }
    }

}
