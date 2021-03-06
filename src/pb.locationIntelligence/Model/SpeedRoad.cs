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
    /// SpeedRoad
    /// </summary>
    [DataContract]
    public partial class SpeedRoad :  IEquatable<SpeedRoad>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedRoad" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="AltName">AltName.</param>
        /// <param name="RoadClass">RoadClass.</param>
        /// <param name="Type">Type.</param>
        /// <param name="LengthInMeters">LengthInMeters.</param>
        /// <param name="RouteNumber">RouteNumber.</param>
        /// <param name="SurfaceType">SurfaceType.</param>
        /// <param name="TrafficFlow">TrafficFlow.</param>
        /// <param name="IsToll">IsToll.</param>
        /// <param name="BeginningLevel">BeginningLevel.</param>
        /// <param name="EndingLevel">EndingLevel.</param>
        public SpeedRoad(string Id = null, string Name = null, string AltName = null, string RoadClass = null, string Type = null, string LengthInMeters = null, string RouteNumber = null, string SurfaceType = null, string TrafficFlow = null, string IsToll = null, string BeginningLevel = null, string EndingLevel = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.AltName = AltName;
            this.RoadClass = RoadClass;
            this.Type = Type;
            this.LengthInMeters = LengthInMeters;
            this.RouteNumber = RouteNumber;
            this.SurfaceType = SurfaceType;
            this.TrafficFlow = TrafficFlow;
            this.IsToll = IsToll;
            this.BeginningLevel = BeginningLevel;
            this.EndingLevel = EndingLevel;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets AltName
        /// </summary>
        [DataMember(Name="altName", EmitDefaultValue=false)]
        public string AltName { get; set; }
        /// <summary>
        /// Gets or Sets RoadClass
        /// </summary>
        [DataMember(Name="roadClass", EmitDefaultValue=false)]
        public string RoadClass { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets LengthInMeters
        /// </summary>
        [DataMember(Name="lengthInMeters", EmitDefaultValue=false)]
        public string LengthInMeters { get; set; }
        /// <summary>
        /// Gets or Sets RouteNumber
        /// </summary>
        [DataMember(Name="routeNumber", EmitDefaultValue=false)]
        public string RouteNumber { get; set; }
        /// <summary>
        /// Gets or Sets SurfaceType
        /// </summary>
        [DataMember(Name="surfaceType", EmitDefaultValue=false)]
        public string SurfaceType { get; set; }
        /// <summary>
        /// Gets or Sets TrafficFlow
        /// </summary>
        [DataMember(Name="trafficFlow", EmitDefaultValue=false)]
        public string TrafficFlow { get; set; }
        /// <summary>
        /// Gets or Sets IsToll
        /// </summary>
        [DataMember(Name="isToll", EmitDefaultValue=false)]
        public string IsToll { get; set; }
        /// <summary>
        /// Gets or Sets BeginningLevel
        /// </summary>
        [DataMember(Name="beginningLevel", EmitDefaultValue=false)]
        public string BeginningLevel { get; set; }
        /// <summary>
        /// Gets or Sets EndingLevel
        /// </summary>
        [DataMember(Name="endingLevel", EmitDefaultValue=false)]
        public string EndingLevel { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpeedRoad {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AltName: ").Append(AltName).Append("\n");
            sb.Append("  RoadClass: ").Append(RoadClass).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LengthInMeters: ").Append(LengthInMeters).Append("\n");
            sb.Append("  RouteNumber: ").Append(RouteNumber).Append("\n");
            sb.Append("  SurfaceType: ").Append(SurfaceType).Append("\n");
            sb.Append("  TrafficFlow: ").Append(TrafficFlow).Append("\n");
            sb.Append("  IsToll: ").Append(IsToll).Append("\n");
            sb.Append("  BeginningLevel: ").Append(BeginningLevel).Append("\n");
            sb.Append("  EndingLevel: ").Append(EndingLevel).Append("\n");
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
            return this.Equals(obj as SpeedRoad);
        }

        /// <summary>
        /// Returns true if SpeedRoad instances are equal
        /// </summary>
        /// <param name="other">Instance of SpeedRoad to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpeedRoad other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AltName == other.AltName ||
                    this.AltName != null &&
                    this.AltName.Equals(other.AltName)
                ) && 
                (
                    this.RoadClass == other.RoadClass ||
                    this.RoadClass != null &&
                    this.RoadClass.Equals(other.RoadClass)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.LengthInMeters == other.LengthInMeters ||
                    this.LengthInMeters != null &&
                    this.LengthInMeters.Equals(other.LengthInMeters)
                ) && 
                (
                    this.RouteNumber == other.RouteNumber ||
                    this.RouteNumber != null &&
                    this.RouteNumber.Equals(other.RouteNumber)
                ) && 
                (
                    this.SurfaceType == other.SurfaceType ||
                    this.SurfaceType != null &&
                    this.SurfaceType.Equals(other.SurfaceType)
                ) && 
                (
                    this.TrafficFlow == other.TrafficFlow ||
                    this.TrafficFlow != null &&
                    this.TrafficFlow.Equals(other.TrafficFlow)
                ) && 
                (
                    this.IsToll == other.IsToll ||
                    this.IsToll != null &&
                    this.IsToll.Equals(other.IsToll)
                ) && 
                (
                    this.BeginningLevel == other.BeginningLevel ||
                    this.BeginningLevel != null &&
                    this.BeginningLevel.Equals(other.BeginningLevel)
                ) && 
                (
                    this.EndingLevel == other.EndingLevel ||
                    this.EndingLevel != null &&
                    this.EndingLevel.Equals(other.EndingLevel)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.AltName != null)
                    hash = hash * 59 + this.AltName.GetHashCode();
                if (this.RoadClass != null)
                    hash = hash * 59 + this.RoadClass.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.LengthInMeters != null)
                    hash = hash * 59 + this.LengthInMeters.GetHashCode();
                if (this.RouteNumber != null)
                    hash = hash * 59 + this.RouteNumber.GetHashCode();
                if (this.SurfaceType != null)
                    hash = hash * 59 + this.SurfaceType.GetHashCode();
                if (this.TrafficFlow != null)
                    hash = hash * 59 + this.TrafficFlow.GetHashCode();
                if (this.IsToll != null)
                    hash = hash * 59 + this.IsToll.GetHashCode();
                if (this.BeginningLevel != null)
                    hash = hash * 59 + this.BeginningLevel.GetHashCode();
                if (this.EndingLevel != null)
                    hash = hash * 59 + this.EndingLevel.GetHashCode();
                return hash;
            }
        }
    }

}
