/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 6.5.0
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
    /// AreaCodeInfo
    /// </summary>
    [DataContract]
    public partial class AreaCodeInfo :  IEquatable<AreaCodeInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AreaCodeInfo" /> class.
        /// </summary>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="Ocn">Ocn.</param>
        /// <param name="OcnCategory">OcnCategory.</param>
        /// <param name="Npa">Npa.</param>
        /// <param name="Nxx">Nxx.</param>
        /// <param name="StartRange">StartRange.</param>
        /// <param name="EndRange">EndRange.</param>
        /// <param name="Lata">Lata.</param>
        /// <param name="AreaName4">AreaName4.</param>
        public AreaCodeInfo(string CompanyName = null, string Ocn = null, string OcnCategory = null, string Npa = null, string Nxx = null, string StartRange = null, string EndRange = null, string Lata = null, string AreaName4 = null)
        {
            this.CompanyName = CompanyName;
            this.Ocn = Ocn;
            this.OcnCategory = OcnCategory;
            this.Npa = Npa;
            this.Nxx = Nxx;
            this.StartRange = StartRange;
            this.EndRange = EndRange;
            this.Lata = Lata;
            this.AreaName4 = AreaName4;
        }
        
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
        /// <summary>
        /// Gets or Sets Ocn
        /// </summary>
        [DataMember(Name="ocn", EmitDefaultValue=false)]
        public string Ocn { get; set; }
        /// <summary>
        /// Gets or Sets OcnCategory
        /// </summary>
        [DataMember(Name="ocnCategory", EmitDefaultValue=false)]
        public string OcnCategory { get; set; }
        /// <summary>
        /// Gets or Sets Npa
        /// </summary>
        [DataMember(Name="npa", EmitDefaultValue=false)]
        public string Npa { get; set; }
        /// <summary>
        /// Gets or Sets Nxx
        /// </summary>
        [DataMember(Name="nxx", EmitDefaultValue=false)]
        public string Nxx { get; set; }
        /// <summary>
        /// Gets or Sets StartRange
        /// </summary>
        [DataMember(Name="startRange", EmitDefaultValue=false)]
        public string StartRange { get; set; }
        /// <summary>
        /// Gets or Sets EndRange
        /// </summary>
        [DataMember(Name="endRange", EmitDefaultValue=false)]
        public string EndRange { get; set; }
        /// <summary>
        /// Gets or Sets Lata
        /// </summary>
        [DataMember(Name="lata", EmitDefaultValue=false)]
        public string Lata { get; set; }
        /// <summary>
        /// Gets or Sets AreaName4
        /// </summary>
        [DataMember(Name="areaName4", EmitDefaultValue=false)]
        public string AreaName4 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AreaCodeInfo {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Ocn: ").Append(Ocn).Append("\n");
            sb.Append("  OcnCategory: ").Append(OcnCategory).Append("\n");
            sb.Append("  Npa: ").Append(Npa).Append("\n");
            sb.Append("  Nxx: ").Append(Nxx).Append("\n");
            sb.Append("  StartRange: ").Append(StartRange).Append("\n");
            sb.Append("  EndRange: ").Append(EndRange).Append("\n");
            sb.Append("  Lata: ").Append(Lata).Append("\n");
            sb.Append("  AreaName4: ").Append(AreaName4).Append("\n");
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
            return this.Equals(obj as AreaCodeInfo);
        }

        /// <summary>
        /// Returns true if AreaCodeInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AreaCodeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AreaCodeInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.Ocn == other.Ocn ||
                    this.Ocn != null &&
                    this.Ocn.Equals(other.Ocn)
                ) && 
                (
                    this.OcnCategory == other.OcnCategory ||
                    this.OcnCategory != null &&
                    this.OcnCategory.Equals(other.OcnCategory)
                ) && 
                (
                    this.Npa == other.Npa ||
                    this.Npa != null &&
                    this.Npa.Equals(other.Npa)
                ) && 
                (
                    this.Nxx == other.Nxx ||
                    this.Nxx != null &&
                    this.Nxx.Equals(other.Nxx)
                ) && 
                (
                    this.StartRange == other.StartRange ||
                    this.StartRange != null &&
                    this.StartRange.Equals(other.StartRange)
                ) && 
                (
                    this.EndRange == other.EndRange ||
                    this.EndRange != null &&
                    this.EndRange.Equals(other.EndRange)
                ) && 
                (
                    this.Lata == other.Lata ||
                    this.Lata != null &&
                    this.Lata.Equals(other.Lata)
                ) && 
                (
                    this.AreaName4 == other.AreaName4 ||
                    this.AreaName4 != null &&
                    this.AreaName4.Equals(other.AreaName4)
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
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.Ocn != null)
                    hash = hash * 59 + this.Ocn.GetHashCode();
                if (this.OcnCategory != null)
                    hash = hash * 59 + this.OcnCategory.GetHashCode();
                if (this.Npa != null)
                    hash = hash * 59 + this.Npa.GetHashCode();
                if (this.Nxx != null)
                    hash = hash * 59 + this.Nxx.GetHashCode();
                if (this.StartRange != null)
                    hash = hash * 59 + this.StartRange.GetHashCode();
                if (this.EndRange != null)
                    hash = hash * 59 + this.EndRange.GetHashCode();
                if (this.Lata != null)
                    hash = hash * 59 + this.Lata.GetHashCode();
                if (this.AreaName4 != null)
                    hash = hash * 59 + this.AreaName4.GetHashCode();
                return hash;
            }
        }
    }

}
