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
    /// OcrPageResult
    /// </summary>
    [DataContract]
    public partial class OcrPageResult :  IEquatable<OcrPageResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPageResult" /> class.
        /// </summary>
        /// <param name="pageNumber">Page number of the page that was OCR-ed, starting with 1 for the first page in the PDF file.</param>
        /// <param name="meanConfidenceLevel">Confidence level rating of the OCR operation; ratings above 80% are strong..</param>
        /// <param name="textResult">Converted text string from the image input..</param>
        public OcrPageResult(int? pageNumber = default(int?), float? meanConfidenceLevel = default(float?), string textResult = default(string))
        {
            this.PageNumber = pageNumber;
            this.MeanConfidenceLevel = meanConfidenceLevel;
            this.TextResult = textResult;
        }
        
        /// <summary>
        /// Page number of the page that was OCR-ed, starting with 1 for the first page in the PDF file
        /// </summary>
        /// <value>Page number of the page that was OCR-ed, starting with 1 for the first page in the PDF file</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

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
            sb.Append("class OcrPageResult {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
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
            return this.Equals(input as OcrPageResult);
        }

        /// <summary>
        /// Returns true if OcrPageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of OcrPageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrPageResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
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
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
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
