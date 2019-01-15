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
    /// Address
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="ObjectId">ObjectId.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="StreetSide">StreetSide.</param>
        /// <param name="BusinessName">BusinessName.</param>
        /// <param name="AddressLine1">AddressLine1.</param>
        /// <param name="AddressLine2">AddressLine2.</param>
        /// <param name="AddressLine3">AddressLine3.</param>
        /// <param name="City">City.</param>
        /// <param name="StateProvince">StateProvince.</param>
        /// <param name="County">County.</param>
        /// <param name="PostalCode">PostalCode.</param>
        /// <param name="Latitude">Latitude.</param>
        /// <param name="Longitude">Longitude.</param>
        /// <param name="Status">Status.</param>
        /// <param name="UrbanizationName">UrbanizationName.</param>
        /// <param name="FormattedAddress">FormattedAddress.</param>
        /// <param name="MainAddressLine">MainAddressLine.</param>
        /// <param name="AddressLastLine">AddressLastLine.</param>
        /// <param name="PlaceName">PlaceName.</param>
        /// <param name="AreaName1">AreaName1.</param>
        /// <param name="AreaName2">AreaName2.</param>
        /// <param name="AreaName3">AreaName3.</param>
        /// <param name="AreaName4">AreaName4.</param>
        /// <param name="PostCode">PostCode.</param>
        /// <param name="PostCodeExt">PostCodeExt.</param>
        /// <param name="Country">Country.</param>
        /// <param name="AddressNumber">AddressNumber.</param>
        /// <param name="StreetName">StreetName.</param>
        /// <param name="UnitType">UnitType.</param>
        /// <param name="UnitValue">UnitValue.</param>
        public Address(string ObjectId = null, string DisplayName = null, string StreetSide = null, string BusinessName = null, string AddressLine1 = null, string AddressLine2 = null, string AddressLine3 = null, string City = null, string StateProvince = null, string County = null, string PostalCode = null, string Latitude = null, string Longitude = null, string Status = null, string UrbanizationName = null, string FormattedAddress = null, string MainAddressLine = null, string AddressLastLine = null, string PlaceName = null, string AreaName1 = null, string AreaName2 = null, string AreaName3 = null, string AreaName4 = null, string PostCode = null, string PostCodeExt = null, string Country = null, string AddressNumber = null, string StreetName = null, string UnitType = null, string UnitValue = null)
        {
            this.ObjectId = ObjectId;
            this.DisplayName = DisplayName;
            this.StreetSide = StreetSide;
            this.BusinessName = BusinessName;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.AddressLine3 = AddressLine3;
            this.City = City;
            this.StateProvince = StateProvince;
            this.County = County;
            this.PostalCode = PostalCode;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.Status = Status;
            this.UrbanizationName = UrbanizationName;
            this.FormattedAddress = FormattedAddress;
            this.MainAddressLine = MainAddressLine;
            this.AddressLastLine = AddressLastLine;
            this.PlaceName = PlaceName;
            this.AreaName1 = AreaName1;
            this.AreaName2 = AreaName2;
            this.AreaName3 = AreaName3;
            this.AreaName4 = AreaName4;
            this.PostCode = PostCode;
            this.PostCodeExt = PostCodeExt;
            this.Country = Country;
            this.AddressNumber = AddressNumber;
            this.StreetName = StreetName;
            this.UnitType = UnitType;
            this.UnitValue = UnitValue;
        }
        
        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets StreetSide
        /// </summary>
        [DataMember(Name="streetSide", EmitDefaultValue=false)]
        public string StreetSide { get; set; }
        /// <summary>
        /// Gets or Sets BusinessName
        /// </summary>
        [DataMember(Name="businessName", EmitDefaultValue=false)]
        public string BusinessName { get; set; }
        /// <summary>
        /// Gets or Sets AddressLine1
        /// </summary>
        [DataMember(Name="addressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }
        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        [DataMember(Name="addressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }
        /// <summary>
        /// Gets or Sets AddressLine3
        /// </summary>
        [DataMember(Name="addressLine3", EmitDefaultValue=false)]
        public string AddressLine3 { get; set; }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Gets or Sets StateProvince
        /// </summary>
        [DataMember(Name="stateProvince", EmitDefaultValue=false)]
        public string StateProvince { get; set; }
        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }
        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }
        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets UrbanizationName
        /// </summary>
        [DataMember(Name="urbanizationName", EmitDefaultValue=false)]
        public string UrbanizationName { get; set; }
        /// <summary>
        /// Gets or Sets FormattedAddress
        /// </summary>
        [DataMember(Name="formattedAddress", EmitDefaultValue=false)]
        public string FormattedAddress { get; set; }
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
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }
        /// <summary>
        /// Gets or Sets PostCodeExt
        /// </summary>
        [DataMember(Name="postCodeExt", EmitDefaultValue=false)]
        public string PostCodeExt { get; set; }
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  StreetSide: ").Append(StreetSide).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UrbanizationName: ").Append(UrbanizationName).Append("\n");
            sb.Append("  FormattedAddress: ").Append(FormattedAddress).Append("\n");
            sb.Append("  MainAddressLine: ").Append(MainAddressLine).Append("\n");
            sb.Append("  AddressLastLine: ").Append(AddressLastLine).Append("\n");
            sb.Append("  PlaceName: ").Append(PlaceName).Append("\n");
            sb.Append("  AreaName1: ").Append(AreaName1).Append("\n");
            sb.Append("  AreaName2: ").Append(AreaName2).Append("\n");
            sb.Append("  AreaName3: ").Append(AreaName3).Append("\n");
            sb.Append("  AreaName4: ").Append(AreaName4).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  PostCodeExt: ").Append(PostCodeExt).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AddressNumber: ").Append(AddressNumber).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  UnitValue: ").Append(UnitValue).Append("\n");
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
            return this.Equals(obj as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="other">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address other)
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
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.StreetSide == other.StreetSide ||
                    this.StreetSide != null &&
                    this.StreetSide.Equals(other.StreetSide)
                ) && 
                (
                    this.BusinessName == other.BusinessName ||
                    this.BusinessName != null &&
                    this.BusinessName.Equals(other.BusinessName)
                ) && 
                (
                    this.AddressLine1 == other.AddressLine1 ||
                    this.AddressLine1 != null &&
                    this.AddressLine1.Equals(other.AddressLine1)
                ) && 
                (
                    this.AddressLine2 == other.AddressLine2 ||
                    this.AddressLine2 != null &&
                    this.AddressLine2.Equals(other.AddressLine2)
                ) && 
                (
                    this.AddressLine3 == other.AddressLine3 ||
                    this.AddressLine3 != null &&
                    this.AddressLine3.Equals(other.AddressLine3)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.StateProvince == other.StateProvince ||
                    this.StateProvince != null &&
                    this.StateProvince.Equals(other.StateProvince)
                ) && 
                (
                    this.County == other.County ||
                    this.County != null &&
                    this.County.Equals(other.County)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) && 
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.UrbanizationName == other.UrbanizationName ||
                    this.UrbanizationName != null &&
                    this.UrbanizationName.Equals(other.UrbanizationName)
                ) && 
                (
                    this.FormattedAddress == other.FormattedAddress ||
                    this.FormattedAddress != null &&
                    this.FormattedAddress.Equals(other.FormattedAddress)
                ) && 
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
                    this.PostCode == other.PostCode ||
                    this.PostCode != null &&
                    this.PostCode.Equals(other.PostCode)
                ) && 
                (
                    this.PostCodeExt == other.PostCodeExt ||
                    this.PostCodeExt != null &&
                    this.PostCodeExt.Equals(other.PostCodeExt)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.StreetSide != null)
                    hash = hash * 59 + this.StreetSide.GetHashCode();
                if (this.BusinessName != null)
                    hash = hash * 59 + this.BusinessName.GetHashCode();
                if (this.AddressLine1 != null)
                    hash = hash * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hash = hash * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hash = hash * 59 + this.AddressLine3.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.StateProvince != null)
                    hash = hash * 59 + this.StateProvince.GetHashCode();
                if (this.County != null)
                    hash = hash * 59 + this.County.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.UrbanizationName != null)
                    hash = hash * 59 + this.UrbanizationName.GetHashCode();
                if (this.FormattedAddress != null)
                    hash = hash * 59 + this.FormattedAddress.GetHashCode();
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
                if (this.PostCode != null)
                    hash = hash * 59 + this.PostCode.GetHashCode();
                if (this.PostCodeExt != null)
                    hash = hash * 59 + this.PostCodeExt.GetHashCode();
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
                return hash;
            }
        }
    }

}
