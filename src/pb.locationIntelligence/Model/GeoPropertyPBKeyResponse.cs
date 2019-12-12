/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 8.0.0
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
    /// GeoPropertyPBKeyResponse
    /// </summary>
    [DataContract]
    public partial class GeoPropertyPBKeyResponse :  IEquatable<GeoPropertyPBKeyResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoPropertyPBKeyResponse" /> class.
        /// </summary>
        /// <param name="ObjectId">ObjectId.</param>
        /// <param name="Category">Category.</param>
        /// <param name="IndividualValueVariable">IndividualValueVariable.</param>
        public GeoPropertyPBKeyResponse(string ObjectId = null, string Category = null, List<IndividualValueVariable> IndividualValueVariable = null)
        {
            this.ObjectId = ObjectId;
            this.Category = Category;
            this.IndividualValueVariable = IndividualValueVariable;
        }
        
        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        /// <summary>
        /// Gets or Sets IndividualValueVariable
        /// </summary>
        [DataMember(Name="individualValueVariable", EmitDefaultValue=false)]
        public List<IndividualValueVariable> IndividualValueVariable { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoPropertyPBKeyResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  IndividualValueVariable: ").Append(IndividualValueVariable).Append("\n");
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
            return this.Equals(obj as GeoPropertyPBKeyResponse);
        }

        /// <summary>
        /// Returns true if GeoPropertyPBKeyResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GeoPropertyPBKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoPropertyPBKeyResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ObjectId == other.ObjectId ||
                    this.ObjectId != null &&
                    this.ObjectId.Equals(other.ObjectId)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.IndividualValueVariable == other.IndividualValueVariable ||
                    this.IndividualValueVariable != null &&
                    this.IndividualValueVariable.SequenceEqual(other.IndividualValueVariable)
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
                if (this.ObjectId != null)
                    hash = hash * 59 + this.ObjectId.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.IndividualValueVariable != null)
                    hash = hash * 59 + this.IndividualValueVariable.GetHashCode();
                return hash;
            }
        }
    }

}
