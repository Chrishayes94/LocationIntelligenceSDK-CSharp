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
    ///  Class for testing LIAPIGeoZoneServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LIAPIGeoZoneServiceApiTests
    {
        private LIAPIGeoZoneServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LIAPIGeoZoneServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LIAPIGeoZoneServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' LIAPIGeoZoneServiceApi
            Assert.IsInstanceOf(typeof(LIAPIGeoZoneServiceApi), instance, "instance is a LIAPIGeoZoneServiceApi");
        }

        
        /// <summary>
        /// Test GetBasicBoundaryByAddress
        /// </summary>
        [Test]
        public void GetBasicBoundaryByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string distance = null;
            //string country = null;
            //string distanceUnit = null;
            //string resolution = null;
            //string responseSrs = null;
            //var response = instance.GetBasicBoundaryByAddress(address, distance, country, distanceUnit, resolution, responseSrs);
            //Assert.IsInstanceOf<BasicBoundaryAddress> (response, "response is BasicBoundaryAddress");
        }
        
        /// <summary>
        /// Test GetBasicBoundaryByLocation
        /// </summary>
        [Test]
        public void GetBasicBoundaryByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string latitude = null;
            //string longitude = null;
            //string distance = null;
            //string distanceUnit = null;
            //string resolution = null;
            //string responseSrs = null;
            //string srsName = null;
            //var response = instance.GetBasicBoundaryByLocation(latitude, longitude, distance, distanceUnit, resolution, responseSrs, srsName);
            //Assert.IsInstanceOf<BasicBoundary> (response, "response is BasicBoundary");
        }
        
        /// <summary>
        /// Test GetPOIBoundaryByAddress
        /// </summary>
        [Test]
        public void GetPOIBoundaryByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string naicsCode = null;
            //var response = instance.GetPOIBoundaryByAddress(address, categoryCode, sicCode, naicsCode);
            //Assert.IsInstanceOf<PoiBoundary> (response, "response is PoiBoundary");
        }
        
        /// <summary>
        /// Test GetPOIBoundaryByAddressBatch
        /// </summary>
        [Test]
        public void GetPOIBoundaryByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //POIBoundaryAddressRequest body = null;
            //var response = instance.GetPOIBoundaryByAddressBatch(body);
            //Assert.IsInstanceOf<POIBoundaryResponse> (response, "response is POIBoundaryResponse");
        }
        
        /// <summary>
        /// Test GetPOIBoundaryByLocation
        /// </summary>
        [Test]
        public void GetPOIBoundaryByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string latitude = null;
            //string longitude = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string naicsCode = null;
            //var response = instance.GetPOIBoundaryByLocation(latitude, longitude, categoryCode, sicCode, naicsCode);
            //Assert.IsInstanceOf<PoiBoundary> (response, "response is PoiBoundary");
        }
        
        /// <summary>
        /// Test GetPOIBoundaryByLocationBatch
        /// </summary>
        [Test]
        public void GetPOIBoundaryByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //POIBoundaryLocationRequest body = null;
            //var response = instance.GetPOIBoundaryByLocationBatch(body);
            //Assert.IsInstanceOf<POIBoundaryResponse> (response, "response is POIBoundaryResponse");
        }
        
        /// <summary>
        /// Test GetTravelBoundaryByDistance
        /// </summary>
        [Test]
        public void GetTravelBoundaryByDistanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string costs = null;
            //string point = null;
            //string address = null;
            //string costUnit = null;
            //string db = null;
            //string country = null;
            //string maxOffroadDistance = null;
            //string maxOffroadDistanceUnit = null;
            //string destinationSrs = null;
            //string majorRoads = null;
            //string returnHoles = null;
            //string returnIslands = null;
            //string simplificationFactor = null;
            //string bandingStyle = null;
            //string historicTrafficTimeBucket = null;
            //string defaultAmbientSpeed = null;
            //string ambientSpeedUnit = null;
            //var response = instance.GetTravelBoundaryByDistance(costs, point, address, costUnit, db, country, maxOffroadDistance, maxOffroadDistanceUnit, destinationSrs, majorRoads, returnHoles, returnIslands, simplificationFactor, bandingStyle, historicTrafficTimeBucket, defaultAmbientSpeed, ambientSpeedUnit);
            //Assert.IsInstanceOf<TravelBoundaries> (response, "response is TravelBoundaries");
        }
        
        /// <summary>
        /// Test GetTravelBoundaryByTime
        /// </summary>
        [Test]
        public void GetTravelBoundaryByTimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string costs = null;
            //string point = null;
            //string address = null;
            //string costUnit = null;
            //string db = null;
            //string country = null;
            //string maxOffroadDistance = null;
            //string maxOffroadDistanceUnit = null;
            //string destinationSrs = null;
            //string majorRoads = null;
            //string returnHoles = null;
            //string returnIslands = null;
            //string simplificationFactor = null;
            //string bandingStyle = null;
            //string historicTrafficTimeBucket = null;
            //string defaultAmbientSpeed = null;
            //string ambientSpeedUnit = null;
            //var response = instance.GetTravelBoundaryByTime(costs, point, address, costUnit, db, country, maxOffroadDistance, maxOffroadDistanceUnit, destinationSrs, majorRoads, returnHoles, returnIslands, simplificationFactor, bandingStyle, historicTrafficTimeBucket, defaultAmbientSpeed, ambientSpeedUnit);
            //Assert.IsInstanceOf<TravelBoundaries> (response, "response is TravelBoundaries");
        }
        
    }

}
