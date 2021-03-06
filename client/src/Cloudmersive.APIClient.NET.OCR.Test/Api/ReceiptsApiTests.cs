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

namespace Cloudmersive.APIClient.NET.OCR.Test
{
    /// <summary>
    ///  Class for testing ReceiptsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReceiptsApiTests
    {
        private ReceiptsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReceiptsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReceiptsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReceiptsApi
            //Assert.IsInstanceOfType(typeof(ReceiptsApi), instance, "instance is a ReceiptsApi");
        }

        
        /// <summary>
        /// Test ReceiptsPhotoToCSV
        /// </summary>
        [Test]
        public void ReceiptsPhotoToCSVTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.ReceiptsPhotoToCSV(imageFile);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
