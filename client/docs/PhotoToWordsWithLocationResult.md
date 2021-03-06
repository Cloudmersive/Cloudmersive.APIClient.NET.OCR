# Cloudmersive.APIClient.NET.OCR.Model.PhotoToWordsWithLocationResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if successful, false otherwise | [optional] 
**TextElements** | [**List&lt;OcrPhotoTextElement&gt;**](OcrPhotoTextElement.md) | Word elements in the image | [optional] 
**DiagnosticImage** | **byte[]** | Typically null.  To analyze OCR performance, enable diagnostic mode by adding the HTTP header \&quot;DiagnosticMode\&quot; with the value \&quot;true\&quot;.  When this is true, a diagnostic image showing the details of the OCR result will be set in PNG format into DiagnosticImage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

