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
    /// Response from an OCR to text operation.  Includes the confidence rating and converted text result.
    /// </summary>
    [DataContract]
    public partial class PdfToTextResponse :  IEquatable<PdfToTextResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfToTextResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="ocrPages">Page OCR results.</param>
        /// <param name="asyncJobID">When the job exceeds 25 pages, an Async Job ID is returned.  Use the CheckPdfOcrJobStatus API to check on the status of this job using the AsyncJobID and get the result when it finishes.</param>
        /// <param name="asyncJobStatus">Returns the job status of the Async Job, if applicable.  Possible states are STARTED and COMPLETED.</param>
        public PdfToTextResponse(bool? successful = default(bool?), List<OcrPageResult> ocrPages = default(List<OcrPageResult>), string asyncJobID = default(string), string asyncJobStatus = default(string))
        {
            this.Successful = successful;
            this.OcrPages = ocrPages;
            this.AsyncJobID = asyncJobID;
            this.AsyncJobStatus = asyncJobStatus;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Page OCR results
        /// </summary>
        /// <value>Page OCR results</value>
        [DataMember(Name="OcrPages", EmitDefaultValue=false)]
        public List<OcrPageResult> OcrPages { get; set; }

        /// <summary>
        /// When the job exceeds 25 pages, an Async Job ID is returned.  Use the CheckPdfOcrJobStatus API to check on the status of this job using the AsyncJobID and get the result when it finishes
        /// </summary>
        /// <value>When the job exceeds 25 pages, an Async Job ID is returned.  Use the CheckPdfOcrJobStatus API to check on the status of this job using the AsyncJobID and get the result when it finishes</value>
        [DataMember(Name="AsyncJobID", EmitDefaultValue=false)]
        public string AsyncJobID { get; set; }

        /// <summary>
        /// Returns the job status of the Async Job, if applicable.  Possible states are STARTED and COMPLETED
        /// </summary>
        /// <value>Returns the job status of the Async Job, if applicable.  Possible states are STARTED and COMPLETED</value>
        [DataMember(Name="AsyncJobStatus", EmitDefaultValue=false)]
        public string AsyncJobStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfToTextResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  OcrPages: ").Append(OcrPages).Append("\n");
            sb.Append("  AsyncJobID: ").Append(AsyncJobID).Append("\n");
            sb.Append("  AsyncJobStatus: ").Append(AsyncJobStatus).Append("\n");
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
            return this.Equals(input as PdfToTextResponse);
        }

        /// <summary>
        /// Returns true if PdfToTextResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfToTextResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfToTextResponse input)
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
                    this.OcrPages == input.OcrPages ||
                    this.OcrPages != null &&
                    this.OcrPages.SequenceEqual(input.OcrPages)
                ) && 
                (
                    this.AsyncJobID == input.AsyncJobID ||
                    (this.AsyncJobID != null &&
                    this.AsyncJobID.Equals(input.AsyncJobID))
                ) && 
                (
                    this.AsyncJobStatus == input.AsyncJobStatus ||
                    (this.AsyncJobStatus != null &&
                    this.AsyncJobStatus.Equals(input.AsyncJobStatus))
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
                if (this.OcrPages != null)
                    hashCode = hashCode * 59 + this.OcrPages.GetHashCode();
                if (this.AsyncJobID != null)
                    hashCode = hashCode * 59 + this.AsyncJobID.GetHashCode();
                if (this.AsyncJobStatus != null)
                    hashCode = hashCode * 59 + this.AsyncJobStatus.GetHashCode();
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
