/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 6.0.0
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
    /// SpecialPurposeDistrict
    /// </summary>
    [DataContract]
    public partial class SpecialPurposeDistrict :  IEquatable<SpecialPurposeDistrict>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialPurposeDistrict" /> class.
        /// </summary>
        /// <param name="DistrictName">DistrictName.</param>
        /// <param name="DistrictCode">DistrictCode.</param>
        /// <param name="DistrictNumber">DistrictNumber.</param>
        /// <param name="VersionDate">VersionDate.</param>
        /// <param name="EffectiveDate">EffectiveDate.</param>
        /// <param name="CompiledDate">CompiledDate.</param>
        /// <param name="UpdateDate">UpdateDate.</param>
        public SpecialPurposeDistrict(string DistrictName = null, string DistrictCode = null, string DistrictNumber = null, string VersionDate = null, string EffectiveDate = null, string CompiledDate = null, string UpdateDate = null)
        {
            this.DistrictName = DistrictName;
            this.DistrictCode = DistrictCode;
            this.DistrictNumber = DistrictNumber;
            this.VersionDate = VersionDate;
            this.EffectiveDate = EffectiveDate;
            this.CompiledDate = CompiledDate;
            this.UpdateDate = UpdateDate;
        }
        
        /// <summary>
        /// Gets or Sets DistrictName
        /// </summary>
        [DataMember(Name="districtName", EmitDefaultValue=false)]
        public string DistrictName { get; set; }
        /// <summary>
        /// Gets or Sets DistrictCode
        /// </summary>
        [DataMember(Name="districtCode", EmitDefaultValue=false)]
        public string DistrictCode { get; set; }
        /// <summary>
        /// Gets or Sets DistrictNumber
        /// </summary>
        [DataMember(Name="districtNumber", EmitDefaultValue=false)]
        public string DistrictNumber { get; set; }
        /// <summary>
        /// Gets or Sets VersionDate
        /// </summary>
        [DataMember(Name="versionDate", EmitDefaultValue=false)]
        public string VersionDate { get; set; }
        /// <summary>
        /// Gets or Sets EffectiveDate
        /// </summary>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public string EffectiveDate { get; set; }
        /// <summary>
        /// Gets or Sets CompiledDate
        /// </summary>
        [DataMember(Name="compiledDate", EmitDefaultValue=false)]
        public string CompiledDate { get; set; }
        /// <summary>
        /// Gets or Sets UpdateDate
        /// </summary>
        [DataMember(Name="updateDate", EmitDefaultValue=false)]
        public string UpdateDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecialPurposeDistrict {\n");
            sb.Append("  DistrictName: ").Append(DistrictName).Append("\n");
            sb.Append("  DistrictCode: ").Append(DistrictCode).Append("\n");
            sb.Append("  DistrictNumber: ").Append(DistrictNumber).Append("\n");
            sb.Append("  VersionDate: ").Append(VersionDate).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  CompiledDate: ").Append(CompiledDate).Append("\n");
            sb.Append("  UpdateDate: ").Append(UpdateDate).Append("\n");
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
            return this.Equals(obj as SpecialPurposeDistrict);
        }

        /// <summary>
        /// Returns true if SpecialPurposeDistrict instances are equal
        /// </summary>
        /// <param name="other">Instance of SpecialPurposeDistrict to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpecialPurposeDistrict other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DistrictName == other.DistrictName ||
                    this.DistrictName != null &&
                    this.DistrictName.Equals(other.DistrictName)
                ) && 
                (
                    this.DistrictCode == other.DistrictCode ||
                    this.DistrictCode != null &&
                    this.DistrictCode.Equals(other.DistrictCode)
                ) && 
                (
                    this.DistrictNumber == other.DistrictNumber ||
                    this.DistrictNumber != null &&
                    this.DistrictNumber.Equals(other.DistrictNumber)
                ) && 
                (
                    this.VersionDate == other.VersionDate ||
                    this.VersionDate != null &&
                    this.VersionDate.Equals(other.VersionDate)
                ) && 
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
                ) && 
                (
                    this.CompiledDate == other.CompiledDate ||
                    this.CompiledDate != null &&
                    this.CompiledDate.Equals(other.CompiledDate)
                ) && 
                (
                    this.UpdateDate == other.UpdateDate ||
                    this.UpdateDate != null &&
                    this.UpdateDate.Equals(other.UpdateDate)
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
                if (this.DistrictName != null)
                    hash = hash * 59 + this.DistrictName.GetHashCode();
                if (this.DistrictCode != null)
                    hash = hash * 59 + this.DistrictCode.GetHashCode();
                if (this.DistrictNumber != null)
                    hash = hash * 59 + this.DistrictNumber.GetHashCode();
                if (this.VersionDate != null)
                    hash = hash * 59 + this.VersionDate.GetHashCode();
                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();
                if (this.CompiledDate != null)
                    hash = hash * 59 + this.CompiledDate.GetHashCode();
                if (this.UpdateDate != null)
                    hash = hash * 59 + this.UpdateDate.GetHashCode();
                return hash;
            }
        }
    }

}
