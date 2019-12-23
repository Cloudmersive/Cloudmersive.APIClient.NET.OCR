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
    /// Definition of a form field for OCR data extraction from images
    /// </summary>
    [DataContract]
    public partial class FormFieldDefinition :  IEquatable<FormFieldDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormFieldDefinition" /> class.
        /// </summary>
        /// <param name="fieldID">The identifier of the field; use this to identify which field is being referenced.  Set to SkipField if you do not wish to return the value of this field in the result..</param>
        /// <param name="leftAnchor">Optional - the left-hand anchor of the field.</param>
        /// <param name="topAnchor">Optional - the top anchor of the field.</param>
        /// <param name="bottomAnchor">Optional - the bottom anchor of the field.</param>
        /// <param name="anchorMode">Optional - the matching mode for the anchor.  Possible values are Complete (requires the entire anchor to match) and Partial (allows only part of the anchor to match) and Horizontal (anchor must be laid out horizontally).  Default is Partial..</param>
        /// <param name="dataType">The data type of the field; possible values are INTEGER (Integer value), STRING (Arbitrary string value, spaces are permitted), DATE (Date in a structured format), DECIMAL (Decimal number), ALPHANUMERIC (Continuous alphanumeric string with no spaces), STRINGNOWHITESPACE (A string that contains no whitespace characters), SERIALNUMBER (A serial-number style string that contains letters and numbers, and certain symbols; must contain at least one number), ALPHAONLY (Alphabet characters only, no numbers or symbols or whitespace).</param>
        /// <param name="targetDigitCount">Optional - the target number of digits in the field; useful for fixed-length fields.</param>
        /// <param name="minimumCharacterCount">Optional - the target number of digits in the field; useful for fixed-length fields.</param>
        /// <param name="allowNumericDigits">Optional - set to false to block values that contain numeric digits, set to true to allow numeric digits.</param>
        /// <param name="verticalAlignmentType">Vertical alignment of target value area relative to the field anchor; Possible values are VCenter, Top, Bottom.</param>
        /// <param name="horizontalAlignmentType">Horizontal alignment of target value area relative to the field anchor; Possible values are Left, Right.</param>
        /// <param name="targetFieldWidthRelative">Optional - scale factor for target field width - relative to width of field title; a value of 1.0 indicates the target value area has the same width as the field value as occurring in the image; a value of 2.0 would indicate that the target value area has 2 times the width of the field value as occurring in the image..</param>
        /// <param name="targetFieldHeightRelative">Optional - scale factor for target field height - relative to height of field title.</param>
        /// <param name="targetFieldHorizontalAdjustment">Optional - horizontal adjestment in relative width of the field.</param>
        /// <param name="targetFieldVerticalAdjustment">Optional - vertical adjestment in relative height of the field.</param>
        /// <param name="ignore">Optional - Ignore any result items that contain a partial or complete match with these text strings.</param>
        /// <param name="options">Optional - additional options that can be set for this field definition, separated by commas.  Possible values are AllowMultiMatch (allow the same anchor to be matched to multiple fields).</param>
        public FormFieldDefinition(string fieldID = default(string), string leftAnchor = default(string), string topAnchor = default(string), string bottomAnchor = default(string), string anchorMode = default(string), string dataType = default(string), int? targetDigitCount = default(int?), int? minimumCharacterCount = default(int?), bool? allowNumericDigits = default(bool?), string verticalAlignmentType = default(string), string horizontalAlignmentType = default(string), double? targetFieldWidthRelative = default(double?), double? targetFieldHeightRelative = default(double?), double? targetFieldHorizontalAdjustment = default(double?), double? targetFieldVerticalAdjustment = default(double?), List<string> ignore = default(List<string>), string options = default(string))
        {
            this.FieldID = fieldID;
            this.LeftAnchor = leftAnchor;
            this.TopAnchor = topAnchor;
            this.BottomAnchor = bottomAnchor;
            this.AnchorMode = anchorMode;
            this.DataType = dataType;
            this.TargetDigitCount = targetDigitCount;
            this.MinimumCharacterCount = minimumCharacterCount;
            this.AllowNumericDigits = allowNumericDigits;
            this.VerticalAlignmentType = verticalAlignmentType;
            this.HorizontalAlignmentType = horizontalAlignmentType;
            this.TargetFieldWidthRelative = targetFieldWidthRelative;
            this.TargetFieldHeightRelative = targetFieldHeightRelative;
            this.TargetFieldHorizontalAdjustment = targetFieldHorizontalAdjustment;
            this.TargetFieldVerticalAdjustment = targetFieldVerticalAdjustment;
            this.Ignore = ignore;
            this.Options = options;
        }
        
        /// <summary>
        /// The identifier of the field; use this to identify which field is being referenced.  Set to SkipField if you do not wish to return the value of this field in the result.
        /// </summary>
        /// <value>The identifier of the field; use this to identify which field is being referenced.  Set to SkipField if you do not wish to return the value of this field in the result.</value>
        [DataMember(Name="FieldID", EmitDefaultValue=false)]
        public string FieldID { get; set; }

        /// <summary>
        /// Optional - the left-hand anchor of the field
        /// </summary>
        /// <value>Optional - the left-hand anchor of the field</value>
        [DataMember(Name="LeftAnchor", EmitDefaultValue=false)]
        public string LeftAnchor { get; set; }

        /// <summary>
        /// Optional - the top anchor of the field
        /// </summary>
        /// <value>Optional - the top anchor of the field</value>
        [DataMember(Name="TopAnchor", EmitDefaultValue=false)]
        public string TopAnchor { get; set; }

        /// <summary>
        /// Optional - the bottom anchor of the field
        /// </summary>
        /// <value>Optional - the bottom anchor of the field</value>
        [DataMember(Name="BottomAnchor", EmitDefaultValue=false)]
        public string BottomAnchor { get; set; }

        /// <summary>
        /// Optional - the matching mode for the anchor.  Possible values are Complete (requires the entire anchor to match) and Partial (allows only part of the anchor to match) and Horizontal (anchor must be laid out horizontally).  Default is Partial.
        /// </summary>
        /// <value>Optional - the matching mode for the anchor.  Possible values are Complete (requires the entire anchor to match) and Partial (allows only part of the anchor to match) and Horizontal (anchor must be laid out horizontally).  Default is Partial.</value>
        [DataMember(Name="AnchorMode", EmitDefaultValue=false)]
        public string AnchorMode { get; set; }

        /// <summary>
        /// The data type of the field; possible values are INTEGER (Integer value), STRING (Arbitrary string value, spaces are permitted), DATE (Date in a structured format), DECIMAL (Decimal number), ALPHANUMERIC (Continuous alphanumeric string with no spaces), STRINGNOWHITESPACE (A string that contains no whitespace characters), SERIALNUMBER (A serial-number style string that contains letters and numbers, and certain symbols; must contain at least one number), ALPHAONLY (Alphabet characters only, no numbers or symbols or whitespace)
        /// </summary>
        /// <value>The data type of the field; possible values are INTEGER (Integer value), STRING (Arbitrary string value, spaces are permitted), DATE (Date in a structured format), DECIMAL (Decimal number), ALPHANUMERIC (Continuous alphanumeric string with no spaces), STRINGNOWHITESPACE (A string that contains no whitespace characters), SERIALNUMBER (A serial-number style string that contains letters and numbers, and certain symbols; must contain at least one number), ALPHAONLY (Alphabet characters only, no numbers or symbols or whitespace)</value>
        [DataMember(Name="DataType", EmitDefaultValue=false)]
        public string DataType { get; set; }

        /// <summary>
        /// Optional - the target number of digits in the field; useful for fixed-length fields
        /// </summary>
        /// <value>Optional - the target number of digits in the field; useful for fixed-length fields</value>
        [DataMember(Name="TargetDigitCount", EmitDefaultValue=false)]
        public int? TargetDigitCount { get; set; }

        /// <summary>
        /// Optional - the target number of digits in the field; useful for fixed-length fields
        /// </summary>
        /// <value>Optional - the target number of digits in the field; useful for fixed-length fields</value>
        [DataMember(Name="MinimumCharacterCount", EmitDefaultValue=false)]
        public int? MinimumCharacterCount { get; set; }

        /// <summary>
        /// Optional - set to false to block values that contain numeric digits, set to true to allow numeric digits
        /// </summary>
        /// <value>Optional - set to false to block values that contain numeric digits, set to true to allow numeric digits</value>
        [DataMember(Name="AllowNumericDigits", EmitDefaultValue=false)]
        public bool? AllowNumericDigits { get; set; }

        /// <summary>
        /// Vertical alignment of target value area relative to the field anchor; Possible values are VCenter, Top, Bottom
        /// </summary>
        /// <value>Vertical alignment of target value area relative to the field anchor; Possible values are VCenter, Top, Bottom</value>
        [DataMember(Name="VerticalAlignmentType", EmitDefaultValue=false)]
        public string VerticalAlignmentType { get; set; }

        /// <summary>
        /// Horizontal alignment of target value area relative to the field anchor; Possible values are Left, Right
        /// </summary>
        /// <value>Horizontal alignment of target value area relative to the field anchor; Possible values are Left, Right</value>
        [DataMember(Name="HorizontalAlignmentType", EmitDefaultValue=false)]
        public string HorizontalAlignmentType { get; set; }

        /// <summary>
        /// Optional - scale factor for target field width - relative to width of field title; a value of 1.0 indicates the target value area has the same width as the field value as occurring in the image; a value of 2.0 would indicate that the target value area has 2 times the width of the field value as occurring in the image.
        /// </summary>
        /// <value>Optional - scale factor for target field width - relative to width of field title; a value of 1.0 indicates the target value area has the same width as the field value as occurring in the image; a value of 2.0 would indicate that the target value area has 2 times the width of the field value as occurring in the image.</value>
        [DataMember(Name="TargetFieldWidth_Relative", EmitDefaultValue=false)]
        public double? TargetFieldWidthRelative { get; set; }

        /// <summary>
        /// Optional - scale factor for target field height - relative to height of field title
        /// </summary>
        /// <value>Optional - scale factor for target field height - relative to height of field title</value>
        [DataMember(Name="TargetFieldHeight_Relative", EmitDefaultValue=false)]
        public double? TargetFieldHeightRelative { get; set; }

        /// <summary>
        /// Optional - horizontal adjestment in relative width of the field
        /// </summary>
        /// <value>Optional - horizontal adjestment in relative width of the field</value>
        [DataMember(Name="TargetFieldHorizontalAdjustment", EmitDefaultValue=false)]
        public double? TargetFieldHorizontalAdjustment { get; set; }

        /// <summary>
        /// Optional - vertical adjestment in relative height of the field
        /// </summary>
        /// <value>Optional - vertical adjestment in relative height of the field</value>
        [DataMember(Name="TargetFieldVerticalAdjustment", EmitDefaultValue=false)]
        public double? TargetFieldVerticalAdjustment { get; set; }

        /// <summary>
        /// Optional - Ignore any result items that contain a partial or complete match with these text strings
        /// </summary>
        /// <value>Optional - Ignore any result items that contain a partial or complete match with these text strings</value>
        [DataMember(Name="Ignore", EmitDefaultValue=false)]
        public List<string> Ignore { get; set; }

        /// <summary>
        /// Optional - additional options that can be set for this field definition, separated by commas.  Possible values are AllowMultiMatch (allow the same anchor to be matched to multiple fields)
        /// </summary>
        /// <value>Optional - additional options that can be set for this field definition, separated by commas.  Possible values are AllowMultiMatch (allow the same anchor to be matched to multiple fields)</value>
        [DataMember(Name="Options", EmitDefaultValue=false)]
        public string Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormFieldDefinition {\n");
            sb.Append("  FieldID: ").Append(FieldID).Append("\n");
            sb.Append("  LeftAnchor: ").Append(LeftAnchor).Append("\n");
            sb.Append("  TopAnchor: ").Append(TopAnchor).Append("\n");
            sb.Append("  BottomAnchor: ").Append(BottomAnchor).Append("\n");
            sb.Append("  AnchorMode: ").Append(AnchorMode).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  TargetDigitCount: ").Append(TargetDigitCount).Append("\n");
            sb.Append("  MinimumCharacterCount: ").Append(MinimumCharacterCount).Append("\n");
            sb.Append("  AllowNumericDigits: ").Append(AllowNumericDigits).Append("\n");
            sb.Append("  VerticalAlignmentType: ").Append(VerticalAlignmentType).Append("\n");
            sb.Append("  HorizontalAlignmentType: ").Append(HorizontalAlignmentType).Append("\n");
            sb.Append("  TargetFieldWidthRelative: ").Append(TargetFieldWidthRelative).Append("\n");
            sb.Append("  TargetFieldHeightRelative: ").Append(TargetFieldHeightRelative).Append("\n");
            sb.Append("  TargetFieldHorizontalAdjustment: ").Append(TargetFieldHorizontalAdjustment).Append("\n");
            sb.Append("  TargetFieldVerticalAdjustment: ").Append(TargetFieldVerticalAdjustment).Append("\n");
            sb.Append("  Ignore: ").Append(Ignore).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as FormFieldDefinition);
        }

        /// <summary>
        /// Returns true if FormFieldDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of FormFieldDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormFieldDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldID == input.FieldID ||
                    (this.FieldID != null &&
                    this.FieldID.Equals(input.FieldID))
                ) && 
                (
                    this.LeftAnchor == input.LeftAnchor ||
                    (this.LeftAnchor != null &&
                    this.LeftAnchor.Equals(input.LeftAnchor))
                ) && 
                (
                    this.TopAnchor == input.TopAnchor ||
                    (this.TopAnchor != null &&
                    this.TopAnchor.Equals(input.TopAnchor))
                ) && 
                (
                    this.BottomAnchor == input.BottomAnchor ||
                    (this.BottomAnchor != null &&
                    this.BottomAnchor.Equals(input.BottomAnchor))
                ) && 
                (
                    this.AnchorMode == input.AnchorMode ||
                    (this.AnchorMode != null &&
                    this.AnchorMode.Equals(input.AnchorMode))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.TargetDigitCount == input.TargetDigitCount ||
                    (this.TargetDigitCount != null &&
                    this.TargetDigitCount.Equals(input.TargetDigitCount))
                ) && 
                (
                    this.MinimumCharacterCount == input.MinimumCharacterCount ||
                    (this.MinimumCharacterCount != null &&
                    this.MinimumCharacterCount.Equals(input.MinimumCharacterCount))
                ) && 
                (
                    this.AllowNumericDigits == input.AllowNumericDigits ||
                    (this.AllowNumericDigits != null &&
                    this.AllowNumericDigits.Equals(input.AllowNumericDigits))
                ) && 
                (
                    this.VerticalAlignmentType == input.VerticalAlignmentType ||
                    (this.VerticalAlignmentType != null &&
                    this.VerticalAlignmentType.Equals(input.VerticalAlignmentType))
                ) && 
                (
                    this.HorizontalAlignmentType == input.HorizontalAlignmentType ||
                    (this.HorizontalAlignmentType != null &&
                    this.HorizontalAlignmentType.Equals(input.HorizontalAlignmentType))
                ) && 
                (
                    this.TargetFieldWidthRelative == input.TargetFieldWidthRelative ||
                    (this.TargetFieldWidthRelative != null &&
                    this.TargetFieldWidthRelative.Equals(input.TargetFieldWidthRelative))
                ) && 
                (
                    this.TargetFieldHeightRelative == input.TargetFieldHeightRelative ||
                    (this.TargetFieldHeightRelative != null &&
                    this.TargetFieldHeightRelative.Equals(input.TargetFieldHeightRelative))
                ) && 
                (
                    this.TargetFieldHorizontalAdjustment == input.TargetFieldHorizontalAdjustment ||
                    (this.TargetFieldHorizontalAdjustment != null &&
                    this.TargetFieldHorizontalAdjustment.Equals(input.TargetFieldHorizontalAdjustment))
                ) && 
                (
                    this.TargetFieldVerticalAdjustment == input.TargetFieldVerticalAdjustment ||
                    (this.TargetFieldVerticalAdjustment != null &&
                    this.TargetFieldVerticalAdjustment.Equals(input.TargetFieldVerticalAdjustment))
                ) && 
                (
                    this.Ignore == input.Ignore ||
                    this.Ignore != null &&
                    this.Ignore.SequenceEqual(input.Ignore)
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.FieldID != null)
                    hashCode = hashCode * 59 + this.FieldID.GetHashCode();
                if (this.LeftAnchor != null)
                    hashCode = hashCode * 59 + this.LeftAnchor.GetHashCode();
                if (this.TopAnchor != null)
                    hashCode = hashCode * 59 + this.TopAnchor.GetHashCode();
                if (this.BottomAnchor != null)
                    hashCode = hashCode * 59 + this.BottomAnchor.GetHashCode();
                if (this.AnchorMode != null)
                    hashCode = hashCode * 59 + this.AnchorMode.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.TargetDigitCount != null)
                    hashCode = hashCode * 59 + this.TargetDigitCount.GetHashCode();
                if (this.MinimumCharacterCount != null)
                    hashCode = hashCode * 59 + this.MinimumCharacterCount.GetHashCode();
                if (this.AllowNumericDigits != null)
                    hashCode = hashCode * 59 + this.AllowNumericDigits.GetHashCode();
                if (this.VerticalAlignmentType != null)
                    hashCode = hashCode * 59 + this.VerticalAlignmentType.GetHashCode();
                if (this.HorizontalAlignmentType != null)
                    hashCode = hashCode * 59 + this.HorizontalAlignmentType.GetHashCode();
                if (this.TargetFieldWidthRelative != null)
                    hashCode = hashCode * 59 + this.TargetFieldWidthRelative.GetHashCode();
                if (this.TargetFieldHeightRelative != null)
                    hashCode = hashCode * 59 + this.TargetFieldHeightRelative.GetHashCode();
                if (this.TargetFieldHorizontalAdjustment != null)
                    hashCode = hashCode * 59 + this.TargetFieldHorizontalAdjustment.GetHashCode();
                if (this.TargetFieldVerticalAdjustment != null)
                    hashCode = hashCode * 59 + this.TargetFieldVerticalAdjustment.GetHashCode();
                if (this.Ignore != null)
                    hashCode = hashCode * 59 + this.Ignore.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
