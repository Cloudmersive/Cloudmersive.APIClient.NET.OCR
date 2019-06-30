/* 
 * ocrapi
 *
 * The powerful Optical Character Recognition (OCR) APIs let you convert scanned images of pages into recognized text.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NET.OCR.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.OCR.Model
{
    /// <summary>
    /// Response from an OCR to text operation.  Includes the confience rating and converted text result.
    /// </summary>
    [DataContract]
    public partial class ImageToTextResponse :  IEquatable<ImageToTextResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToTextResponse" /> class.
        /// </summary>
        /// <param name="meanConfidenceLevel">Confidence level rating of the OCR operation; ratings above 80% are strong..</param>
        /// <param name="textResult">Converted text string from the image input..</param>
        public ImageToTextResponse(float? meanConfidenceLevel = default(float?), string textResult = default(string))
        {
            this.MeanConfidenceLevel = meanConfidenceLevel;
            this.TextResult = textResult;
        }
        
        /// <summary>
        /// Confidence level rating of the OCR operation; ratings above 80% are strong.
        /// </summary>
        /// <value>Confidence level rating of the OCR operation; ratings above 80% are strong.</value>
        [DataMember(Name="MeanConfidenceLevel", EmitDefaultValue=false)]
        public float? MeanConfidenceLevel { get; set; }

        /// <summary>
        /// Converted text string from the image input.
        /// </summary>
        /// <value>Converted text string from the image input.</value>
        [DataMember(Name="TextResult", EmitDefaultValue=false)]
        public string TextResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageToTextResponse {\n");
            sb.Append("  MeanConfidenceLevel: ").Append(MeanConfidenceLevel).Append("\n");
            sb.Append("  TextResult: ").Append(TextResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageToTextResponse);
        }

        /// <summary>
        /// Returns true if ImageToTextResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageToTextResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageToTextResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MeanConfidenceLevel == input.MeanConfidenceLevel ||
                    (this.MeanConfidenceLevel != null &&
                    this.MeanConfidenceLevel.Equals(input.MeanConfidenceLevel))
                ) && 
                (
                    this.TextResult == input.TextResult ||
                    (this.TextResult != null &&
                    this.TextResult.Equals(input.TextResult))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MeanConfidenceLevel != null)
                    hashCode = hashCode * 59 + this.MeanConfidenceLevel.GetHashCode();
                if (this.TextResult != null)
                    hashCode = hashCode * 59 + this.TextResult.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
