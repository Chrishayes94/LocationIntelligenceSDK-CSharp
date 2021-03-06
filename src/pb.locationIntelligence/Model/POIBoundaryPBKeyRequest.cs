/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 8.5.0
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
    /// POIBoundaryPBKeyRequest
    /// </summary>
    [DataContract]
    public partial class POIBoundaryPBKeyRequest :  IEquatable<POIBoundaryPBKeyRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="POIBoundaryPBKeyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected POIBoundaryPBKeyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="POIBoundaryPBKeyRequest" /> class.
        /// </summary>
        /// <param name="Pbkeys">Pbkeys (required).</param>
        /// <param name="Preferences">Preferences.</param>
        public POIBoundaryPBKeyRequest(List<POIBoundaryPBKey> Pbkeys = null, PoiBoundaryPreferences Preferences = null)
        {
            // to ensure "Pbkeys" is required (not null)
            if (Pbkeys == null)
            {
                throw new InvalidDataException("Pbkeys is a required property for POIBoundaryPBKeyRequest and cannot be null");
            }
            else
            {
                this.Pbkeys = Pbkeys;
            }
            this.Preferences = Preferences;
        }
        
        /// <summary>
        /// Gets or Sets Pbkeys
        /// </summary>
        [DataMember(Name="pbkeys", EmitDefaultValue=false)]
        public List<POIBoundaryPBKey> Pbkeys { get; set; }
        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public PoiBoundaryPreferences Preferences { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class POIBoundaryPBKeyRequest {\n");
            sb.Append("  Pbkeys: ").Append(Pbkeys).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
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
            return this.Equals(obj as POIBoundaryPBKeyRequest);
        }

        /// <summary>
        /// Returns true if POIBoundaryPBKeyRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of POIBoundaryPBKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(POIBoundaryPBKeyRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Pbkeys == other.Pbkeys ||
                    this.Pbkeys != null &&
                    this.Pbkeys.SequenceEqual(other.Pbkeys)
                ) && 
                (
                    this.Preferences == other.Preferences ||
                    this.Preferences != null &&
                    this.Preferences.Equals(other.Preferences)
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
                if (this.Pbkeys != null)
                    hash = hash * 59 + this.Pbkeys.GetHashCode();
                if (this.Preferences != null)
                    hash = hash * 59 + this.Preferences.GetHashCode();
                return hash;
            }
        }
    }

}
