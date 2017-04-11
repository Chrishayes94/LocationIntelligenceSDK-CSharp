/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 3.0.0
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
    /// TravelCostMatrixResponseMatrix
    /// </summary>
    [DataContract]
    public partial class TravelCostMatrixResponseMatrix :  IEquatable<TravelCostMatrixResponseMatrix>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TravelCostMatrixResponseMatrix" /> class.
        /// </summary>
        /// <param name="Distance">Distance.</param>
        /// <param name="DistanceUnit">DistanceUnit.</param>
        /// <param name="EndPoint">EndPoint.</param>
        /// <param name="StartPoint">StartPoint.</param>
        /// <param name="Time">Time.</param>
        /// <param name="TimeUnit">TimeUnit.</param>
        public TravelCostMatrixResponseMatrix(decimal? Distance = null, string DistanceUnit = null, TravelCostMatrixResponseEndPoint EndPoint = null, TravelCostMatrixResponseEndPoint StartPoint = null, decimal? Time = null, string TimeUnit = null)
        {
            this.Distance = Distance;
            this.DistanceUnit = DistanceUnit;
            this.EndPoint = EndPoint;
            this.StartPoint = StartPoint;
            this.Time = Time;
            this.TimeUnit = TimeUnit;
        }
        
        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public decimal? Distance { get; set; }
        /// <summary>
        /// Gets or Sets DistanceUnit
        /// </summary>
        [DataMember(Name="distanceUnit", EmitDefaultValue=false)]
        public string DistanceUnit { get; set; }
        /// <summary>
        /// Gets or Sets EndPoint
        /// </summary>
        [DataMember(Name="endPoint", EmitDefaultValue=false)]
        public TravelCostMatrixResponseEndPoint EndPoint { get; set; }
        /// <summary>
        /// Gets or Sets StartPoint
        /// </summary>
        [DataMember(Name="startPoint", EmitDefaultValue=false)]
        public TravelCostMatrixResponseEndPoint StartPoint { get; set; }
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public decimal? Time { get; set; }
        /// <summary>
        /// Gets or Sets TimeUnit
        /// </summary>
        [DataMember(Name="timeUnit", EmitDefaultValue=false)]
        public string TimeUnit { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TravelCostMatrixResponseMatrix {\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  DistanceUnit: ").Append(DistanceUnit).Append("\n");
            sb.Append("  EndPoint: ").Append(EndPoint).Append("\n");
            sb.Append("  StartPoint: ").Append(StartPoint).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  TimeUnit: ").Append(TimeUnit).Append("\n");
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
            return this.Equals(obj as TravelCostMatrixResponseMatrix);
        }

        /// <summary>
        /// Returns true if TravelCostMatrixResponseMatrix instances are equal
        /// </summary>
        /// <param name="other">Instance of TravelCostMatrixResponseMatrix to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TravelCostMatrixResponseMatrix other)
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
                    this.DistanceUnit == other.DistanceUnit ||
                    this.DistanceUnit != null &&
                    this.DistanceUnit.Equals(other.DistanceUnit)
                ) && 
                (
                    this.EndPoint == other.EndPoint ||
                    this.EndPoint != null &&
                    this.EndPoint.Equals(other.EndPoint)
                ) && 
                (
                    this.StartPoint == other.StartPoint ||
                    this.StartPoint != null &&
                    this.StartPoint.Equals(other.StartPoint)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.TimeUnit == other.TimeUnit ||
                    this.TimeUnit != null &&
                    this.TimeUnit.Equals(other.TimeUnit)
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
                if (this.DistanceUnit != null)
                    hash = hash * 59 + this.DistanceUnit.GetHashCode();
                if (this.EndPoint != null)
                    hash = hash * 59 + this.EndPoint.GetHashCode();
                if (this.StartPoint != null)
                    hash = hash * 59 + this.StartPoint.GetHashCode();
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                if (this.TimeUnit != null)
                    hash = hash * 59 + this.TimeUnit.GetHashCode();
                return hash;
            }
        }
    }

}
