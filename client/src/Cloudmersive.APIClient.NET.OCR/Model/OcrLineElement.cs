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
    /// A contiguous line of text in an OCR document
    /// </summary>
    [DataContract]
    public partial class OcrLineElement :  IEquatable<OcrLineElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrLineElement" /> class.
        /// </summary>
        /// <param name="lineText">Text of the line.</param>
        /// <param name="words">Word objects in the line.</param>
        public OcrLineElement(string lineText = default(string), List<OcrWordElement> words = default(List<OcrWordElement>))
        {
            this.LineText = lineText;
            this.Words = words;
        }
        
        /// <summary>
        /// Text of the line
        /// </summary>
        /// <value>Text of the line</value>
        [DataMember(Name="LineText", EmitDefaultValue=false)]
        public string LineText { get; set; }

        /// <summary>
        /// Word objects in the line
        /// </summary>
        /// <value>Word objects in the line</value>
        [DataMember(Name="Words", EmitDefaultValue=false)]
        public List<OcrWordElement> Words { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OcrLineElement {\n");
            sb.Append("  LineText: ").Append(LineText).Append("\n");
            sb.Append("  Words: ").Append(Words).Append("\n");
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
            return this.Equals(input as OcrLineElement);
        }

        /// <summary>
        /// Returns true if OcrLineElement instances are equal
        /// </summary>
        /// <param name="input">Instance of OcrLineElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrLineElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineText == input.LineText ||
                    (this.LineText != null &&
                    this.LineText.Equals(input.LineText))
                ) && 
                (
                    this.Words == input.Words ||
                    this.Words != null &&
                    this.Words.SequenceEqual(input.Words)
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
                if (this.LineText != null)
                    hashCode = hashCode * 59 + this.LineText.GetHashCode();
                if (this.Words != null)
                    hashCode = hashCode * 59 + this.Words.GetHashCode();
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
