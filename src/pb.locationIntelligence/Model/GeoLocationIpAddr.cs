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
    /// GeoLocationIpAddr
    /// </summary>
    [DataContract]
    public partial class GeoLocationIpAddr :  IEquatable<GeoLocationIpAddr>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLocationIpAddr" /> class.
        /// </summary>
        /// <param name="Geometry">Geometry.</param>
        /// <param name="IpInfo">IpInfo.</param>
        public GeoLocationIpAddr(Geometry Geometry = null, IpInfo IpInfo = null)
        {
            this.Geometry = Geometry;
            this.IpInfo = IpInfo;
        }
        
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }
        /// <summary>
        /// Gets or Sets IpInfo
        /// </summary>
        [DataMember(Name="ipInfo", EmitDefaultValue=false)]
        public IpInfo IpInfo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoLocationIpAddr {\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  IpInfo: ").Append(IpInfo).Append("\n");
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
            return this.Equals(obj as GeoLocationIpAddr);
        }

        /// <summary>
        /// Returns true if GeoLocationIpAddr instances are equal
        /// </summary>
        /// <param name="other">Instance of GeoLocationIpAddr to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoLocationIpAddr other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
                ) && 
                (
                    this.IpInfo == other.IpInfo ||
                    this.IpInfo != null &&
                    this.IpInfo.Equals(other.IpInfo)
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
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                if (this.IpInfo != null)
                    hash = hash * 59 + this.IpInfo.GetHashCode();
                return hash;
            }
        }
    }

}
