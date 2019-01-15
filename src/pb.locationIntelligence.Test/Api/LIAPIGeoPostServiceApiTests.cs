/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 6.0.0
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
    ///  Class for testing LIAPIGeoPostServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LIAPIGeoPostServiceApiTests
    {
        private LIAPIGeoPostServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LIAPIGeoPostServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LIAPIGeoPostServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' LIAPIGeoPostServiceApi
            Assert.IsInstanceOf(typeof(LIAPIGeoPostServiceApi), instance, "instance is a LIAPIGeoPostServiceApi");
        }

        
        /// <summary>
        /// Test GetCarrierRoutesByAddress
        /// </summary>
        [Test]
        public void GetCarrierRoutesByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string includeGeometry = null;
            //var response = instance.GetCarrierRoutesByAddress(address, includeGeometry);
            //Assert.IsInstanceOf<CarrierRouteResponse> (response, "response is CarrierRouteResponse");
        }
        
        /// <summary>
        /// Test GetCarrierRoutesByAddressBatch
        /// </summary>
        [Test]
        public void GetCarrierRoutesByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CarrierRouteAddressRequest body = null;
            //var response = instance.GetCarrierRoutesByAddressBatch(body);
            //Assert.IsInstanceOf<CarrierRouteResponseList> (response, "response is CarrierRouteResponseList");
        }
        
    }

}
