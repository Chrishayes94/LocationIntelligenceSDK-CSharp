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
    /// Risk
    /// </summary>
    [DataContract]
    public partial class Risk :  IEquatable<Risk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Risk" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Risk50Rating">Risk50Rating.</param>
        /// <param name="Frequency">Frequency.</param>
        /// <param name="Nonburn">Nonburn.</param>
        /// <param name="PastFires">PastFires.</param>
        /// <param name="Severity">Severity.</param>
        /// <param name="Continuity">Continuity.</param>
        /// <param name="Adjustment">Adjustment.</param>
        /// <param name="Aspect">Aspect.</param>
        /// <param name="CrownFire">CrownFire.</param>
        /// <param name="Vegetation">Vegetation.</param>
        /// <param name="Foehn">Foehn.</param>
        /// <param name="GolfCourse">GolfCourse.</param>
        /// <param name="RoadDist">RoadDist.</param>
        /// <param name="Slope">Slope.</param>
        /// <param name="WaterDist">WaterDist.</param>
        /// <param name="Tier">Tier.</param>
        /// <param name="TierDescription">TierDescription.</param>
        /// <param name="DistanceToFireStation">DistanceToFireStation.</param>
        public Risk(string Type = null, string Description = null, int? Risk50Rating = null, int? Frequency = null, string Nonburn = null, int? PastFires = null, int? Severity = null, string Continuity = null, string Adjustment = null, string Aspect = null, string CrownFire = null, string Vegetation = null, string Foehn = null, string GolfCourse = null, string RoadDist = null, string Slope = null, string WaterDist = null, string Tier = null, string TierDescription = null, int? DistanceToFireStation = null)
        {
            this.Type = Type;
            this.Description = Description;
            this.Risk50Rating = Risk50Rating;
            this.Frequency = Frequency;
            this.Nonburn = Nonburn;
            this.PastFires = PastFires;
            this.Severity = Severity;
            this.Continuity = Continuity;
            this.Adjustment = Adjustment;
            this.Aspect = Aspect;
            this.CrownFire = CrownFire;
            this.Vegetation = Vegetation;
            this.Foehn = Foehn;
            this.GolfCourse = GolfCourse;
            this.RoadDist = RoadDist;
            this.Slope = Slope;
            this.WaterDist = WaterDist;
            this.Tier = Tier;
            this.TierDescription = TierDescription;
            this.DistanceToFireStation = DistanceToFireStation;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Risk50Rating
        /// </summary>
        [DataMember(Name="risk50Rating", EmitDefaultValue=false)]
        public int? Risk50Rating { get; set; }
        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public int? Frequency { get; set; }
        /// <summary>
        /// Gets or Sets Nonburn
        /// </summary>
        [DataMember(Name="nonburn", EmitDefaultValue=false)]
        public string Nonburn { get; set; }
        /// <summary>
        /// Gets or Sets PastFires
        /// </summary>
        [DataMember(Name="pastFires", EmitDefaultValue=false)]
        public int? PastFires { get; set; }
        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public int? Severity { get; set; }
        /// <summary>
        /// Gets or Sets Continuity
        /// </summary>
        [DataMember(Name="continuity", EmitDefaultValue=false)]
        public string Continuity { get; set; }
        /// <summary>
        /// Gets or Sets Adjustment
        /// </summary>
        [DataMember(Name="adjustment", EmitDefaultValue=false)]
        public string Adjustment { get; set; }
        /// <summary>
        /// Gets or Sets Aspect
        /// </summary>
        [DataMember(Name="aspect", EmitDefaultValue=false)]
        public string Aspect { get; set; }
        /// <summary>
        /// Gets or Sets CrownFire
        /// </summary>
        [DataMember(Name="crownFire", EmitDefaultValue=false)]
        public string CrownFire { get; set; }
        /// <summary>
        /// Gets or Sets Vegetation
        /// </summary>
        [DataMember(Name="vegetation", EmitDefaultValue=false)]
        public string Vegetation { get; set; }
        /// <summary>
        /// Gets or Sets Foehn
        /// </summary>
        [DataMember(Name="foehn", EmitDefaultValue=false)]
        public string Foehn { get; set; }
        /// <summary>
        /// Gets or Sets GolfCourse
        /// </summary>
        [DataMember(Name="golfCourse", EmitDefaultValue=false)]
        public string GolfCourse { get; set; }
        /// <summary>
        /// Gets or Sets RoadDist
        /// </summary>
        [DataMember(Name="roadDist", EmitDefaultValue=false)]
        public string RoadDist { get; set; }
        /// <summary>
        /// Gets or Sets Slope
        /// </summary>
        [DataMember(Name="slope", EmitDefaultValue=false)]
        public string Slope { get; set; }
        /// <summary>
        /// Gets or Sets WaterDist
        /// </summary>
        [DataMember(Name="waterDist", EmitDefaultValue=false)]
        public string WaterDist { get; set; }
        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public string Tier { get; set; }
        /// <summary>
        /// Gets or Sets TierDescription
        /// </summary>
        [DataMember(Name="tierDescription", EmitDefaultValue=false)]
        public string TierDescription { get; set; }
        /// <summary>
        /// Gets or Sets DistanceToFireStation
        /// </summary>
        [DataMember(Name="distanceToFireStation", EmitDefaultValue=false)]
        public int? DistanceToFireStation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Risk {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Risk50Rating: ").Append(Risk50Rating).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Nonburn: ").Append(Nonburn).Append("\n");
            sb.Append("  PastFires: ").Append(PastFires).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Continuity: ").Append(Continuity).Append("\n");
            sb.Append("  Adjustment: ").Append(Adjustment).Append("\n");
            sb.Append("  Aspect: ").Append(Aspect).Append("\n");
            sb.Append("  CrownFire: ").Append(CrownFire).Append("\n");
            sb.Append("  Vegetation: ").Append(Vegetation).Append("\n");
            sb.Append("  Foehn: ").Append(Foehn).Append("\n");
            sb.Append("  GolfCourse: ").Append(GolfCourse).Append("\n");
            sb.Append("  RoadDist: ").Append(RoadDist).Append("\n");
            sb.Append("  Slope: ").Append(Slope).Append("\n");
            sb.Append("  WaterDist: ").Append(WaterDist).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  TierDescription: ").Append(TierDescription).Append("\n");
            sb.Append("  DistanceToFireStation: ").Append(DistanceToFireStation).Append("\n");
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
            return this.Equals(obj as Risk);
        }

        /// <summary>
        /// Returns true if Risk instances are equal
        /// </summary>
        /// <param name="other">Instance of Risk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Risk other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Risk50Rating == other.Risk50Rating ||
                    this.Risk50Rating != null &&
                    this.Risk50Rating.Equals(other.Risk50Rating)
                ) && 
                (
                    this.Frequency == other.Frequency ||
                    this.Frequency != null &&
                    this.Frequency.Equals(other.Frequency)
                ) && 
                (
                    this.Nonburn == other.Nonburn ||
                    this.Nonburn != null &&
                    this.Nonburn.Equals(other.Nonburn)
                ) && 
                (
                    this.PastFires == other.PastFires ||
                    this.PastFires != null &&
                    this.PastFires.Equals(other.PastFires)
                ) && 
                (
                    this.Severity == other.Severity ||
                    this.Severity != null &&
                    this.Severity.Equals(other.Severity)
                ) && 
                (
                    this.Continuity == other.Continuity ||
                    this.Continuity != null &&
                    this.Continuity.Equals(other.Continuity)
                ) && 
                (
                    this.Adjustment == other.Adjustment ||
                    this.Adjustment != null &&
                    this.Adjustment.Equals(other.Adjustment)
                ) && 
                (
                    this.Aspect == other.Aspect ||
                    this.Aspect != null &&
                    this.Aspect.Equals(other.Aspect)
                ) && 
                (
                    this.CrownFire == other.CrownFire ||
                    this.CrownFire != null &&
                    this.CrownFire.Equals(other.CrownFire)
                ) && 
                (
                    this.Vegetation == other.Vegetation ||
                    this.Vegetation != null &&
                    this.Vegetation.Equals(other.Vegetation)
                ) && 
                (
                    this.Foehn == other.Foehn ||
                    this.Foehn != null &&
                    this.Foehn.Equals(other.Foehn)
                ) && 
                (
                    this.GolfCourse == other.GolfCourse ||
                    this.GolfCourse != null &&
                    this.GolfCourse.Equals(other.GolfCourse)
                ) && 
                (
                    this.RoadDist == other.RoadDist ||
                    this.RoadDist != null &&
                    this.RoadDist.Equals(other.RoadDist)
                ) && 
                (
                    this.Slope == other.Slope ||
                    this.Slope != null &&
                    this.Slope.Equals(other.Slope)
                ) && 
                (
                    this.WaterDist == other.WaterDist ||
                    this.WaterDist != null &&
                    this.WaterDist.Equals(other.WaterDist)
                ) && 
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
                ) && 
                (
                    this.TierDescription == other.TierDescription ||
                    this.TierDescription != null &&
                    this.TierDescription.Equals(other.TierDescription)
                ) && 
                (
                    this.DistanceToFireStation == other.DistanceToFireStation ||
                    this.DistanceToFireStation != null &&
                    this.DistanceToFireStation.Equals(other.DistanceToFireStation)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Risk50Rating != null)
                    hash = hash * 59 + this.Risk50Rating.GetHashCode();
                if (this.Frequency != null)
                    hash = hash * 59 + this.Frequency.GetHashCode();
                if (this.Nonburn != null)
                    hash = hash * 59 + this.Nonburn.GetHashCode();
                if (this.PastFires != null)
                    hash = hash * 59 + this.PastFires.GetHashCode();
                if (this.Severity != null)
                    hash = hash * 59 + this.Severity.GetHashCode();
                if (this.Continuity != null)
                    hash = hash * 59 + this.Continuity.GetHashCode();
                if (this.Adjustment != null)
                    hash = hash * 59 + this.Adjustment.GetHashCode();
                if (this.Aspect != null)
                    hash = hash * 59 + this.Aspect.GetHashCode();
                if (this.CrownFire != null)
                    hash = hash * 59 + this.CrownFire.GetHashCode();
                if (this.Vegetation != null)
                    hash = hash * 59 + this.Vegetation.GetHashCode();
                if (this.Foehn != null)
                    hash = hash * 59 + this.Foehn.GetHashCode();
                if (this.GolfCourse != null)
                    hash = hash * 59 + this.GolfCourse.GetHashCode();
                if (this.RoadDist != null)
                    hash = hash * 59 + this.RoadDist.GetHashCode();
                if (this.Slope != null)
                    hash = hash * 59 + this.Slope.GetHashCode();
                if (this.WaterDist != null)
                    hash = hash * 59 + this.WaterDist.GetHashCode();
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();
                if (this.TierDescription != null)
                    hash = hash * 59 + this.TierDescription.GetHashCode();
                if (this.DistanceToFireStation != null)
                    hash = hash * 59 + this.DistanceToFireStation.GetHashCode();
                return hash;
            }
        }
    }

}
