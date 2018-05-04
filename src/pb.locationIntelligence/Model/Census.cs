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
    /// Census
    /// </summary>
    [DataContract]
    public partial class Census :  IEquatable<Census>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Census" /> class.
        /// </summary>
        /// <param name="Cbsa">Cbsa.</param>
        /// <param name="MatchLevel">MatchLevel.</param>
        /// <param name="MatchCode">MatchCode.</param>
        /// <param name="Tract">Tract.</param>
        /// <param name="Mcd">Mcd.</param>
        public Census(Cbsa Cbsa = null, string MatchLevel = null, string MatchCode = null, string Tract = null, Mcd Mcd = null)
        {
            this.Cbsa = Cbsa;
            this.MatchLevel = MatchLevel;
            this.MatchCode = MatchCode;
            this.Tract = Tract;
            this.Mcd = Mcd;
        }
        
        /// <summary>
        /// Gets or Sets Cbsa
        /// </summary>
        [DataMember(Name="cbsa", EmitDefaultValue=false)]
        public Cbsa Cbsa { get; set; }
        /// <summary>
        /// Gets or Sets MatchLevel
        /// </summary>
        [DataMember(Name="matchLevel", EmitDefaultValue=false)]
        public string MatchLevel { get; set; }
        /// <summary>
        /// Gets or Sets MatchCode
        /// </summary>
        [DataMember(Name="matchCode", EmitDefaultValue=false)]
        public string MatchCode { get; set; }
        /// <summary>
        /// Gets or Sets Tract
        /// </summary>
        [DataMember(Name="tract", EmitDefaultValue=false)]
        public string Tract { get; set; }
        /// <summary>
        /// Gets or Sets Mcd
        /// </summary>
        [DataMember(Name="mcd", EmitDefaultValue=false)]
        public Mcd Mcd { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Census {\n");
            sb.Append("  Cbsa: ").Append(Cbsa).Append("\n");
            sb.Append("  MatchLevel: ").Append(MatchLevel).Append("\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
            sb.Append("  Tract: ").Append(Tract).Append("\n");
            sb.Append("  Mcd: ").Append(Mcd).Append("\n");
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
            return this.Equals(obj as Census);
        }

        /// <summary>
        /// Returns true if Census instances are equal
        /// </summary>
        /// <param name="other">Instance of Census to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Census other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cbsa == other.Cbsa ||
                    this.Cbsa != null &&
                    this.Cbsa.Equals(other.Cbsa)
                ) && 
                (
                    this.MatchLevel == other.MatchLevel ||
                    this.MatchLevel != null &&
                    this.MatchLevel.Equals(other.MatchLevel)
                ) && 
                (
                    this.MatchCode == other.MatchCode ||
                    this.MatchCode != null &&
                    this.MatchCode.Equals(other.MatchCode)
                ) && 
                (
                    this.Tract == other.Tract ||
                    this.Tract != null &&
                    this.Tract.Equals(other.Tract)
                ) && 
                (
                    this.Mcd == other.Mcd ||
                    this.Mcd != null &&
                    this.Mcd.Equals(other.Mcd)
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
                if (this.Cbsa != null)
                    hash = hash * 59 + this.Cbsa.GetHashCode();
                if (this.MatchLevel != null)
                    hash = hash * 59 + this.MatchLevel.GetHashCode();
                if (this.MatchCode != null)
                    hash = hash * 59 + this.MatchCode.GetHashCode();
                if (this.Tract != null)
                    hash = hash * 59 + this.Tract.GetHashCode();
                if (this.Mcd != null)
                    hash = hash * 59 + this.Mcd.GetHashCode();
                return hash;
            }
        }
    }

}
