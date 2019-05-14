/* 
 * Unity Cloud Build
 *
 * This API is intended to be used in conjunction with the Unity Cloud Build service. A tool for building your Unity projects in the Cloud.  See https://developer.cloud.unity3d.com for more information.  ## Making requests This website is built to allow requests to be made against the API. If you are currently logged into Cloud Build you should be able to make requests without entering an API key.   You can find your API key in the Unity Cloud Services portal by clicking on 'Cloud Build Preferences' in the sidebar. Copy the API Key and paste it into the upper left corner of this website. It will be used in all subsequent requests.  ## Clients The Unity Cloud Build API is based upon Swagger. Client libraries to integrate with your projects can easily be generated with the [Swagger Code Generator](https://github.com/swagger-api/swagger-codegen).  The JSON schema required to generate a client for this API version is located here:  ``` [API_URL][BASE_PATH]/api.json ```  ## Authorization The Unity Cloud Build API requires an access token from your Unity Cloud Build account, which can be found at https://build.cloud.unity3d.com/login/me  To authenticate requests, include a Basic Authentication header with your API key as the value. e.g.  ``` Authorization: Basic [YOUR API KEY] ```  ## Pagination Paged results will take two parameters. A page number that is calculated based upon the per_page amount. For instance if there are 40 results and you specify page 2 with per_page set to 10 you will receive records 11-20.  Paged results will also return a Content-Range header. For the example above the content range header would look like this:  ``` Content-Range: items 11-20/40 ```  ## Versioning The API version is indicated in the request URL. Upgrading to a newer API version can be done by changing the path.  The API will receive a new version in the following cases:    * removal of a path or request type   * addition of a required field   * removal of a required field  The following changes are considered backwards compatible and will not trigger a new API version:    * addition of an endpoint or request type   * addition of an optional field   * removal of an optional field   * changes to the format of ids  ## Rate Limiting Requests against the Cloud Build API are limited to a rate of 100 per minute. To preserve the quality of service throughout Cloud Build, additional rate limits may apply to some actions. For example, polling aggressively instead of using webhooks or making API calls with a high concurrency may result in rate limiting.  It is not intended for these rate limits to interfere with any legitimate use of the API. Please contact support at <cloudbuild@unity3d.com> if your use is affected by this rate limit.  You can check the returned HTTP headers for any API request to see your current rate limit status.   * __X-RateLimit-Limit:__ maximum number of requests per minute   * __X-RateLimit-Remaining:__ remaining number of requests in the current window   * __X-RateLimit-Reset:__ time at which the current window will reset (UTC epoch seconds)  Once you go over the rate limit you will receive an error response: ``` HTTP Status: 429 {   \"error\": \"Rate limit exceeded, retry in XX seconds\" } ``` 
 *
 * OpenAPI spec version: 1.0.0
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

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing WebhooksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WebhooksApiTests
    {
        private WebhooksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WebhooksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WebhooksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WebhooksApi
            //Assert.IsInstanceOfType(typeof(WebhooksApi), instance, "instance is a WebhooksApi");
        }

        
        /// <summary>
        /// Test AddHookForOrg
        /// </summary>
        [Test]
        public void AddHookForOrgTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //Options2 options = null;
            //var response = instance.AddHookForOrg(orgid, options);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test AddHookForProject
        /// </summary>
        [Test]
        public void AddHookForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //Options4 options = null;
            //var response = instance.AddHookForProject(orgid, projectid, options);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DeleteHook
        /// </summary>
        [Test]
        public void DeleteHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string id = null;
            //var response = instance.DeleteHook(orgid, id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteHook_0
        /// </summary>
        [Test]
        public void DeleteHook_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string id = null;
            //var response = instance.DeleteHook_0(orgid, projectid, id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetHook
        /// </summary>
        [Test]
        public void GetHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string id = null;
            //var response = instance.GetHook(orgid, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetHook_0
        /// </summary>
        [Test]
        public void GetHook_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string id = null;
            //var response = instance.GetHook_0(orgid, projectid, id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ListHooksForOrg
        /// </summary>
        [Test]
        public void ListHooksForOrgTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //var response = instance.ListHooksForOrg(orgid);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test ListHooksForProject
        /// </summary>
        [Test]
        public void ListHooksForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //var response = instance.ListHooksForProject(orgid, projectid);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test PingHook
        /// </summary>
        [Test]
        public void PingHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string id = null;
            //var response = instance.PingHook(orgid, id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PingHook_0
        /// </summary>
        [Test]
        public void PingHook_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string id = null;
            //var response = instance.PingHook_0(orgid, projectid, id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test UpdateHook
        /// </summary>
        [Test]
        public void UpdateHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string id = null;
            //Options3 options = null;
            //var response = instance.UpdateHook(orgid, id, options);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test UpdateHook_0
        /// </summary>
        [Test]
        public void UpdateHook_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string id = null;
            //Options5 options = null;
            //var response = instance.UpdateHook_0(orgid, projectid, id, options);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
