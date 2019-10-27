# Cloudmersive.APIClient.NET.OCR.Model.FormFieldDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldID** | **string** | The identifier of the field; use this to identify which field is being referenced | [optional] 
**LeftAnchor** | **string** | Optional - the left-hand anchor of the field | [optional] 
**TopAnchor** | **string** | Optional - the top anchor of the field | [optional] 
**AnchorMode** | **string** | Optional - the matching mode for the anchor.  Possible values are Complete (requires the entire anchor to match) and Partial (allows only part of the anchor to match).  Default is Partial. | [optional] 
**DataType** | **string** | The data type of the field; possible values are INTEGER (Integer value), STRING (Arbitrary string value, spaces are permitted), DATE (Date in a structured format), DECIMAL (Decimal number), ALPHANUMERIC (Continuous alphanumeric string with no spaces), STRINGNOWHITESPACE (A string that contains no whitespace characters), SERIALNUMBER (A serial-number style string that contains letters and numbers, and certain symbols; must contain at least one number), ALPHAONLY (Alphabet characters only, no numbers or symbols or whitespace) | [optional] 
**TargetDigitCount** | **int?** | Optional - the target number of digits in the field; useful for fixed-length fields | [optional] 
**MinimumCharacterCount** | **int?** | Optional - the target number of digits in the field; useful for fixed-length fields | [optional] 
**AllowNumericDigits** | **bool?** | Optional - set to false to block values that contain numeric digits, set to true to allow numeric digits | [optional] 
**VerticalAlignmentType** | **string** | Vertical alignment of target value area relative to the field anchor; Possible values are VCenter, Top, Bottom | [optional] 
**HorizontalAlignmentType** | **string** | Horizontal alignment of target value area relative to the field anchor; Possible values are Left, Right | [optional] 
**TargetFieldWidthRelative** | **double?** | Optional - scale factor for target field width - relative to width of field title; a value of 1.0 indicates the target value area has the same width as the field value as occurring in the image; a value of 2.0 would indicate that the target value area has 2 times the width of the field value as occurring in the image. | [optional] 
**TargetFieldHeightRelative** | **double?** | Optional - scale factor for target field height - relative to height of field title | [optional] 
**Ignore** | **List&lt;string&gt;** | Optional - Ignore any result items that contain a partial or complete match with these text strings | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
