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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.OCR.Client;
using Cloudmersive.APIClient.NET.OCR.Api;
using Cloudmersive.APIClient.NET.OCR.Model;

namespace Cloudmersive.APIClient.NET.OCR.Test
{
    /// <summary>
    ///  Class for testing PdfOcrApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PdfOcrApiTests
    {
        private PdfOcrApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PdfOcrApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PdfOcrApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PdfOcrApi
            //Assert.IsInstanceOfType(typeof(PdfOcrApi), instance, "instance is a PdfOcrApi");
        }

        
        /// <summary>
        /// Test PdfOcrGetAsyncJobStatus
        /// </summary>
        [Test]
        public void PdfOcrGetAsyncJobStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string asyncJobID = null;
            //var response = instance.PdfOcrGetAsyncJobStatus(asyncJobID);
            //Assert.IsInstanceOf<PdfToTextResponse> (response, "response is PdfToTextResponse");
        }
        
        /// <summary>
        /// Test PdfOcrPdfToLinesWithLocation
        /// </summary>
        [Test]
        public void PdfOcrPdfToLinesWithLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //string language = null;
            //string preprocessing = null;
            //var response = instance.PdfOcrPdfToLinesWithLocation(imageFile, language, preprocessing);
            //Assert.IsInstanceOf<PdfToLinesWithLocationResult> (response, "response is PdfToLinesWithLocationResult");
        }
        
        /// <summary>
        /// Test PdfOcrPdfToWordsWithLocation
        /// </summary>
        [Test]
        public void PdfOcrPdfToWordsWithLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //string language = null;
            //string preprocessing = null;
            //var response = instance.PdfOcrPdfToWordsWithLocation(imageFile, language, preprocessing);
            //Assert.IsInstanceOf<PdfToWordsWithLocationResult> (response, "response is PdfToWordsWithLocationResult");
        }
        
        /// <summary>
        /// Test PdfOcrPost
        /// </summary>
        [Test]
        public void PdfOcrPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //string recognitionMode = null;
            //string language = null;
            //string preprocessing = null;
            //var response = instance.PdfOcrPost(imageFile, recognitionMode, language, preprocessing);
            //Assert.IsInstanceOf<PdfToTextResponse> (response, "response is PdfToTextResponse");
        }
        
    }

}
