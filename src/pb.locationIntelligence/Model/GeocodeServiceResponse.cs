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
    /// GeocodeServiceResponse
    /// </summary>
    [DataContract]
    public partial class GeocodeServiceResponse :  IEquatable<GeocodeServiceResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodeServiceResponse" /> class.
        /// </summary>
        /// <param name="ObjectId">ObjectId.</param>
        /// <param name="TotalPossibleCandidates">TotalPossibleCandidates.</param>
        /// <param name="TotalMatches">TotalMatches.</param>
        /// <param name="Candidates">Candidates.</param>
        public GeocodeServiceResponse(string ObjectId = null, int? TotalPossibleCandidates = null, int? TotalMatches = null, List<Candidate> Candidates = null)
        {
            this.ObjectId = ObjectId;
            this.TotalPossibleCandidates = TotalPossibleCandidates;
            this.TotalMatches = TotalMatches;
            this.Candidates = Candidates;
        }
        
        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// Gets or Sets TotalPossibleCandidates
        /// </summary>
        [DataMember(Name="totalPossibleCandidates", EmitDefaultValue=false)]
        public int? TotalPossibleCandidates { get; set; }
        /// <summary>
        /// Gets or Sets TotalMatches
        /// </summary>
        [DataMember(Name="totalMatches", EmitDefaultValue=false)]
        public int? TotalMatches { get; set; }
        /// <summary>
        /// Gets or Sets Candidates
        /// </summary>
        [DataMember(Name="candidates", EmitDefaultValue=false)]
        public List<Candidate> Candidates { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeocodeServiceResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  TotalPossibleCandidates: ").Append(TotalPossibleCandidates).Append("\n");
            sb.Append("  TotalMatches: ").Append(TotalMatches).Append("\n");
            sb.Append("  Candidates: ").Append(Candidates).Append("\n");
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
            return this.Equals(obj as GeocodeServiceResponse);
        }

        /// <summary>
        /// Returns true if GeocodeServiceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GeocodeServiceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeocodeServiceResponse other)
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
                    this.TotalPossibleCandidates == other.TotalPossibleCandidates ||
                    this.TotalPossibleCandidates != null &&
                    this.TotalPossibleCandidates.Equals(other.TotalPossibleCandidates)
                ) && 
                (
                    this.TotalMatches == other.TotalMatches ||
                    this.TotalMatches != null &&
                    this.TotalMatches.Equals(other.TotalMatches)
                ) && 
                (
                    this.Candidates == other.Candidates ||
                    this.Candidates != null &&
                    this.Candidates.SequenceEqual(other.Candidates)
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
                if (this.TotalPossibleCandidates != null)
                    hash = hash * 59 + this.TotalPossibleCandidates.GetHashCode();
                if (this.TotalMatches != null)
                    hash = hash * 59 + this.TotalMatches.GetHashCode();
                if (this.Candidates != null)
                    hash = hash * 59 + this.Candidates.GetHashCode();
                return hash;
            }
        }
    }

}
