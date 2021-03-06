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
    /// Result of an photo to words-with-location OCR operation
    /// </summary>
    [DataContract]
    public partial class PhotoToWordsWithLocationResult :  IEquatable<PhotoToWordsWithLocationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhotoToWordsWithLocationResult" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="textElements">Word elements in the image.</param>
        /// <param name="diagnosticImage">Typically null.  To analyze OCR performance, enable diagnostic mode by adding the HTTP header \&quot;DiagnosticMode\&quot; with the value \&quot;true\&quot;.  When this is true, a diagnostic image showing the details of the OCR result will be set in PNG format into DiagnosticImage..</param>
        public PhotoToWordsWithLocationResult(bool? successful = default(bool?), List<OcrPhotoTextElement> textElements = default(List<OcrPhotoTextElement>), byte[] diagnosticImage = default(byte[]))
        {
            this.Successful = successful;
            this.TextElements = textElements;
            this.DiagnosticImage = diagnosticImage;
        }
        
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
        [DataMember(Name="TextElements", EmitDefaultValue=false)]
        public List<OcrPhotoTextElement> TextElements { get; set; }

        /// <summary>
        /// Typically null.  To analyze OCR performance, enable diagnostic mode by adding the HTTP header \&quot;DiagnosticMode\&quot; with the value \&quot;true\&quot;.  When this is true, a diagnostic image showing the details of the OCR result will be set in PNG format into DiagnosticImage.
        /// </summary>
        /// <value>Typically null.  To analyze OCR performance, enable diagnostic mode by adding the HTTP header \&quot;DiagnosticMode\&quot; with the value \&quot;true\&quot;.  When this is true, a diagnostic image showing the details of the OCR result will be set in PNG format into DiagnosticImage.</value>
        [DataMember(Name="DiagnosticImage", EmitDefaultValue=false)]
        public byte[] DiagnosticImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhotoToWordsWithLocationResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  TextElements: ").Append(TextElements).Append("\n");
            sb.Append("  DiagnosticImage: ").Append(DiagnosticImage).Append("\n");
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
            return this.Equals(input as PhotoToWordsWithLocationResult);
        }

        /// <summary>
        /// Returns true if PhotoToWordsWithLocationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PhotoToWordsWithLocationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhotoToWordsWithLocationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.TextElements == input.TextElements ||
                    this.TextElements != null &&
                    this.TextElements.SequenceEqual(input.TextElements)
                ) && 
                (
                    this.DiagnosticImage == input.DiagnosticImage ||
                    (this.DiagnosticImage != null &&
                    this.DiagnosticImage.Equals(input.DiagnosticImage))
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.TextElements != null)
                    hashCode = hashCode * 59 + this.TextElements.GetHashCode();
                if (this.DiagnosticImage != null)
                    hashCode = hashCode * 59 + this.DiagnosticImage.GetHashCode();
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
