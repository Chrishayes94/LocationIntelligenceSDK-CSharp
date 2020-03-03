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
    /// FieldsMatching
    /// </summary>
    [DataContract]
    public partial class FieldsMatching :  IEquatable<FieldsMatching>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsMatching" /> class.
        /// </summary>
        /// <param name="MatchOnAddressNumber">MatchOnAddressNumber (default to false).</param>
        /// <param name="MatchOnPostCode1">MatchOnPostCode1 (default to false).</param>
        /// <param name="MatchOnPostCode2">MatchOnPostCode2 (default to false).</param>
        /// <param name="MatchOnAreaName1">MatchOnAreaName1 (default to false).</param>
        /// <param name="MatchOnAreaName2">MatchOnAreaName2 (default to false).</param>
        /// <param name="MatchOnAreaName3">MatchOnAreaName3 (default to false).</param>
        /// <param name="MatchOnAreaName4">MatchOnAreaName4 (default to false).</param>
        /// <param name="MatchOnAllStreetFields">MatchOnAllStreetFields (default to false).</param>
        /// <param name="MatchOnStreetName">MatchOnStreetName (default to false).</param>
        /// <param name="MatchOnStreetType">MatchOnStreetType (default to false).</param>
        /// <param name="MatchOnStreetDirectional">MatchOnStreetDirectional (default to false).</param>
        /// <param name="MatchOnPlaceName">MatchOnPlaceName (default to false).</param>
        /// <param name="MatchOnInputFields">MatchOnInputFields (default to false).</param>
        public FieldsMatching(bool? MatchOnAddressNumber = null, bool? MatchOnPostCode1 = null, bool? MatchOnPostCode2 = null, bool? MatchOnAreaName1 = null, bool? MatchOnAreaName2 = null, bool? MatchOnAreaName3 = null, bool? MatchOnAreaName4 = null, bool? MatchOnAllStreetFields = null, bool? MatchOnStreetName = null, bool? MatchOnStreetType = null, bool? MatchOnStreetDirectional = null, bool? MatchOnPlaceName = null, bool? MatchOnInputFields = null)
        {
            // use default value if no "MatchOnAddressNumber" provided
            if (MatchOnAddressNumber == null)
            {
                this.MatchOnAddressNumber = false;
            }
            else
            {
                this.MatchOnAddressNumber = MatchOnAddressNumber;
            }
            // use default value if no "MatchOnPostCode1" provided
            if (MatchOnPostCode1 == null)
            {
                this.MatchOnPostCode1 = false;
            }
            else
            {
                this.MatchOnPostCode1 = MatchOnPostCode1;
            }
            // use default value if no "MatchOnPostCode2" provided
            if (MatchOnPostCode2 == null)
            {
                this.MatchOnPostCode2 = false;
            }
            else
            {
                this.MatchOnPostCode2 = MatchOnPostCode2;
            }
            // use default value if no "MatchOnAreaName1" provided
            if (MatchOnAreaName1 == null)
            {
                this.MatchOnAreaName1 = false;
            }
            else
            {
                this.MatchOnAreaName1 = MatchOnAreaName1;
            }
            // use default value if no "MatchOnAreaName2" provided
            if (MatchOnAreaName2 == null)
            {
                this.MatchOnAreaName2 = false;
            }
            else
            {
                this.MatchOnAreaName2 = MatchOnAreaName2;
            }
            // use default value if no "MatchOnAreaName3" provided
            if (MatchOnAreaName3 == null)
            {
                this.MatchOnAreaName3 = false;
            }
            else
            {
                this.MatchOnAreaName3 = MatchOnAreaName3;
            }
            // use default value if no "MatchOnAreaName4" provided
            if (MatchOnAreaName4 == null)
            {
                this.MatchOnAreaName4 = false;
            }
            else
            {
                this.MatchOnAreaName4 = MatchOnAreaName4;
            }
            // use default value if no "MatchOnAllStreetFields" provided
            if (MatchOnAllStreetFields == null)
            {
                this.MatchOnAllStreetFields = false;
            }
            else
            {
                this.MatchOnAllStreetFields = MatchOnAllStreetFields;
            }
            // use default value if no "MatchOnStreetName" provided
            if (MatchOnStreetName == null)
            {
                this.MatchOnStreetName = false;
            }
            else
            {
                this.MatchOnStreetName = MatchOnStreetName;
            }
            // use default value if no "MatchOnStreetType" provided
            if (MatchOnStreetType == null)
            {
                this.MatchOnStreetType = false;
            }
            else
            {
                this.MatchOnStreetType = MatchOnStreetType;
            }
            // use default value if no "MatchOnStreetDirectional" provided
            if (MatchOnStreetDirectional == null)
            {
                this.MatchOnStreetDirectional = false;
            }
            else
            {
                this.MatchOnStreetDirectional = MatchOnStreetDirectional;
            }
            // use default value if no "MatchOnPlaceName" provided
            if (MatchOnPlaceName == null)
            {
                this.MatchOnPlaceName = false;
            }
            else
            {
                this.MatchOnPlaceName = MatchOnPlaceName;
            }
            // use default value if no "MatchOnInputFields" provided
            if (MatchOnInputFields == null)
            {
                this.MatchOnInputFields = false;
            }
            else
            {
                this.MatchOnInputFields = MatchOnInputFields;
            }
        }
        
        /// <summary>
        /// Gets or Sets MatchOnAddressNumber
        /// </summary>
        [DataMember(Name="matchOnAddressNumber", EmitDefaultValue=false)]
        public bool? MatchOnAddressNumber { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnPostCode1
        /// </summary>
        [DataMember(Name="matchOnPostCode1", EmitDefaultValue=false)]
        public bool? MatchOnPostCode1 { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnPostCode2
        /// </summary>
        [DataMember(Name="matchOnPostCode2", EmitDefaultValue=false)]
        public bool? MatchOnPostCode2 { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnAreaName1
        /// </summary>
        [DataMember(Name="matchOnAreaName1", EmitDefaultValue=false)]
        public bool? MatchOnAreaName1 { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnAreaName2
        /// </summary>
        [DataMember(Name="matchOnAreaName2", EmitDefaultValue=false)]
        public bool? MatchOnAreaName2 { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnAreaName3
        /// </summary>
        [DataMember(Name="matchOnAreaName3", EmitDefaultValue=false)]
        public bool? MatchOnAreaName3 { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnAreaName4
        /// </summary>
        [DataMember(Name="matchOnAreaName4", EmitDefaultValue=false)]
        public bool? MatchOnAreaName4 { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnAllStreetFields
        /// </summary>
        [DataMember(Name="matchOnAllStreetFields", EmitDefaultValue=false)]
        public bool? MatchOnAllStreetFields { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnStreetName
        /// </summary>
        [DataMember(Name="matchOnStreetName", EmitDefaultValue=false)]
        public bool? MatchOnStreetName { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnStreetType
        /// </summary>
        [DataMember(Name="matchOnStreetType", EmitDefaultValue=false)]
        public bool? MatchOnStreetType { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnStreetDirectional
        /// </summary>
        [DataMember(Name="matchOnStreetDirectional", EmitDefaultValue=false)]
        public bool? MatchOnStreetDirectional { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnPlaceName
        /// </summary>
        [DataMember(Name="matchOnPlaceName", EmitDefaultValue=false)]
        public bool? MatchOnPlaceName { get; set; }
        /// <summary>
        /// Gets or Sets MatchOnInputFields
        /// </summary>
        [DataMember(Name="matchOnInputFields", EmitDefaultValue=false)]
        public bool? MatchOnInputFields { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldsMatching {\n");
            sb.Append("  MatchOnAddressNumber: ").Append(MatchOnAddressNumber).Append("\n");
            sb.Append("  MatchOnPostCode1: ").Append(MatchOnPostCode1).Append("\n");
            sb.Append("  MatchOnPostCode2: ").Append(MatchOnPostCode2).Append("\n");
            sb.Append("  MatchOnAreaName1: ").Append(MatchOnAreaName1).Append("\n");
            sb.Append("  MatchOnAreaName2: ").Append(MatchOnAreaName2).Append("\n");
            sb.Append("  MatchOnAreaName3: ").Append(MatchOnAreaName3).Append("\n");
            sb.Append("  MatchOnAreaName4: ").Append(MatchOnAreaName4).Append("\n");
            sb.Append("  MatchOnAllStreetFields: ").Append(MatchOnAllStreetFields).Append("\n");
            sb.Append("  MatchOnStreetName: ").Append(MatchOnStreetName).Append("\n");
            sb.Append("  MatchOnStreetType: ").Append(MatchOnStreetType).Append("\n");
            sb.Append("  MatchOnStreetDirectional: ").Append(MatchOnStreetDirectional).Append("\n");
            sb.Append("  MatchOnPlaceName: ").Append(MatchOnPlaceName).Append("\n");
            sb.Append("  MatchOnInputFields: ").Append(MatchOnInputFields).Append("\n");
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
            return this.Equals(obj as FieldsMatching);
        }

        /// <summary>
        /// Returns true if FieldsMatching instances are equal
        /// </summary>
        /// <param name="other">Instance of FieldsMatching to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldsMatching other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MatchOnAddressNumber == other.MatchOnAddressNumber ||
                    this.MatchOnAddressNumber != null &&
                    this.MatchOnAddressNumber.Equals(other.MatchOnAddressNumber)
                ) && 
                (
                    this.MatchOnPostCode1 == other.MatchOnPostCode1 ||
                    this.MatchOnPostCode1 != null &&
                    this.MatchOnPostCode1.Equals(other.MatchOnPostCode1)
                ) && 
                (
                    this.MatchOnPostCode2 == other.MatchOnPostCode2 ||
                    this.MatchOnPostCode2 != null &&
                    this.MatchOnPostCode2.Equals(other.MatchOnPostCode2)
                ) && 
                (
                    this.MatchOnAreaName1 == other.MatchOnAreaName1 ||
                    this.MatchOnAreaName1 != null &&
                    this.MatchOnAreaName1.Equals(other.MatchOnAreaName1)
                ) && 
                (
                    this.MatchOnAreaName2 == other.MatchOnAreaName2 ||
                    this.MatchOnAreaName2 != null &&
                    this.MatchOnAreaName2.Equals(other.MatchOnAreaName2)
                ) && 
                (
                    this.MatchOnAreaName3 == other.MatchOnAreaName3 ||
                    this.MatchOnAreaName3 != null &&
                    this.MatchOnAreaName3.Equals(other.MatchOnAreaName3)
                ) && 
                (
                    this.MatchOnAreaName4 == other.MatchOnAreaName4 ||
                    this.MatchOnAreaName4 != null &&
                    this.MatchOnAreaName4.Equals(other.MatchOnAreaName4)
                ) && 
                (
                    this.MatchOnAllStreetFields == other.MatchOnAllStreetFields ||
                    this.MatchOnAllStreetFields != null &&
                    this.MatchOnAllStreetFields.Equals(other.MatchOnAllStreetFields)
                ) && 
                (
                    this.MatchOnStreetName == other.MatchOnStreetName ||
                    this.MatchOnStreetName != null &&
                    this.MatchOnStreetName.Equals(other.MatchOnStreetName)
                ) && 
                (
                    this.MatchOnStreetType == other.MatchOnStreetType ||
                    this.MatchOnStreetType != null &&
                    this.MatchOnStreetType.Equals(other.MatchOnStreetType)
                ) && 
                (
                    this.MatchOnStreetDirectional == other.MatchOnStreetDirectional ||
                    this.MatchOnStreetDirectional != null &&
                    this.MatchOnStreetDirectional.Equals(other.MatchOnStreetDirectional)
                ) && 
                (
                    this.MatchOnPlaceName == other.MatchOnPlaceName ||
                    this.MatchOnPlaceName != null &&
                    this.MatchOnPlaceName.Equals(other.MatchOnPlaceName)
                ) && 
                (
                    this.MatchOnInputFields == other.MatchOnInputFields ||
                    this.MatchOnInputFields != null &&
                    this.MatchOnInputFields.Equals(other.MatchOnInputFields)
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
                if (this.MatchOnAddressNumber != null)
                    hash = hash * 59 + this.MatchOnAddressNumber.GetHashCode();
                if (this.MatchOnPostCode1 != null)
                    hash = hash * 59 + this.MatchOnPostCode1.GetHashCode();
                if (this.MatchOnPostCode2 != null)
                    hash = hash * 59 + this.MatchOnPostCode2.GetHashCode();
                if (this.MatchOnAreaName1 != null)
                    hash = hash * 59 + this.MatchOnAreaName1.GetHashCode();
                if (this.MatchOnAreaName2 != null)
                    hash = hash * 59 + this.MatchOnAreaName2.GetHashCode();
                if (this.MatchOnAreaName3 != null)
                    hash = hash * 59 + this.MatchOnAreaName3.GetHashCode();
                if (this.MatchOnAreaName4 != null)
                    hash = hash * 59 + this.MatchOnAreaName4.GetHashCode();
                if (this.MatchOnAllStreetFields != null)
                    hash = hash * 59 + this.MatchOnAllStreetFields.GetHashCode();
                if (this.MatchOnStreetName != null)
                    hash = hash * 59 + this.MatchOnStreetName.GetHashCode();
                if (this.MatchOnStreetType != null)
                    hash = hash * 59 + this.MatchOnStreetType.GetHashCode();
                if (this.MatchOnStreetDirectional != null)
                    hash = hash * 59 + this.MatchOnStreetDirectional.GetHashCode();
                if (this.MatchOnPlaceName != null)
                    hash = hash * 59 + this.MatchOnPlaceName.GetHashCode();
                if (this.MatchOnInputFields != null)
                    hash = hash * 59 + this.MatchOnInputFields.GetHashCode();
                return hash;
            }
        }
    }

}
