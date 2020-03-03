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
    /// Preferences
    /// </summary>
    [DataContract]
    public partial class Preferences :  IEquatable<Preferences>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Preferences" /> class.
        /// </summary>
        /// <param name="FallbackToGeographic">FallbackToGeographic.</param>
        /// <param name="UseGeoTaxAuxiliaryFile">UseGeoTaxAuxiliaryFile.</param>
        /// <param name="MatchMode">MatchMode (default to &quot;EXACT&quot;).</param>
        /// <param name="LatLongOffset">LatLongOffset (default to &quot;40&quot;).</param>
        /// <param name="Squeeze">Squeeze.</param>
        /// <param name="LatLongFormat">LatLongFormat (default to &quot;Decimal&quot;).</param>
        /// <param name="DefaultBufferWidth">DefaultBufferWidth (default to &quot;0&quot;).</param>
        /// <param name="DistanceUnits">DistanceUnits (default to &quot;Feet&quot;).</param>
        /// <param name="OutputCasing">OutputCasing (default to &quot;M&quot;).</param>
        /// <param name="ReturnCensusFields">ReturnCensusFields.</param>
        /// <param name="ReturnLatLongFields">ReturnLatLongFields.</param>
        /// <param name="CustomPreferences">CustomPreferences.</param>
        public Preferences(string FallbackToGeographic = null, string UseGeoTaxAuxiliaryFile = null, string MatchMode = null, string LatLongOffset = null, string Squeeze = null, string LatLongFormat = null, string DefaultBufferWidth = null, string DistanceUnits = null, string OutputCasing = null, string ReturnCensusFields = null, string ReturnLatLongFields = null, CustomPreferences CustomPreferences = null)
        {
            this.FallbackToGeographic = FallbackToGeographic;
            this.UseGeoTaxAuxiliaryFile = UseGeoTaxAuxiliaryFile;
            // use default value if no "MatchMode" provided
            if (MatchMode == null)
            {
                this.MatchMode = "EXACT";
            }
            else
            {
                this.MatchMode = MatchMode;
            }
            // use default value if no "LatLongOffset" provided
            if (LatLongOffset == null)
            {
                this.LatLongOffset = "40";
            }
            else
            {
                this.LatLongOffset = LatLongOffset;
            }
            this.Squeeze = Squeeze;
            // use default value if no "LatLongFormat" provided
            if (LatLongFormat == null)
            {
                this.LatLongFormat = "Decimal";
            }
            else
            {
                this.LatLongFormat = LatLongFormat;
            }
            // use default value if no "DefaultBufferWidth" provided
            if (DefaultBufferWidth == null)
            {
                this.DefaultBufferWidth = "0";
            }
            else
            {
                this.DefaultBufferWidth = DefaultBufferWidth;
            }
            // use default value if no "DistanceUnits" provided
            if (DistanceUnits == null)
            {
                this.DistanceUnits = "Feet";
            }
            else
            {
                this.DistanceUnits = DistanceUnits;
            }
            // use default value if no "OutputCasing" provided
            if (OutputCasing == null)
            {
                this.OutputCasing = "M";
            }
            else
            {
                this.OutputCasing = OutputCasing;
            }
            this.ReturnCensusFields = ReturnCensusFields;
            this.ReturnLatLongFields = ReturnLatLongFields;
            this.CustomPreferences = CustomPreferences;
        }
        
        /// <summary>
        /// Gets or Sets FallbackToGeographic
        /// </summary>
        [DataMember(Name="fallbackToGeographic", EmitDefaultValue=false)]
        public string FallbackToGeographic { get; set; }
        /// <summary>
        /// Gets or Sets UseGeoTaxAuxiliaryFile
        /// </summary>
        [DataMember(Name="useGeoTaxAuxiliaryFile", EmitDefaultValue=false)]
        public string UseGeoTaxAuxiliaryFile { get; set; }
        /// <summary>
        /// Gets or Sets MatchMode
        /// </summary>
        [DataMember(Name="matchMode", EmitDefaultValue=false)]
        public string MatchMode { get; set; }
        /// <summary>
        /// Gets or Sets LatLongOffset
        /// </summary>
        [DataMember(Name="latLongOffset", EmitDefaultValue=false)]
        public string LatLongOffset { get; set; }
        /// <summary>
        /// Gets or Sets Squeeze
        /// </summary>
        [DataMember(Name="squeeze", EmitDefaultValue=false)]
        public string Squeeze { get; set; }
        /// <summary>
        /// Gets or Sets LatLongFormat
        /// </summary>
        [DataMember(Name="latLongFormat", EmitDefaultValue=false)]
        public string LatLongFormat { get; set; }
        /// <summary>
        /// Gets or Sets DefaultBufferWidth
        /// </summary>
        [DataMember(Name="defaultBufferWidth", EmitDefaultValue=false)]
        public string DefaultBufferWidth { get; set; }
        /// <summary>
        /// Gets or Sets DistanceUnits
        /// </summary>
        [DataMember(Name="distanceUnits", EmitDefaultValue=false)]
        public string DistanceUnits { get; set; }
        /// <summary>
        /// Gets or Sets OutputCasing
        /// </summary>
        [DataMember(Name="outputCasing", EmitDefaultValue=false)]
        public string OutputCasing { get; set; }
        /// <summary>
        /// Gets or Sets ReturnCensusFields
        /// </summary>
        [DataMember(Name="returnCensusFields", EmitDefaultValue=false)]
        public string ReturnCensusFields { get; set; }
        /// <summary>
        /// Gets or Sets ReturnLatLongFields
        /// </summary>
        [DataMember(Name="returnLatLongFields", EmitDefaultValue=false)]
        public string ReturnLatLongFields { get; set; }
        /// <summary>
        /// Gets or Sets CustomPreferences
        /// </summary>
        [DataMember(Name="customPreferences", EmitDefaultValue=false)]
        public CustomPreferences CustomPreferences { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Preferences {\n");
            sb.Append("  FallbackToGeographic: ").Append(FallbackToGeographic).Append("\n");
            sb.Append("  UseGeoTaxAuxiliaryFile: ").Append(UseGeoTaxAuxiliaryFile).Append("\n");
            sb.Append("  MatchMode: ").Append(MatchMode).Append("\n");
            sb.Append("  LatLongOffset: ").Append(LatLongOffset).Append("\n");
            sb.Append("  Squeeze: ").Append(Squeeze).Append("\n");
            sb.Append("  LatLongFormat: ").Append(LatLongFormat).Append("\n");
            sb.Append("  DefaultBufferWidth: ").Append(DefaultBufferWidth).Append("\n");
            sb.Append("  DistanceUnits: ").Append(DistanceUnits).Append("\n");
            sb.Append("  OutputCasing: ").Append(OutputCasing).Append("\n");
            sb.Append("  ReturnCensusFields: ").Append(ReturnCensusFields).Append("\n");
            sb.Append("  ReturnLatLongFields: ").Append(ReturnLatLongFields).Append("\n");
            sb.Append("  CustomPreferences: ").Append(CustomPreferences).Append("\n");
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
            return this.Equals(obj as Preferences);
        }

        /// <summary>
        /// Returns true if Preferences instances are equal
        /// </summary>
        /// <param name="other">Instance of Preferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Preferences other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FallbackToGeographic == other.FallbackToGeographic ||
                    this.FallbackToGeographic != null &&
                    this.FallbackToGeographic.Equals(other.FallbackToGeographic)
                ) && 
                (
                    this.UseGeoTaxAuxiliaryFile == other.UseGeoTaxAuxiliaryFile ||
                    this.UseGeoTaxAuxiliaryFile != null &&
                    this.UseGeoTaxAuxiliaryFile.Equals(other.UseGeoTaxAuxiliaryFile)
                ) && 
                (
                    this.MatchMode == other.MatchMode ||
                    this.MatchMode != null &&
                    this.MatchMode.Equals(other.MatchMode)
                ) && 
                (
                    this.LatLongOffset == other.LatLongOffset ||
                    this.LatLongOffset != null &&
                    this.LatLongOffset.Equals(other.LatLongOffset)
                ) && 
                (
                    this.Squeeze == other.Squeeze ||
                    this.Squeeze != null &&
                    this.Squeeze.Equals(other.Squeeze)
                ) && 
                (
                    this.LatLongFormat == other.LatLongFormat ||
                    this.LatLongFormat != null &&
                    this.LatLongFormat.Equals(other.LatLongFormat)
                ) && 
                (
                    this.DefaultBufferWidth == other.DefaultBufferWidth ||
                    this.DefaultBufferWidth != null &&
                    this.DefaultBufferWidth.Equals(other.DefaultBufferWidth)
                ) && 
                (
                    this.DistanceUnits == other.DistanceUnits ||
                    this.DistanceUnits != null &&
                    this.DistanceUnits.Equals(other.DistanceUnits)
                ) && 
                (
                    this.OutputCasing == other.OutputCasing ||
                    this.OutputCasing != null &&
                    this.OutputCasing.Equals(other.OutputCasing)
                ) && 
                (
                    this.ReturnCensusFields == other.ReturnCensusFields ||
                    this.ReturnCensusFields != null &&
                    this.ReturnCensusFields.Equals(other.ReturnCensusFields)
                ) && 
                (
                    this.ReturnLatLongFields == other.ReturnLatLongFields ||
                    this.ReturnLatLongFields != null &&
                    this.ReturnLatLongFields.Equals(other.ReturnLatLongFields)
                ) && 
                (
                    this.CustomPreferences == other.CustomPreferences ||
                    this.CustomPreferences != null &&
                    this.CustomPreferences.Equals(other.CustomPreferences)
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
                if (this.FallbackToGeographic != null)
                    hash = hash * 59 + this.FallbackToGeographic.GetHashCode();
                if (this.UseGeoTaxAuxiliaryFile != null)
                    hash = hash * 59 + this.UseGeoTaxAuxiliaryFile.GetHashCode();
                if (this.MatchMode != null)
                    hash = hash * 59 + this.MatchMode.GetHashCode();
                if (this.LatLongOffset != null)
                    hash = hash * 59 + this.LatLongOffset.GetHashCode();
                if (this.Squeeze != null)
                    hash = hash * 59 + this.Squeeze.GetHashCode();
                if (this.LatLongFormat != null)
                    hash = hash * 59 + this.LatLongFormat.GetHashCode();
                if (this.DefaultBufferWidth != null)
                    hash = hash * 59 + this.DefaultBufferWidth.GetHashCode();
                if (this.DistanceUnits != null)
                    hash = hash * 59 + this.DistanceUnits.GetHashCode();
                if (this.OutputCasing != null)
                    hash = hash * 59 + this.OutputCasing.GetHashCode();
                if (this.ReturnCensusFields != null)
                    hash = hash * 59 + this.ReturnCensusFields.GetHashCode();
                if (this.ReturnLatLongFields != null)
                    hash = hash * 59 + this.ReturnLatLongFields.GetHashCode();
                if (this.CustomPreferences != null)
                    hash = hash * 59 + this.CustomPreferences.GetHashCode();
                return hash;
            }
        }
    }

}
