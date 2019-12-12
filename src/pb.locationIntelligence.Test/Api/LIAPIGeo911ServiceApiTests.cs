/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 8.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using pb.locationIntelligence.Client;
using pb.locationIntelligence.Api;
using pb.locationIntelligence.Model;

namespace pb.locationIntelligence.Test
{
    /// <summary>
    ///  Class for testing LIAPIGeo911ServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LIAPIGeo911ServiceApiTests
    {
        private LIAPIGeo911ServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LIAPIGeo911ServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LIAPIGeo911ServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' LIAPIGeo911ServiceApi
            Assert.IsInstanceOf(typeof(LIAPIGeo911ServiceApi), instance, "instance is a LIAPIGeo911ServiceApi");
        }

        
        /// <summary>
        /// Test GetAHJPlusPSAPByAddress
        /// </summary>
        [Test]
        public void GetAHJPlusPSAPByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //var response = instance.GetAHJPlusPSAPByAddress(address);
            //Assert.IsInstanceOf<AHJPlusPSAPResponse> (response, "response is AHJPlusPSAPResponse");
        }
        
        /// <summary>
        /// Test GetAHJPlusPSAPByLocation
        /// </summary>
        [Test]
        public void GetAHJPlusPSAPByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //var response = instance.GetAHJPlusPSAPByLocation(longitude, latitude);
            //Assert.IsInstanceOf<AHJPlusPSAPResponse> (response, "response is AHJPlusPSAPResponse");
        }
        
        /// <summary>
        /// Test GetPSAPByAddress
        /// </summary>
        [Test]
        public void GetPSAPByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //var response = instance.GetPSAPByAddress(address);
            //Assert.IsInstanceOf<PSAPResponse> (response, "response is PSAPResponse");
        }
        
        /// <summary>
        /// Test GetPSAPByLocation
        /// </summary>
        [Test]
        public void GetPSAPByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //var response = instance.GetPSAPByLocation(longitude, latitude);
            //Assert.IsInstanceOf<PSAPResponse> (response, "response is PSAPResponse");
        }
        
    }

}
