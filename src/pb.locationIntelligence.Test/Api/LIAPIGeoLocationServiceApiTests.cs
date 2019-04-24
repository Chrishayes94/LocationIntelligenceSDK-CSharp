/* 
 * Location Intelligence APIs
 *
 * Incorporate our extensive geodata into everyday applications, business processes and workflows.
 *
 * OpenAPI spec version: 6.5.0
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
    ///  Class for testing LIAPIGeoLocationServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LIAPIGeoLocationServiceApiTests
    {
        private LIAPIGeoLocationServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LIAPIGeoLocationServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LIAPIGeoLocationServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' LIAPIGeoLocationServiceApi
            Assert.IsInstanceOf(typeof(LIAPIGeoLocationServiceApi), instance, "instance is a LIAPIGeoLocationServiceApi");
        }

        
        /// <summary>
        /// Test GetDeviceStatus
        /// </summary>
        [Test]
        public void GetDeviceStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceId = null;
            //string includeNetworkInfo_ = null;
            //var response = instance.GetDeviceStatus(deviceId, includeNetworkInfo_);
            //Assert.IsInstanceOf<GeoLocationDeviceSatus> (response, "response is GeoLocationDeviceSatus");
        }
        
        /// <summary>
        /// Test GetLocationByFixedLine
        /// </summary>
        [Test]
        public void GetLocationByFixedLineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceId = null;
            //var response = instance.GetLocationByFixedLine(deviceId);
            //Assert.IsInstanceOf<GeoLocationFixedLine> (response, "response is GeoLocationFixedLine");
        }
        
        /// <summary>
        /// Test GetLocationByIPAddress
        /// </summary>
        [Test]
        public void GetLocationByIPAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ipAddress = null;
            //var response = instance.GetLocationByIPAddress(ipAddress);
            //Assert.IsInstanceOf<GeoLocationIpAddr> (response, "response is GeoLocationIpAddr");
        }
        
        /// <summary>
        /// Test GetLocationByWiFiAccessPoint
        /// </summary>
        [Test]
        public void GetLocationByWiFiAccessPointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string mac = null;
            //string ssid = null;
            //string rsid = null;
            //string speed = null;
            //string accessPoint = null;
            //var response = instance.GetLocationByWiFiAccessPoint(mac, ssid, rsid, speed, accessPoint);
            //Assert.IsInstanceOf<GeoLocationAccessPoint> (response, "response is GeoLocationAccessPoint");
        }
        
    }

}
