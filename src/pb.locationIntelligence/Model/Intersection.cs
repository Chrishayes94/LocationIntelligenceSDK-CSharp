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
    /// Intersection
    /// </summary>
    [DataContract]
    public partial class Intersection :  IEquatable<Intersection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Intersection" /> class.
        /// </summary>
        /// <param name="Distance">Distance.</param>
        /// <param name="DriveTime">DriveTime.</param>
        /// <param name="DriveDistance">DriveDistance.</param>
        /// <param name="Geometry">Geometry.</param>
        /// <param name="Roads">Roads.</param>
        public Intersection(Unit Distance = null, Unit DriveTime = null, Unit DriveDistance = null, CommonGeometry Geometry = null, List<Road> Roads = null)
        {
            this.Distance = Distance;
            this.DriveTime = DriveTime;
            this.DriveDistance = DriveDistance;
            this.Geometry = Geometry;
            this.Roads = Roads;
        }
        
        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public Unit Distance { get; set; }
        /// <summary>
        /// Gets or Sets DriveTime
        /// </summary>
        [DataMember(Name="driveTime", EmitDefaultValue=false)]
        public Unit DriveTime { get; set; }
        /// <summary>
        /// Gets or Sets DriveDistance
        /// </summary>
        [DataMember(Name="driveDistance", EmitDefaultValue=false)]
        public Unit DriveDistance { get; set; }
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public CommonGeometry Geometry { get; set; }
        /// <summary>
        /// Gets or Sets Roads
        /// </summary>
        [DataMember(Name="roads", EmitDefaultValue=false)]
        public List<Road> Roads { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Intersection {\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  DriveTime: ").Append(DriveTime).Append("\n");
            sb.Append("  DriveDistance: ").Append(DriveDistance).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  Roads: ").Append(Roads).Append("\n");
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
            return this.Equals(obj as Intersection);
        }

        /// <summary>
        /// Returns true if Intersection instances are equal
        /// </summary>
        /// <param name="other">Instance of Intersection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Intersection other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.DriveTime == other.DriveTime ||
                    this.DriveTime != null &&
                    this.DriveTime.Equals(other.DriveTime)
                ) && 
                (
                    this.DriveDistance == other.DriveDistance ||
                    this.DriveDistance != null &&
                    this.DriveDistance.Equals(other.DriveDistance)
                ) && 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
                ) && 
                (
                    this.Roads == other.Roads ||
                    this.Roads != null &&
                    this.Roads.SequenceEqual(other.Roads)
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
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.DriveTime != null)
                    hash = hash * 59 + this.DriveTime.GetHashCode();
                if (this.DriveDistance != null)
                    hash = hash * 59 + this.DriveDistance.GetHashCode();
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                if (this.Roads != null)
                    hash = hash * 59 + this.Roads.GetHashCode();
                return hash;
            }
        }
    }

}
