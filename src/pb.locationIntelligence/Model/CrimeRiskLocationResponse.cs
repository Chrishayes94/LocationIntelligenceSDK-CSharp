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
    /// CrimeRiskLocationResponse
    /// </summary>
    [DataContract]
    public partial class CrimeRiskLocationResponse :  IEquatable<CrimeRiskLocationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrimeRiskLocationResponse" /> class.
        /// </summary>
        /// <param name="Themes">Themes.</param>
        /// <param name="Boundaries">Boundaries.</param>
        public CrimeRiskLocationResponse(List<GeoRiskCrimeTheme> Themes = null, GeoRiskBoundaries Boundaries = null)
        {
            this.Themes = Themes;
            this.Boundaries = Boundaries;
        }
        
        /// <summary>
        /// Gets or Sets Themes
        /// </summary>
        [DataMember(Name="themes", EmitDefaultValue=false)]
        public List<GeoRiskCrimeTheme> Themes { get; set; }
        /// <summary>
        /// Gets or Sets Boundaries
        /// </summary>
        [DataMember(Name="boundaries", EmitDefaultValue=false)]
        public GeoRiskBoundaries Boundaries { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrimeRiskLocationResponse {\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  Boundaries: ").Append(Boundaries).Append("\n");
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
            return this.Equals(obj as CrimeRiskLocationResponse);
        }

        /// <summary>
        /// Returns true if CrimeRiskLocationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CrimeRiskLocationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrimeRiskLocationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Themes == other.Themes ||
                    this.Themes != null &&
                    this.Themes.SequenceEqual(other.Themes)
                ) && 
                (
                    this.Boundaries == other.Boundaries ||
                    this.Boundaries != null &&
                    this.Boundaries.Equals(other.Boundaries)
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
                if (this.Themes != null)
                    hash = hash * 59 + this.Themes.GetHashCode();
                if (this.Boundaries != null)
                    hash = hash * 59 + this.Boundaries.GetHashCode();
                return hash;
            }
        }
    }

}
