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
    /// TaxAddress
    /// </summary>
    [DataContract]
    public partial class TaxAddress :  IEquatable<TaxAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxAddress" /> class.
        /// </summary>
        /// <param name="ObjectId">ObjectId.</param>
        /// <param name="MainAddressLine">MainAddressLine.</param>
        /// <param name="PlaceName">PlaceName.</param>
        /// <param name="AreaName1">AreaName1.</param>
        /// <param name="AreaName3">AreaName3.</param>
        /// <param name="PostCode1">PostCode1.</param>
        /// <param name="Country">Country.</param>
        /// <param name="PurchaseAmount">PurchaseAmount.</param>
        public TaxAddress(string ObjectId = null, string MainAddressLine = null, string PlaceName = null, string AreaName1 = null, string AreaName3 = null, string PostCode1 = null, string Country = null, string PurchaseAmount = null)
        {
            this.ObjectId = ObjectId;
            this.MainAddressLine = MainAddressLine;
            this.PlaceName = PlaceName;
            this.AreaName1 = AreaName1;
            this.AreaName3 = AreaName3;
            this.PostCode1 = PostCode1;
            this.Country = Country;
            this.PurchaseAmount = PurchaseAmount;
        }
        
        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// Gets or Sets MainAddressLine
        /// </summary>
        [DataMember(Name="mainAddressLine", EmitDefaultValue=false)]
        public string MainAddressLine { get; set; }
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
        /// Gets or Sets AreaName3
        /// </summary>
        [DataMember(Name="areaName3", EmitDefaultValue=false)]
        public string AreaName3 { get; set; }
        /// <summary>
        /// Gets or Sets PostCode1
        /// </summary>
        [DataMember(Name="postCode1", EmitDefaultValue=false)]
        public string PostCode1 { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Gets or Sets PurchaseAmount
        /// </summary>
        [DataMember(Name="purchaseAmount", EmitDefaultValue=false)]
        public string PurchaseAmount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxAddress {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  MainAddressLine: ").Append(MainAddressLine).Append("\n");
            sb.Append("  PlaceName: ").Append(PlaceName).Append("\n");
            sb.Append("  AreaName1: ").Append(AreaName1).Append("\n");
            sb.Append("  AreaName3: ").Append(AreaName3).Append("\n");
            sb.Append("  PostCode1: ").Append(PostCode1).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PurchaseAmount: ").Append(PurchaseAmount).Append("\n");
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
            return this.Equals(obj as TaxAddress);
        }

        /// <summary>
        /// Returns true if TaxAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxAddress other)
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
                    this.MainAddressLine == other.MainAddressLine ||
                    this.MainAddressLine != null &&
                    this.MainAddressLine.Equals(other.MainAddressLine)
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
                    this.AreaName3 == other.AreaName3 ||
                    this.AreaName3 != null &&
                    this.AreaName3.Equals(other.AreaName3)
                ) && 
                (
                    this.PostCode1 == other.PostCode1 ||
                    this.PostCode1 != null &&
                    this.PostCode1.Equals(other.PostCode1)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.PurchaseAmount == other.PurchaseAmount ||
                    this.PurchaseAmount != null &&
                    this.PurchaseAmount.Equals(other.PurchaseAmount)
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
                if (this.MainAddressLine != null)
                    hash = hash * 59 + this.MainAddressLine.GetHashCode();
                if (this.PlaceName != null)
                    hash = hash * 59 + this.PlaceName.GetHashCode();
                if (this.AreaName1 != null)
                    hash = hash * 59 + this.AreaName1.GetHashCode();
                if (this.AreaName3 != null)
                    hash = hash * 59 + this.AreaName3.GetHashCode();
                if (this.PostCode1 != null)
                    hash = hash * 59 + this.PostCode1.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.PurchaseAmount != null)
                    hash = hash * 59 + this.PurchaseAmount.GetHashCode();
                return hash;
            }
        }
    }

}
