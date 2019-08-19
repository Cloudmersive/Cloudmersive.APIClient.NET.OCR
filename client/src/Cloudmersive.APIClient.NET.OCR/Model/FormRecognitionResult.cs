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
    /// The result of extracting form field values
    /// </summary>
    [DataContract]
    public partial class FormRecognitionResult :  IEquatable<FormRecognitionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormRecognitionResult" /> class.
        /// </summary>
        /// <param name="successful">successful.</param>
        /// <param name="fieldValueExtractionResult">fieldValueExtractionResult.</param>
        public FormRecognitionResult(bool? successful = default(bool?), List<FieldResult> fieldValueExtractionResult = default(List<FieldResult>))
        {
            this.Successful = successful;
            this.FieldValueExtractionResult = fieldValueExtractionResult;
        }
        
        /// <summary>
        /// Gets or Sets Successful
        /// </summary>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Gets or Sets FieldValueExtractionResult
        /// </summary>
        [DataMember(Name="FieldValueExtractionResult", EmitDefaultValue=false)]
        public List<FieldResult> FieldValueExtractionResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormRecognitionResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  FieldValueExtractionResult: ").Append(FieldValueExtractionResult).Append("\n");
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
            return this.Equals(input as FormRecognitionResult);
        }

        /// <summary>
        /// Returns true if FormRecognitionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FormRecognitionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormRecognitionResult input)
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
                    this.FieldValueExtractionResult == input.FieldValueExtractionResult ||
                    this.FieldValueExtractionResult != null &&
                    this.FieldValueExtractionResult.SequenceEqual(input.FieldValueExtractionResult)
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
                if (this.FieldValueExtractionResult != null)
                    hashCode = hashCode * 59 + this.FieldValueExtractionResult.GetHashCode();
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
