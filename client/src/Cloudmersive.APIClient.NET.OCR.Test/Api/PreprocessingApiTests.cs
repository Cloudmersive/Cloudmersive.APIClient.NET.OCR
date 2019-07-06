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
    ///  Class for testing PreprocessingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PreprocessingApiTests
    {
        private PreprocessingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PreprocessingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PreprocessingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PreprocessingApi
            //Assert.IsInstanceOfType(typeof(PreprocessingApi), instance, "instance is a PreprocessingApi");
        }

        
        /// <summary>
        /// Test PreprocessingBinarize
        /// </summary>
        [Test]
        public void PreprocessingBinarizeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.PreprocessingBinarize(imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test PreprocessingBinarizeAdvanced
        /// </summary>
        [Test]
        public void PreprocessingBinarizeAdvancedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.PreprocessingBinarizeAdvanced(imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test PreprocessingGetPageAngle
        /// </summary>
        [Test]
        public void PreprocessingGetPageAngleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.PreprocessingGetPageAngle(imageFile);
            //Assert.IsInstanceOf<GetPageAngleResult> (response, "response is GetPageAngleResult");
        }
        
        /// <summary>
        /// Test PreprocessingUnrotate
        /// </summary>
        [Test]
        public void PreprocessingUnrotateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.PreprocessingUnrotate(imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test PreprocessingUnskew
        /// </summary>
        [Test]
        public void PreprocessingUnskewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.PreprocessingUnskew(imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}
