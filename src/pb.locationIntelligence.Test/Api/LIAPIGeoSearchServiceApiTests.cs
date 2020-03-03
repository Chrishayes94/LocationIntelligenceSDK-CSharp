/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 8.5.0
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
    ///  Class for testing LIAPIGeoSearchServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LIAPIGeoSearchServiceApiTests
    {
        private LIAPIGeoSearchServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LIAPIGeoSearchServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LIAPIGeoSearchServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' LIAPIGeoSearchServiceApi
            Assert.IsInstanceOf(typeof(LIAPIGeoSearchServiceApi), instance, "instance is a LIAPIGeoSearchServiceApi");
        }

        
        /// <summary>
        /// Test GeoSearch
        /// </summary>
        [Test]
        public void GeoSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchText = null;
            //string latitude = null;
            //string longitude = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string maxCandidates = null;
            //string country = null;
            //string matchOnAddressNumber = null;
            //string autoDetectLocation = null;
            //string ipAddress = null;
            //string areaName1 = null;
            //string areaName3 = null;
            //string postCode = null;
            //string returnAdminAreasOnly = null;
            //string includeRangesDetails = null;
            //string searchType = null;
            //var response = instance.GeoSearch(searchText, latitude, longitude, searchRadius, searchRadiusUnit, maxCandidates, country, matchOnAddressNumber, autoDetectLocation, ipAddress, areaName1, areaName3, postCode, returnAdminAreasOnly, includeRangesDetails, searchType);
            //Assert.IsInstanceOf<GeosearchLocations> (response, "response is GeosearchLocations");
        }
        
    }

}
