/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 6.0.0
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
    /// GeocodeAddress
    /// </summary>
    [DataContract]
    public partial class GeocodeAddress :  IEquatable<GeocodeAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodeAddress" /> class.
        /// </summary>
        /// <param name="MainAddressLine">MainAddressLine.</param>
        /// <param name="AddressLastLine">AddressLastLine.</param>
        /// <param name="PlaceName">PlaceName.</param>
        /// <param name="AreaName1">AreaName1.</param>
        /// <param name="AreaName2">AreaName2.</param>
        /// <param name="AreaName3">AreaName3.</param>
        /// <param name="AreaName4">AreaName4.</param>
        /// <param name="PostCode1">PostCode1.</param>
        /// <param name="PostCode2">PostCode2.</param>
        /// <param name="Country">Country.</param>
        /// <param name="AddressNumber">AddressNumber.</param>
        /// <param name="StreetName">StreetName.</param>
        /// <param name="UnitType">UnitType.</param>
        /// <param name="UnitValue">UnitValue.</param>
        /// <param name="CustomFields">CustomFields.</param>
        public GeocodeAddress(string MainAddressLine = null, string AddressLastLine = null, string PlaceName = null, string AreaName1 = null, string AreaName2 = null, string AreaName3 = null, string AreaName4 = null, string PostCode1 = null, string PostCode2 = null, string Country = null, string AddressNumber = null, string StreetName = null, string UnitType = null, string UnitValue = null, Dictionary<string, Object> CustomFields = null)
        {
            this.MainAddressLine = MainAddressLine;
            this.AddressLastLine = AddressLastLine;
            this.PlaceName = PlaceName;
            this.AreaName1 = AreaName1;
            this.AreaName2 = AreaName2;
            this.AreaName3 = AreaName3;
            this.AreaName4 = AreaName4;
            this.PostCode1 = PostCode1;
            this.PostCode2 = PostCode2;
            this.Country = Country;
            this.AddressNumber = AddressNumber;
            this.StreetName = StreetName;
            this.UnitType = UnitType;
            this.UnitValue = UnitValue;
            this.CustomFields = CustomFields;
        }
        
        /// <summary>
        /// Gets or Sets MainAddressLine
        /// </summary>
        [DataMember(Name="mainAddressLine", EmitDefaultValue=false)]
        public string MainAddressLine { get; set; }
        /// <summary>
        /// Gets or Sets AddressLastLine
        /// </summary>
        [DataMember(Name="addressLastLine", EmitDefaultValue=false)]
        public string AddressLastLine { get; set; }
        /// <summary>
        /// Gets or Sets PlaceName
        /// </summary>
        [DataMember(Name="placeName", EmitDefaultValue=false)]
        public string PlaceName { get; set; }
        /// <summary>
        /// Gets or Sets AreaName1
        /// </summary>
        [DataMember(Name="areaName1", EmitDefaultValue=false)]
        public string AreaName1 { get; set; }
        /// <summary>
        /// Gets or Sets AreaName2
        /// </summary>
        [DataMember(Name="areaName2", EmitDefaultValue=false)]
        public string AreaName2 { get; set; }
        /// <summary>
        /// Gets or Sets AreaName3
        /// </summary>
        [DataMember(Name="areaName3", EmitDefaultValue=false)]
        public string AreaName3 { get; set; }
        /// <summary>
        /// Gets or Sets AreaName4
        /// </summary>
        [DataMember(Name="areaName4", EmitDefaultValue=false)]
        public string AreaName4 { get; set; }
        /// <summary>
        /// Gets or Sets PostCode1
        /// </summary>
        [DataMember(Name="postCode1", EmitDefaultValue=false)]
        public string PostCode1 { get; set; }
        /// <summary>
        /// Gets or Sets PostCode2
        /// </summary>
        [DataMember(Name="postCode2", EmitDefaultValue=false)]
        public string PostCode2 { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Gets or Sets AddressNumber
        /// </summary>
        [DataMember(Name="addressNumber", EmitDefaultValue=false)]
        public string AddressNumber { get; set; }
        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name="streetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }
        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [DataMember(Name="unitType", EmitDefaultValue=false)]
        public string UnitType { get; set; }
        /// <summary>
        /// Gets or Sets UnitValue
        /// </summary>
        [DataMember(Name="unitValue", EmitDefaultValue=false)]
        public string UnitValue { get; set; }
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeocodeAddress {\n");
            sb.Append("  MainAddressLine: ").Append(MainAddressLine).Append("\n");
            sb.Append("  AddressLastLine: ").Append(AddressLastLine).Append("\n");
            sb.Append("  PlaceName: ").Append(PlaceName).Append("\n");
            sb.Append("  AreaName1: ").Append(AreaName1).Append("\n");
            sb.Append("  AreaName2: ").Append(AreaName2).Append("\n");
            sb.Append("  AreaName3: ").Append(AreaName3).Append("\n");
            sb.Append("  AreaName4: ").Append(AreaName4).Append("\n");
            sb.Append("  PostCode1: ").Append(PostCode1).Append("\n");
            sb.Append("  PostCode2: ").Append(PostCode2).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AddressNumber: ").Append(AddressNumber).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  UnitValue: ").Append(UnitValue).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
            return this.Equals(obj as GeocodeAddress);
        }

        /// <summary>
        /// Returns true if GeocodeAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of GeocodeAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeocodeAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MainAddressLine == other.MainAddressLine ||
                    this.MainAddressLine != null &&
                    this.MainAddressLine.Equals(other.MainAddressLine)
                ) && 
                (
                    this.AddressLastLine == other.AddressLastLine ||
                    this.AddressLastLine != null &&
                    this.AddressLastLine.Equals(other.AddressLastLine)
                ) && 
                (
                    this.PlaceName == other.PlaceName ||
                    this.PlaceName != null &&
                    this.PlaceName.Equals(other.PlaceName)
                ) && 
                (
                    this.AreaName1 == other.AreaName1 ||
                    this.AreaName1 != null &&
                    this.AreaName1.Equals(other.AreaName1)
                ) && 
                (
                    this.AreaName2 == other.AreaName2 ||
                    this.AreaName2 != null &&
                    this.AreaName2.Equals(other.AreaName2)
                ) && 
                (
                    this.AreaName3 == other.AreaName3 ||
                    this.AreaName3 != null &&
                    this.AreaName3.Equals(other.AreaName3)
                ) && 
                (
                    this.AreaName4 == other.AreaName4 ||
                    this.AreaName4 != null &&
                    this.AreaName4.Equals(other.AreaName4)
                ) && 
                (
                    this.PostCode1 == other.PostCode1 ||
                    this.PostCode1 != null &&
                    this.PostCode1.Equals(other.PostCode1)
                ) && 
                (
                    this.PostCode2 == other.PostCode2 ||
                    this.PostCode2 != null &&
                    this.PostCode2.Equals(other.PostCode2)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.AddressNumber == other.AddressNumber ||
                    this.AddressNumber != null &&
                    this.AddressNumber.Equals(other.AddressNumber)
                ) && 
                (
                    this.StreetName == other.StreetName ||
                    this.StreetName != null &&
                    this.StreetName.Equals(other.StreetName)
                ) && 
                (
                    this.UnitType == other.UnitType ||
                    this.UnitType != null &&
                    this.UnitType.Equals(other.UnitType)
                ) && 
                (
                    this.UnitValue == other.UnitValue ||
                    this.UnitValue != null &&
                    this.UnitValue.Equals(other.UnitValue)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
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
                if (this.MainAddressLine != null)
                    hash = hash * 59 + this.MainAddressLine.GetHashCode();
                if (this.AddressLastLine != null)
                    hash = hash * 59 + this.AddressLastLine.GetHashCode();
                if (this.PlaceName != null)
                    hash = hash * 59 + this.PlaceName.GetHashCode();
                if (this.AreaName1 != null)
                    hash = hash * 59 + this.AreaName1.GetHashCode();
                if (this.AreaName2 != null)
                    hash = hash * 59 + this.AreaName2.GetHashCode();
                if (this.AreaName3 != null)
                    hash = hash * 59 + this.AreaName3.GetHashCode();
                if (this.AreaName4 != null)
                    hash = hash * 59 + this.AreaName4.GetHashCode();
                if (this.PostCode1 != null)
                    hash = hash * 59 + this.PostCode1.GetHashCode();
                if (this.PostCode2 != null)
                    hash = hash * 59 + this.PostCode2.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.AddressNumber != null)
                    hash = hash * 59 + this.AddressNumber.GetHashCode();
                if (this.StreetName != null)
                    hash = hash * 59 + this.StreetName.GetHashCode();
                if (this.UnitType != null)
                    hash = hash * 59 + this.UnitType.GetHashCode();
                if (this.UnitValue != null)
                    hash = hash * 59 + this.UnitValue.GetHashCode();
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                return hash;
            }
        }
    }

}
