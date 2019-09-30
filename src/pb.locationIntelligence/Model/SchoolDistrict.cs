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
    /// SchoolDistrict
    /// </summary>
    [DataContract]
    public partial class SchoolDistrict :  IEquatable<SchoolDistrict>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolDistrict" /> class.
        /// </summary>
        /// <param name="NcesDistrictId">NcesDistrictId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="TotalSchools">TotalSchools.</param>
        /// <param name="DistrictType">DistrictType.</param>
        /// <param name="Metro">Metro.</param>
        /// <param name="AreaInSqM">AreaInSqM.</param>
        /// <param name="SupervisoryUnionId">SupervisoryUnionId.</param>
        /// <param name="DistrictEnrollment">DistrictEnrollment.</param>
        /// <param name="DistrictUrl">DistrictUrl.</param>
        public SchoolDistrict(string NcesDistrictId = null, string Name = null, string TotalSchools = null, string DistrictType = null, string Metro = null, string AreaInSqM = null, string SupervisoryUnionId = null, string DistrictEnrollment = null, string DistrictUrl = null)
        {
            this.NcesDistrictId = NcesDistrictId;
            this.Name = Name;
            this.TotalSchools = TotalSchools;
            this.DistrictType = DistrictType;
            this.Metro = Metro;
            this.AreaInSqM = AreaInSqM;
            this.SupervisoryUnionId = SupervisoryUnionId;
            this.DistrictEnrollment = DistrictEnrollment;
            this.DistrictUrl = DistrictUrl;
        }
        
        /// <summary>
        /// Gets or Sets NcesDistrictId
        /// </summary>
        [DataMember(Name="ncesDistrictId", EmitDefaultValue=false)]
        public string NcesDistrictId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets TotalSchools
        /// </summary>
        [DataMember(Name="totalSchools", EmitDefaultValue=false)]
        public string TotalSchools { get; set; }
        /// <summary>
        /// Gets or Sets DistrictType
        /// </summary>
        [DataMember(Name="districtType", EmitDefaultValue=false)]
        public string DistrictType { get; set; }
        /// <summary>
        /// Gets or Sets Metro
        /// </summary>
        [DataMember(Name="metro", EmitDefaultValue=false)]
        public string Metro { get; set; }
        /// <summary>
        /// Gets or Sets AreaInSqM
        /// </summary>
        [DataMember(Name="areaInSqM", EmitDefaultValue=false)]
        public string AreaInSqM { get; set; }
        /// <summary>
        /// Gets or Sets SupervisoryUnionId
        /// </summary>
        [DataMember(Name="supervisoryUnionId", EmitDefaultValue=false)]
        public string SupervisoryUnionId { get; set; }
        /// <summary>
        /// Gets or Sets DistrictEnrollment
        /// </summary>
        [DataMember(Name="districtEnrollment", EmitDefaultValue=false)]
        public string DistrictEnrollment { get; set; }
        /// <summary>
        /// Gets or Sets DistrictUrl
        /// </summary>
        [DataMember(Name="districtUrl", EmitDefaultValue=false)]
        public string DistrictUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolDistrict {\n");
            sb.Append("  NcesDistrictId: ").Append(NcesDistrictId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TotalSchools: ").Append(TotalSchools).Append("\n");
            sb.Append("  DistrictType: ").Append(DistrictType).Append("\n");
            sb.Append("  Metro: ").Append(Metro).Append("\n");
            sb.Append("  AreaInSqM: ").Append(AreaInSqM).Append("\n");
            sb.Append("  SupervisoryUnionId: ").Append(SupervisoryUnionId).Append("\n");
            sb.Append("  DistrictEnrollment: ").Append(DistrictEnrollment).Append("\n");
            sb.Append("  DistrictUrl: ").Append(DistrictUrl).Append("\n");
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
            return this.Equals(obj as SchoolDistrict);
        }

        /// <summary>
        /// Returns true if SchoolDistrict instances are equal
        /// </summary>
        /// <param name="other">Instance of SchoolDistrict to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolDistrict other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NcesDistrictId == other.NcesDistrictId ||
                    this.NcesDistrictId != null &&
                    this.NcesDistrictId.Equals(other.NcesDistrictId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.TotalSchools == other.TotalSchools ||
                    this.TotalSchools != null &&
                    this.TotalSchools.Equals(other.TotalSchools)
                ) && 
                (
                    this.DistrictType == other.DistrictType ||
                    this.DistrictType != null &&
                    this.DistrictType.Equals(other.DistrictType)
                ) && 
                (
                    this.Metro == other.Metro ||
                    this.Metro != null &&
                    this.Metro.Equals(other.Metro)
                ) && 
                (
                    this.AreaInSqM == other.AreaInSqM ||
                    this.AreaInSqM != null &&
                    this.AreaInSqM.Equals(other.AreaInSqM)
                ) && 
                (
                    this.SupervisoryUnionId == other.SupervisoryUnionId ||
                    this.SupervisoryUnionId != null &&
                    this.SupervisoryUnionId.Equals(other.SupervisoryUnionId)
                ) && 
                (
                    this.DistrictEnrollment == other.DistrictEnrollment ||
                    this.DistrictEnrollment != null &&
                    this.DistrictEnrollment.Equals(other.DistrictEnrollment)
                ) && 
                (
                    this.DistrictUrl == other.DistrictUrl ||
                    this.DistrictUrl != null &&
                    this.DistrictUrl.Equals(other.DistrictUrl)
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
                if (this.NcesDistrictId != null)
                    hash = hash * 59 + this.NcesDistrictId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.TotalSchools != null)
                    hash = hash * 59 + this.TotalSchools.GetHashCode();
                if (this.DistrictType != null)
                    hash = hash * 59 + this.DistrictType.GetHashCode();
                if (this.Metro != null)
                    hash = hash * 59 + this.Metro.GetHashCode();
                if (this.AreaInSqM != null)
                    hash = hash * 59 + this.AreaInSqM.GetHashCode();
                if (this.SupervisoryUnionId != null)
                    hash = hash * 59 + this.SupervisoryUnionId.GetHashCode();
                if (this.DistrictEnrollment != null)
                    hash = hash * 59 + this.DistrictEnrollment.GetHashCode();
                if (this.DistrictUrl != null)
                    hash = hash * 59 + this.DistrictUrl.GetHashCode();
                return hash;
            }
        }
    }

}
