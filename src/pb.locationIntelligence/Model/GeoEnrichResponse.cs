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
    /// GeoEnrichResponse
    /// </summary>
    [DataContract]
    public partial class GeoEnrichResponse :  IEquatable<GeoEnrichResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoEnrichResponse" /> class.
        /// </summary>
        /// <param name="Page">Page.</param>
        /// <param name="Candidates">Candidates.</param>
        /// <param name="TotalMatchingCandidates">TotalMatchingCandidates.</param>
        /// <param name="Poi">Poi.</param>
        /// <param name="MatchedAddress">MatchedAddress.</param>
        public GeoEnrichResponse(string Page = null, string Candidates = null, string TotalMatchingCandidates = null, List<POIPlaces> Poi = null, MatchedAddress MatchedAddress = null)
        {
            this.Page = Page;
            this.Candidates = Candidates;
            this.TotalMatchingCandidates = TotalMatchingCandidates;
            this.Poi = Poi;
            this.MatchedAddress = MatchedAddress;
        }
        
        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public string Page { get; set; }
        /// <summary>
        /// Gets or Sets Candidates
        /// </summary>
        [DataMember(Name="candidates", EmitDefaultValue=false)]
        public string Candidates { get; set; }
        /// <summary>
        /// Gets or Sets TotalMatchingCandidates
        /// </summary>
        [DataMember(Name="totalMatchingCandidates", EmitDefaultValue=false)]
        public string TotalMatchingCandidates { get; set; }
        /// <summary>
        /// Gets or Sets Poi
        /// </summary>
        [DataMember(Name="poi", EmitDefaultValue=false)]
        public List<POIPlaces> Poi { get; set; }
        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public MatchedAddress MatchedAddress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoEnrichResponse {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Candidates: ").Append(Candidates).Append("\n");
            sb.Append("  TotalMatchingCandidates: ").Append(TotalMatchingCandidates).Append("\n");
            sb.Append("  Poi: ").Append(Poi).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
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
            return this.Equals(obj as GeoEnrichResponse);
        }

        /// <summary>
        /// Returns true if GeoEnrichResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GeoEnrichResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoEnrichResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.Candidates == other.Candidates ||
                    this.Candidates != null &&
                    this.Candidates.Equals(other.Candidates)
                ) && 
                (
                    this.TotalMatchingCandidates == other.TotalMatchingCandidates ||
                    this.TotalMatchingCandidates != null &&
                    this.TotalMatchingCandidates.Equals(other.TotalMatchingCandidates)
                ) && 
                (
                    this.Poi == other.Poi ||
                    this.Poi != null &&
                    this.Poi.SequenceEqual(other.Poi)
                ) && 
                (
                    this.MatchedAddress == other.MatchedAddress ||
                    this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(other.MatchedAddress)
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
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.Candidates != null)
                    hash = hash * 59 + this.Candidates.GetHashCode();
                if (this.TotalMatchingCandidates != null)
                    hash = hash * 59 + this.TotalMatchingCandidates.GetHashCode();
                if (this.Poi != null)
                    hash = hash * 59 + this.Poi.GetHashCode();
                if (this.MatchedAddress != null)
                    hash = hash * 59 + this.MatchedAddress.GetHashCode();
                return hash;
            }
        }
    }

}
