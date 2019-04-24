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
    /// SpecialPurposeDistrictTax
    /// </summary>
    [DataContract]
    public partial class SpecialPurposeDistrictTax :  IEquatable<SpecialPurposeDistrictTax>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialPurposeDistrictTax" /> class.
        /// </summary>
        /// <param name="DistrictNumber">DistrictNumber.</param>
        /// <param name="TaxRate">TaxRate.</param>
        /// <param name="TaxAmount">TaxAmount.</param>
        public SpecialPurposeDistrictTax(string DistrictNumber = null, double? TaxRate = null, double? TaxAmount = null)
        {
            this.DistrictNumber = DistrictNumber;
            this.TaxRate = TaxRate;
            this.TaxAmount = TaxAmount;
        }
        
        /// <summary>
        /// Gets or Sets DistrictNumber
        /// </summary>
        [DataMember(Name="districtNumber", EmitDefaultValue=false)]
        public string DistrictNumber { get; set; }
        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name="taxRate", EmitDefaultValue=false)]
        public double? TaxRate { get; set; }
        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public double? TaxAmount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecialPurposeDistrictTax {\n");
            sb.Append("  DistrictNumber: ").Append(DistrictNumber).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
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
            return this.Equals(obj as SpecialPurposeDistrictTax);
        }

        /// <summary>
        /// Returns true if SpecialPurposeDistrictTax instances are equal
        /// </summary>
        /// <param name="other">Instance of SpecialPurposeDistrictTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpecialPurposeDistrictTax other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DistrictNumber == other.DistrictNumber ||
                    this.DistrictNumber != null &&
                    this.DistrictNumber.Equals(other.DistrictNumber)
                ) && 
                (
                    this.TaxRate == other.TaxRate ||
                    this.TaxRate != null &&
                    this.TaxRate.Equals(other.TaxRate)
                ) && 
                (
                    this.TaxAmount == other.TaxAmount ||
                    this.TaxAmount != null &&
                    this.TaxAmount.Equals(other.TaxAmount)
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
                if (this.DistrictNumber != null)
                    hash = hash * 59 + this.DistrictNumber.GetHashCode();
                if (this.TaxRate != null)
                    hash = hash * 59 + this.TaxRate.GetHashCode();
                if (this.TaxAmount != null)
                    hash = hash * 59 + this.TaxAmount.GetHashCode();
                return hash;
            }
        }
    }

}
