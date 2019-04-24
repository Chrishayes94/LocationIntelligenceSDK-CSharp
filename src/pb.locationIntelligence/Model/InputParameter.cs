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
    /// InputParameter
    /// </summary>
    [DataContract]
    public partial class InputParameter :  IEquatable<InputParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputParameter" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Type">Type.</param>
        /// <param name="DefaultValue">DefaultValue.</param>
        /// <param name="LowBoundary">LowBoundary.</param>
        /// <param name="HighBoundary">HighBoundary.</param>
        /// <param name="AllowedValuesWithDescriptions">AllowedValuesWithDescriptions.</param>
        public InputParameter(string Name = null, string Description = null, string Type = null, string DefaultValue = null, string LowBoundary = null, string HighBoundary = null, Dictionary<string, Object> AllowedValuesWithDescriptions = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Type = Type;
            this.DefaultValue = DefaultValue;
            this.LowBoundary = LowBoundary;
            this.HighBoundary = HighBoundary;
            this.AllowedValuesWithDescriptions = AllowedValuesWithDescriptions;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }
        /// <summary>
        /// Gets or Sets LowBoundary
        /// </summary>
        [DataMember(Name="lowBoundary", EmitDefaultValue=false)]
        public string LowBoundary { get; set; }
        /// <summary>
        /// Gets or Sets HighBoundary
        /// </summary>
        [DataMember(Name="highBoundary", EmitDefaultValue=false)]
        public string HighBoundary { get; set; }
        /// <summary>
        /// Gets or Sets AllowedValuesWithDescriptions
        /// </summary>
        [DataMember(Name="allowedValuesWithDescriptions", EmitDefaultValue=false)]
        public Dictionary<string, Object> AllowedValuesWithDescriptions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputParameter {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  LowBoundary: ").Append(LowBoundary).Append("\n");
            sb.Append("  HighBoundary: ").Append(HighBoundary).Append("\n");
            sb.Append("  AllowedValuesWithDescriptions: ").Append(AllowedValuesWithDescriptions).Append("\n");
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
            return this.Equals(obj as InputParameter);
        }

        /// <summary>
        /// Returns true if InputParameter instances are equal
        /// </summary>
        /// <param name="other">Instance of InputParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputParameter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.DefaultValue == other.DefaultValue ||
                    this.DefaultValue != null &&
                    this.DefaultValue.Equals(other.DefaultValue)
                ) && 
                (
                    this.LowBoundary == other.LowBoundary ||
                    this.LowBoundary != null &&
                    this.LowBoundary.Equals(other.LowBoundary)
                ) && 
                (
                    this.HighBoundary == other.HighBoundary ||
                    this.HighBoundary != null &&
                    this.HighBoundary.Equals(other.HighBoundary)
                ) && 
                (
                    this.AllowedValuesWithDescriptions == other.AllowedValuesWithDescriptions ||
                    this.AllowedValuesWithDescriptions != null &&
                    this.AllowedValuesWithDescriptions.SequenceEqual(other.AllowedValuesWithDescriptions)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.DefaultValue != null)
                    hash = hash * 59 + this.DefaultValue.GetHashCode();
                if (this.LowBoundary != null)
                    hash = hash * 59 + this.LowBoundary.GetHashCode();
                if (this.HighBoundary != null)
                    hash = hash * 59 + this.HighBoundary.GetHashCode();
                if (this.AllowedValuesWithDescriptions != null)
                    hash = hash * 59 + this.AllowedValuesWithDescriptions.GetHashCode();
                return hash;
            }
        }
    }

}
