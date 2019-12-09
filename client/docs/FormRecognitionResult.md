# Cloudmersive.APIClient.NET.OCR.Model.FormRecognitionResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if the operation was successful, false otherwise | [optional] 
**FieldValueExtractionResult** | [**List&lt;FieldResult&gt;**](FieldResult.md) | Result of form field OCR data extraction | [optional] 
**TableValueExtractionResults** | [**List&lt;TableResult&gt;**](TableResult.md) | Result of form table OCR data extraction | [optional] 
**Diagnostics** | **List&lt;string&gt;** | Diagnostic images - default is null, enable diagnostics&#x3D;true to populate this parameter with one image per field | [optional] 
**BestMatchFormSettingName** | **string** | Optional; populated when using photo/recognize/form/advanced with the Setting Name of the best-matching highest-relevance form | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

