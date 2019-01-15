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
    ///  Class for testing LIAPIGeoEnrichServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LIAPIGeoEnrichServiceApiTests
    {
        private LIAPIGeoEnrichServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LIAPIGeoEnrichServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LIAPIGeoEnrichServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' LIAPIGeoEnrichServiceApi
            Assert.IsInstanceOf(typeof(LIAPIGeoEnrichServiceApi), instance, "instance is a LIAPIGeoEnrichServiceApi");
        }

        
        /// <summary>
        /// Test GetCategoryCodeMetadata
        /// </summary>
        [Test]
        public void GetCategoryCodeMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryCode = null;
            //var response = instance.GetCategoryCodeMetadata(categoryCode);
            //Assert.IsInstanceOf<GeoEnrichMetadataResponse> (response, "response is GeoEnrichMetadataResponse");
        }
        
        /// <summary>
        /// Test GetPOIsByAddress
        /// </summary>
        [Test]
        public void GetPOIsByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //string name = null;
            //string type = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string maxCandidates = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string travelMode = null;
            //string sortBy = null;
            //var response = instance.GetPOIsByAddress(address, country, name, type, categoryCode, sicCode, maxCandidates, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, sortBy);
            //Assert.IsInstanceOf<GeoEnrichResponse> (response, "response is GeoEnrichResponse");
        }
        
        /// <summary>
        /// Test GetPOIsByLocation
        /// </summary>
        [Test]
        public void GetPOIsByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string name = null;
            //string type = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string maxCandidates = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string travelMode = null;
            //string sortBy = null;
            //var response = instance.GetPOIsByLocation(longitude, latitude, name, type, categoryCode, sicCode, maxCandidates, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, sortBy);
            //Assert.IsInstanceOf<GeoEnrichResponse> (response, "response is GeoEnrichResponse");
        }
        
        /// <summary>
        /// Test GetPlaceByLocation
        /// </summary>
        [Test]
        public void GetPlaceByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string levelHint = null;
            //var response = instance.GetPlaceByLocation(longitude, latitude, levelHint);
            //Assert.IsInstanceOf<PlaceByLocations> (response, "response is PlaceByLocations");
        }
        
        /// <summary>
        /// Test GetSICMetadata
        /// </summary>
        [Test]
        public void GetSICMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sicCode = null;
            //var response = instance.GetSICMetadata(sicCode);
            //Assert.IsInstanceOf<GeoEnrichMetadataResponse> (response, "response is GeoEnrichMetadataResponse");
        }
        
    }

}
