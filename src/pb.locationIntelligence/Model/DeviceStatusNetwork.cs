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
    /// DeviceStatusNetwork
    /// </summary>
    [DataContract]
    public partial class DeviceStatusNetwork :  IEquatable<DeviceStatusNetwork>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceStatusNetwork" /> class.
        /// </summary>
        /// <param name="Carrier">Carrier.</param>
        /// <param name="CallType">CallType.</param>
        /// <param name="LocAccuracySupport">LocAccuracySupport.</param>
        /// <param name="NationalNumber">NationalNumber.</param>
        /// <param name="Country">Country.</param>
        public DeviceStatusNetwork(string Carrier = null, string CallType = null, string LocAccuracySupport = null, string NationalNumber = null, GeoLocationFixedLineCountry Country = null)
        {
            this.Carrier = Carrier;
            this.CallType = CallType;
            this.LocAccuracySupport = LocAccuracySupport;
            this.NationalNumber = NationalNumber;
            this.Country = Country;
        }
        
        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }
        /// <summary>
        /// Gets or Sets CallType
        /// </summary>
        [DataMember(Name="callType", EmitDefaultValue=false)]
        public string CallType { get; set; }
        /// <summary>
        /// Gets or Sets LocAccuracySupport
        /// </summary>
        [DataMember(Name="locAccuracySupport", EmitDefaultValue=false)]
        public string LocAccuracySupport { get; set; }
        /// <summary>
        /// Gets or Sets NationalNumber
        /// </summary>
        [DataMember(Name="nationalNumber", EmitDefaultValue=false)]
        public string NationalNumber { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public GeoLocationFixedLineCountry Country { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceStatusNetwork {\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  CallType: ").Append(CallType).Append("\n");
            sb.Append("  LocAccuracySupport: ").Append(LocAccuracySupport).Append("\n");
            sb.Append("  NationalNumber: ").Append(NationalNumber).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(obj as DeviceStatusNetwork);
        }

        /// <summary>
        /// Returns true if DeviceStatusNetwork instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceStatusNetwork to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceStatusNetwork other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Carrier == other.Carrier ||
                    this.Carrier != null &&
                    this.Carrier.Equals(other.Carrier)
                ) && 
                (
                    this.CallType == other.CallType ||
                    this.CallType != null &&
                    this.CallType.Equals(other.CallType)
                ) && 
                (
                    this.LocAccuracySupport == other.LocAccuracySupport ||
                    this.LocAccuracySupport != null &&
                    this.LocAccuracySupport.Equals(other.LocAccuracySupport)
                ) && 
                (
                    this.NationalNumber == other.NationalNumber ||
                    this.NationalNumber != null &&
                    this.NationalNumber.Equals(other.NationalNumber)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();
                if (this.CallType != null)
                    hash = hash * 59 + this.CallType.GetHashCode();
                if (this.LocAccuracySupport != null)
                    hash = hash * 59 + this.LocAccuracySupport.GetHashCode();
                if (this.NationalNumber != null)
                    hash = hash * 59 + this.NationalNumber.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                return hash;
            }
        }
    }

}
