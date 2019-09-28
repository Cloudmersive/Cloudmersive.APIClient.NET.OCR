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
    /// One row of data in the resulting table
    /// </summary>
    [DataContract]
    public partial class TableRowResult :  IEquatable<TableRowResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableRowResult" /> class.
        /// </summary>
        /// <param name="tableRowCellsResult">Table cells in this row result.</param>
        public TableRowResult(List<TableCellResult> tableRowCellsResult = default(List<TableCellResult>))
        {
            this.TableRowCellsResult = tableRowCellsResult;
        }
        
        /// <summary>
        /// Table cells in this row result
        /// </summary>
        /// <value>Table cells in this row result</value>
        [DataMember(Name="TableRowCellsResult", EmitDefaultValue=false)]
        public List<TableCellResult> TableRowCellsResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableRowResult {\n");
            sb.Append("  TableRowCellsResult: ").Append(TableRowCellsResult).Append("\n");
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
            return this.Equals(input as TableRowResult);
        }

        /// <summary>
        /// Returns true if TableRowResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TableRowResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableRowResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TableRowCellsResult == input.TableRowCellsResult ||
                    this.TableRowCellsResult != null &&
                    this.TableRowCellsResult.SequenceEqual(input.TableRowCellsResult)
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
                if (this.TableRowCellsResult != null)
                    hashCode = hashCode * 59 + this.TableRowCellsResult.GetHashCode();
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
