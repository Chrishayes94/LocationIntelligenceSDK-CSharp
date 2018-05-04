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
    /// ConfiguredDictionaryResponse
    /// </summary>
    [DataContract]
    public partial class ConfiguredDictionaryResponse :  IEquatable<ConfiguredDictionaryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredDictionaryResponse" /> class.
        /// </summary>
        /// <param name="Dictionaries">Dictionaries.</param>
        public ConfiguredDictionaryResponse(List<Dictionary> Dictionaries = null)
        {
            this.Dictionaries = Dictionaries;
        }
        
        /// <summary>
        /// Gets or Sets Dictionaries
        /// </summary>
        [DataMember(Name="dictionaries", EmitDefaultValue=false)]
        public List<Dictionary> Dictionaries { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfiguredDictionaryResponse {\n");
            sb.Append("  Dictionaries: ").Append(Dictionaries).Append("\n");
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
            return this.Equals(obj as ConfiguredDictionaryResponse);
        }

        /// <summary>
        /// Returns true if ConfiguredDictionaryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfiguredDictionaryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfiguredDictionaryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Dictionaries == other.Dictionaries ||
                    this.Dictionaries != null &&
                    this.Dictionaries.SequenceEqual(other.Dictionaries)
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
                if (this.Dictionaries != null)
                    hash = hash * 59 + this.Dictionaries.GetHashCode();
                return hash;
            }
        }
    }

}
