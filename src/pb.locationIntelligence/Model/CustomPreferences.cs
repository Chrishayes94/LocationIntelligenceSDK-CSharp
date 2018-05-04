/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 4.6.0
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
    /// CustomPreferences
    /// </summary>
    [DataContract]
    public partial class CustomPreferences :  IEquatable<CustomPreferences>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPreferences" /> class.
        /// </summary>
        /// <param name="FIND_ADDR_POINT_INTERP">FIND_ADDR_POINT_INTERP (default to false).</param>
        /// <param name="FIND_SEARCH_AREA">FIND_SEARCH_AREA (default to &quot;1&quot;).</param>
        /// <param name="FIND_ADDRESS_RANGE">FIND_ADDRESS_RANGE (default to false).</param>
        /// <param name="FIND_EXPANDED_SEARCH_RADIUS">FIND_EXPANDED_SEARCH_RADIUS (default to &quot;25&quot;).</param>
        /// <param name="FIND_ALTERNATE_LOOKUP">FIND_ALTERNATE_LOOKUP (default to &quot;3&quot;).</param>
        /// <param name="FIND_STREET_CENTROID">FIND_STREET_CENTROID (default to false).</param>
        /// <param name="FIND_FIRST_LETTER_EXPANDED">FIND_FIRST_LETTER_EXPANDED (default to false).</param>
        public CustomPreferences(bool? FIND_ADDR_POINT_INTERP = null, string FIND_SEARCH_AREA = null, bool? FIND_ADDRESS_RANGE = null, string FIND_EXPANDED_SEARCH_RADIUS = null, string FIND_ALTERNATE_LOOKUP = null, bool? FIND_STREET_CENTROID = null, bool? FIND_FIRST_LETTER_EXPANDED = null)
        {
            // use default value if no "FIND_ADDR_POINT_INTERP" provided
            if (FIND_ADDR_POINT_INTERP == null)
            {
                this.FIND_ADDR_POINT_INTERP = false;
            }
            else
            {
                this.FIND_ADDR_POINT_INTERP = FIND_ADDR_POINT_INTERP;
            }
            // use default value if no "FIND_SEARCH_AREA" provided
            if (FIND_SEARCH_AREA == null)
            {
                this.FIND_SEARCH_AREA = "1";
            }
            else
            {
                this.FIND_SEARCH_AREA = FIND_SEARCH_AREA;
            }
            // use default value if no "FIND_ADDRESS_RANGE" provided
            if (FIND_ADDRESS_RANGE == null)
            {
                this.FIND_ADDRESS_RANGE = false;
            }
            else
            {
                this.FIND_ADDRESS_RANGE = FIND_ADDRESS_RANGE;
            }
            // use default value if no "FIND_EXPANDED_SEARCH_RADIUS" provided
            if (FIND_EXPANDED_SEARCH_RADIUS == null)
            {
                this.FIND_EXPANDED_SEARCH_RADIUS = "25";
            }
            else
            {
                this.FIND_EXPANDED_SEARCH_RADIUS = FIND_EXPANDED_SEARCH_RADIUS;
            }
            // use default value if no "FIND_ALTERNATE_LOOKUP" provided
            if (FIND_ALTERNATE_LOOKUP == null)
            {
                this.FIND_ALTERNATE_LOOKUP = "3";
            }
            else
            {
                this.FIND_ALTERNATE_LOOKUP = FIND_ALTERNATE_LOOKUP;
            }
            // use default value if no "FIND_STREET_CENTROID" provided
            if (FIND_STREET_CENTROID == null)
            {
                this.FIND_STREET_CENTROID = false;
            }
            else
            {
                this.FIND_STREET_CENTROID = FIND_STREET_CENTROID;
            }
            // use default value if no "FIND_FIRST_LETTER_EXPANDED" provided
            if (FIND_FIRST_LETTER_EXPANDED == null)
            {
                this.FIND_FIRST_LETTER_EXPANDED = false;
            }
            else
            {
                this.FIND_FIRST_LETTER_EXPANDED = FIND_FIRST_LETTER_EXPANDED;
            }
        }
        
        /// <summary>
        /// Gets or Sets FIND_ADDR_POINT_INTERP
        /// </summary>
        [DataMember(Name="FIND_ADDR_POINT_INTERP", EmitDefaultValue=false)]
        public bool? FIND_ADDR_POINT_INTERP { get; set; }
        /// <summary>
        /// Gets or Sets FIND_SEARCH_AREA
        /// </summary>
        [DataMember(Name="FIND_SEARCH_AREA", EmitDefaultValue=false)]
        public string FIND_SEARCH_AREA { get; set; }
        /// <summary>
        /// Gets or Sets FIND_ADDRESS_RANGE
        /// </summary>
        [DataMember(Name="FIND_ADDRESS_RANGE", EmitDefaultValue=false)]
        public bool? FIND_ADDRESS_RANGE { get; set; }
        /// <summary>
        /// Gets or Sets FIND_EXPANDED_SEARCH_RADIUS
        /// </summary>
        [DataMember(Name="FIND_EXPANDED_SEARCH_RADIUS", EmitDefaultValue=false)]
        public string FIND_EXPANDED_SEARCH_RADIUS { get; set; }
        /// <summary>
        /// Gets or Sets FIND_ALTERNATE_LOOKUP
        /// </summary>
        [DataMember(Name="FIND_ALTERNATE_LOOKUP", EmitDefaultValue=false)]
        public string FIND_ALTERNATE_LOOKUP { get; set; }
        /// <summary>
        /// Gets or Sets FIND_STREET_CENTROID
        /// </summary>
        [DataMember(Name="FIND_STREET_CENTROID", EmitDefaultValue=false)]
        public bool? FIND_STREET_CENTROID { get; set; }
        /// <summary>
        /// Gets or Sets FIND_FIRST_LETTER_EXPANDED
        /// </summary>
        [DataMember(Name="FIND_FIRST_LETTER_EXPANDED", EmitDefaultValue=false)]
        public bool? FIND_FIRST_LETTER_EXPANDED { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomPreferences {\n");
            sb.Append("  FIND_ADDR_POINT_INTERP: ").Append(FIND_ADDR_POINT_INTERP).Append("\n");
            sb.Append("  FIND_SEARCH_AREA: ").Append(FIND_SEARCH_AREA).Append("\n");
            sb.Append("  FIND_ADDRESS_RANGE: ").Append(FIND_ADDRESS_RANGE).Append("\n");
            sb.Append("  FIND_EXPANDED_SEARCH_RADIUS: ").Append(FIND_EXPANDED_SEARCH_RADIUS).Append("\n");
            sb.Append("  FIND_ALTERNATE_LOOKUP: ").Append(FIND_ALTERNATE_LOOKUP).Append("\n");
            sb.Append("  FIND_STREET_CENTROID: ").Append(FIND_STREET_CENTROID).Append("\n");
            sb.Append("  FIND_FIRST_LETTER_EXPANDED: ").Append(FIND_FIRST_LETTER_EXPANDED).Append("\n");
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
            return this.Equals(obj as CustomPreferences);
        }

        /// <summary>
        /// Returns true if CustomPreferences instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomPreferences other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FIND_ADDR_POINT_INTERP == other.FIND_ADDR_POINT_INTERP ||
                    this.FIND_ADDR_POINT_INTERP != null &&
                    this.FIND_ADDR_POINT_INTERP.Equals(other.FIND_ADDR_POINT_INTERP)
                ) && 
                (
                    this.FIND_SEARCH_AREA == other.FIND_SEARCH_AREA ||
                    this.FIND_SEARCH_AREA != null &&
                    this.FIND_SEARCH_AREA.Equals(other.FIND_SEARCH_AREA)
                ) && 
                (
                    this.FIND_ADDRESS_RANGE == other.FIND_ADDRESS_RANGE ||
                    this.FIND_ADDRESS_RANGE != null &&
                    this.FIND_ADDRESS_RANGE.Equals(other.FIND_ADDRESS_RANGE)
                ) && 
                (
                    this.FIND_EXPANDED_SEARCH_RADIUS == other.FIND_EXPANDED_SEARCH_RADIUS ||
                    this.FIND_EXPANDED_SEARCH_RADIUS != null &&
                    this.FIND_EXPANDED_SEARCH_RADIUS.Equals(other.FIND_EXPANDED_SEARCH_RADIUS)
                ) && 
                (
                    this.FIND_ALTERNATE_LOOKUP == other.FIND_ALTERNATE_LOOKUP ||
                    this.FIND_ALTERNATE_LOOKUP != null &&
                    this.FIND_ALTERNATE_LOOKUP.Equals(other.FIND_ALTERNATE_LOOKUP)
                ) && 
                (
                    this.FIND_STREET_CENTROID == other.FIND_STREET_CENTROID ||
                    this.FIND_STREET_CENTROID != null &&
                    this.FIND_STREET_CENTROID.Equals(other.FIND_STREET_CENTROID)
                ) && 
                (
                    this.FIND_FIRST_LETTER_EXPANDED == other.FIND_FIRST_LETTER_EXPANDED ||
                    this.FIND_FIRST_LETTER_EXPANDED != null &&
                    this.FIND_FIRST_LETTER_EXPANDED.Equals(other.FIND_FIRST_LETTER_EXPANDED)
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
                if (this.FIND_ADDR_POINT_INTERP != null)
                    hash = hash * 59 + this.FIND_ADDR_POINT_INTERP.GetHashCode();
                if (this.FIND_SEARCH_AREA != null)
                    hash = hash * 59 + this.FIND_SEARCH_AREA.GetHashCode();
                if (this.FIND_ADDRESS_RANGE != null)
                    hash = hash * 59 + this.FIND_ADDRESS_RANGE.GetHashCode();
                if (this.FIND_EXPANDED_SEARCH_RADIUS != null)
                    hash = hash * 59 + this.FIND_EXPANDED_SEARCH_RADIUS.GetHashCode();
                if (this.FIND_ALTERNATE_LOOKUP != null)
                    hash = hash * 59 + this.FIND_ALTERNATE_LOOKUP.GetHashCode();
                if (this.FIND_STREET_CENTROID != null)
                    hash = hash * 59 + this.FIND_STREET_CENTROID.GetHashCode();
                if (this.FIND_FIRST_LETTER_EXPANDED != null)
                    hash = hash * 59 + this.FIND_FIRST_LETTER_EXPANDED.GetHashCode();
                return hash;
            }
        }
    }

}
