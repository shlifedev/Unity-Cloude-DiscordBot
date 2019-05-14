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
    ///  Class for testing BuildsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BuildsApiTests
    {
        private BuildsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BuildsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BuildsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BuildsApi
            //Assert.IsInstanceOfType(typeof(BuildsApi), instance, "instance is a BuildsApi");
        }

        
        /// <summary>
        /// Test BatchDeleteBuildArtifacts
        /// </summary>
        [Test]
        public void BatchDeleteBuildArtifactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //Options8 options = null;
            //var response = instance.BatchDeleteBuildArtifacts(orgid, projectid, options);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test CancelAllBuilds
        /// </summary>
        [Test]
        public void CancelAllBuildsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //var response = instance.CancelAllBuilds(orgid, projectid, buildtargetid);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test CancelBuild
        /// </summary>
        [Test]
        public void CancelBuildTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string number = null;
            //var response = instance.CancelBuild(orgid, projectid, buildtargetid, number);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test CancelBuildsForOrg
        /// </summary>
        [Test]
        public void CancelBuildsForOrgTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //var response = instance.CancelBuildsForOrg(orgid);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test CreateShare
        /// </summary>
        [Test]
        public void CreateShareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string number = null;
            //var response = instance.CreateShare(orgid, projectid, buildtargetid, number);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DeleteAllBuildArtifacts
        /// </summary>
        [Test]
        public void DeleteAllBuildArtifactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //var response = instance.DeleteAllBuildArtifacts(orgid, projectid, buildtargetid);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteBuildArtifacts
        /// </summary>
        [Test]
        public void DeleteBuildArtifactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string number = null;
            //var response = instance.DeleteBuildArtifacts(orgid, projectid, buildtargetid, number);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetAuditLog
        /// </summary>
        [Test]
        public void GetAuditLogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //decimal? perPage = null;
            //decimal? page = null;
            //var response = instance.GetAuditLog(orgid, projectid, buildtargetid, perPage, page);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test GetAuditLog_0
        /// </summary>
        [Test]
        public void GetAuditLog_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string number = null;
            //decimal? perPage = null;
            //decimal? page = null;
            //var response = instance.GetAuditLog_0(orgid, projectid, buildtargetid, number, perPage, page);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test GetBuild
        /// </summary>
        [Test]
        public void GetBuildTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string number = null;
            //string include = null;
            //var response = instance.GetBuild(orgid, projectid, buildtargetid, number, include);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetBuildLog
        /// </summary>
        [Test]
        public void GetBuildLogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string number = null;
            //decimal? offsetlines = null;
            //bool? linenumbers = null;
            //decimal? lastLineNumber = null;
            //bool? compact = null;
            //bool? withHtml = null;
            //instance.GetBuildLog(orgid, projectid, buildtargetid, number, offsetlines, linenumbers, lastLineNumber, compact, withHtml);
            
        }
        
        /// <summary>
        /// Test GetBuildSteps
        /// </summary>
        [Test]
        public void GetBuildStepsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string number = null;
            //var response = instance.GetBuildSteps(orgid, projectid, buildtargetid, number);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test GetBuilds
        /// </summary>
        [Test]
        public void GetBuildsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string include = null;
            //decimal? perPage = null;
            //decimal? page = null;
            //string buildStatus = null;
            //string platform = null;
            //bool? showDeleted = null;
            //bool? onlyFavorites = null;
            //bool? cleanBuild = null;
            //var response = instance.GetBuilds(orgid, projectid, buildtargetid, include, perPage, page, buildStatus, platform, showDeleted, onlyFavorites, cleanBuild);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test GetBuildsForOrg
        /// </summary>
        [Test]
        public void GetBuildsForOrgTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string include = null;
            //decimal? perPage = null;
            //decimal? page = null;
            //string buildStatus = null;
            //string platform = null;
            //bool? showDeleted = null;
            //bool? onlyFavorites = null;
            //bool? cleanBuild = null;
            //var response = instance.GetBuildsForOrg(orgid, include, perPage, page, buildStatus, platform, showDeleted, onlyFavorites, cleanBuild);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test GetShare
        /// </summary>
        [Test]
        public void GetShareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string number = null;
            //var response = instance.GetShare(orgid, projectid, buildtargetid, number);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ResignBuildArtifact
        /// </summary>
        [Test]
        public void ResignBuildArtifactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string number = null;
            //var response = instance.ResignBuildArtifact(orgid, projectid, buildtargetid, number);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test RevokeShare
        /// </summary>
        [Test]
        public void RevokeShareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string number = null;
            //var response = instance.RevokeShare(orgid, projectid, buildtargetid, number);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test StartBuilds
        /// </summary>
        [Test]
        public void StartBuildsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //Options9 options = null;
            //var response = instance.StartBuilds(orgid, projectid, buildtargetid, options);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test UpdateBuild
        /// </summary>
        [Test]
        public void UpdateBuildTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orgid = null;
            //string projectid = null;
            //string buildtargetid = null;
            //string number = null;
            //Options10 options = null;
            //var response = instance.UpdateBuild(orgid, projectid, buildtargetid, number, options);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
