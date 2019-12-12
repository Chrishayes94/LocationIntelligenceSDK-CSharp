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
    /// GeoLocationPlace
    /// </summary>
    [DataContract]
    public partial class GeoLocationPlace :  IEquatable<GeoLocationPlace>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLocationPlace" /> class.
        /// </summary>
        /// <param name="Continent">Continent.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Region">Region.</param>
        /// <param name="State">State.</param>
        /// <param name="City">City.</param>
        /// <param name="PostCode">PostCode.</param>
        public GeoLocationPlace(string Continent = null, GeoLocationCountry Country = null, string Region = null, GeoLocationState State = null, City City = null, string PostCode = null)
        {
            this.Continent = Continent;
            this.Country = Country;
            this.Region = Region;
            this.State = State;
            this.City = City;
            this.PostCode = PostCode;
        }
        
        /// <summary>
        /// Gets or Sets Continent
        /// </summary>
        [DataMember(Name="continent", EmitDefaultValue=false)]
        public string Continent { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public GeoLocationCountry Country { get; set; }
        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public GeoLocationState State { get; set; }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public City City { get; set; }
        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoLocationPlace {\n");
            sb.Append("  Continent: ").Append(Continent).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
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
            return this.Equals(obj as GeoLocationPlace);
        }

        /// <summary>
        /// Returns true if GeoLocationPlace instances are equal
        /// </summary>
        /// <param name="other">Instance of GeoLocationPlace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoLocationPlace other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Continent == other.Continent ||
                    this.Continent != null &&
                    this.Continent.Equals(other.Continent)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.PostCode == other.PostCode ||
                    this.PostCode != null &&
                    this.PostCode.Equals(other.PostCode)
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
                if (this.Continent != null)
                    hash = hash * 59 + this.Continent.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.PostCode != null)
                    hash = hash * 59 + this.PostCode.GetHashCode();
                return hash;
            }
        }
    }

}
