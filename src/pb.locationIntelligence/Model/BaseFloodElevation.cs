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
    /// BaseFloodElevation
    /// </summary>
    [DataContract]
    public partial class BaseFloodElevation :  IEquatable<BaseFloodElevation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFloodElevation" /> class.
        /// </summary>
        /// <param name="Unit">Unit.</param>
        /// <param name="Value">Value.</param>
        public BaseFloodElevation(string Unit = null, string Value = null)
        {
            this.Unit = Unit;
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseFloodElevation {\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as BaseFloodElevation);
        }

        /// <summary>
        /// Returns true if BaseFloodElevation instances are equal
        /// </summary>
        /// <param name="other">Instance of BaseFloodElevation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseFloodElevation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Unit == other.Unit ||
                    this.Unit != null &&
                    this.Unit.Equals(other.Unit)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Unit != null)
                    hash = hash * 59 + this.Unit.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }
    }

}
