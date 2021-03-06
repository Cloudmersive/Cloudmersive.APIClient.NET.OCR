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
    /// OCR results of a page, including lines of text and their location
    /// </summary>
    [DataContract]
    public partial class OcrPageResultWithLinesWithLocation :  IEquatable<OcrPageResultWithLinesWithLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPageResultWithLinesWithLocation" /> class.
        /// </summary>
        /// <param name="pageNumber">Page number of the page that was OCR-ed, starting with 1 for the first page in the PDF file.</param>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="lines">Word elements in the image.</param>
        public OcrPageResultWithLinesWithLocation(int? pageNumber = default(int?), bool? successful = default(bool?), List<OcrLineElement> lines = default(List<OcrLineElement>))
        {
            this.PageNumber = pageNumber;
            this.Successful = successful;
            this.Lines = lines;
        }
        
        /// <summary>
        /// Page number of the page that was OCR-ed, starting with 1 for the first page in the PDF file
        /// </summary>
        /// <value>Page number of the page that was OCR-ed, starting with 1 for the first page in the PDF file</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Word elements in the image
        /// </summary>
        /// <value>Word elements in the image</value>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public List<OcrLineElement> Lines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OcrPageResultWithLinesWithLocation {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
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
            return this.Equals(input as OcrPageResultWithLinesWithLocation);
        }

        /// <summary>
        /// Returns true if OcrPageResultWithLinesWithLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of OcrPageResultWithLinesWithLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrPageResultWithLinesWithLocation input)
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
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
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
