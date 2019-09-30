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
    /// Dictionary
    /// </summary>
    [DataContract]
    public partial class Dictionary :  IEquatable<Dictionary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dictionary" /> class.
        /// </summary>
        /// <param name="Vintage">Vintage.</param>
        /// <param name="Source">Source.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CountrySupportInfos">CountrySupportInfos.</param>
        public Dictionary(string Vintage = null, string Source = null, string Description = null, List<CountrySupport> CountrySupportInfos = null)
        {
            this.Vintage = Vintage;
            this.Source = Source;
            this.Description = Description;
            this.CountrySupportInfos = CountrySupportInfos;
        }
        
        /// <summary>
        /// Gets or Sets Vintage
        /// </summary>
        [DataMember(Name="vintage", EmitDefaultValue=false)]
        public string Vintage { get; set; }
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets CountrySupportInfos
        /// </summary>
        [DataMember(Name="countrySupportInfos", EmitDefaultValue=false)]
        public List<CountrySupport> CountrySupportInfos { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dictionary {\n");
            sb.Append("  Vintage: ").Append(Vintage).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CountrySupportInfos: ").Append(CountrySupportInfos).Append("\n");
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
            return this.Equals(obj as Dictionary);
        }

        /// <summary>
        /// Returns true if Dictionary instances are equal
        /// </summary>
        /// <param name="other">Instance of Dictionary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dictionary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Vintage == other.Vintage ||
                    this.Vintage != null &&
                    this.Vintage.Equals(other.Vintage)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.CountrySupportInfos == other.CountrySupportInfos ||
                    this.CountrySupportInfos != null &&
                    this.CountrySupportInfos.SequenceEqual(other.CountrySupportInfos)
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
                if (this.Vintage != null)
                    hash = hash * 59 + this.Vintage.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.CountrySupportInfos != null)
                    hash = hash * 59 + this.CountrySupportInfos.GetHashCode();
                return hash;
            }
        }
    }

}
