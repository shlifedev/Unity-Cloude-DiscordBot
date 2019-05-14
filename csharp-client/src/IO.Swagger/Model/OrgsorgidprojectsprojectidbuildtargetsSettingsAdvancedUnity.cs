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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity
    /// </summary>
    [DataContract]
    public partial class OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity" /> class.
        /// </summary>
        /// <param name="preExportMethod">The fully-qualified name of a public static method you want us to call before we start the Unity build process. For example: ClassName.NeatMethod or NameSpace.ClassName.NeatMethod. No trailing parenthesis, and it can&#39;t have the same name as your Post-Export method!.</param>
        /// <param name="postExportMethod">The fully-qualified name of a public static method you want us to call after we finish the Unity build process (but before Xcode). For example: ClassName.CoolMethod or NameSpace.ClassName.CoolMethod. No trailing parenthesis, and it can&#39;t have the same name as your Post-Export method! This method must accept a string parameter, which will receive the path to the exported Unity player (or Xcode project in the case of iOS)..</param>
        /// <param name="preBuildScript">Relative path to the script that should be run before the build process starts..</param>
        /// <param name="postBuildScript">Relative path to the script that should be run after the build process finishes..</param>
        /// <param name="scriptingDefineSymbols">Enter the names of the symbols you want to define for iOS. These symbols can then be used as the conditions for #if directives just like the built-in ones. (i.e. #IF MYDEFINE or #IF AMAZON).</param>
        /// <param name="playerExporter">playerExporter.</param>
        /// <param name="playerSettings">playerSettings.</param>
        /// <param name="editorUserBuildSettings">editorUserBuildSettings.</param>
        /// <param name="assetBundles">assetBundles.</param>
        /// <param name="runUnitTests">Run any unit tests your project has when a build happens..</param>
        /// <param name="runEditModeTests">Should Edit Mode unit tests be run? NOTE: requires runUnitTests to be true and building with Unity 5.6 or newer..</param>
        /// <param name="runPlayModeTests">Should Play Mode unit tests be run? NOTE: requires runUnitTests to be true and building with Unity 5.6 or newer..</param>
        /// <param name="failedUnitTestFailsBuild">Mark builds as failed if the unit tests do not pass..</param>
        /// <param name="unitTestMethod">LEGACY - The Unity method to call when running unit tests (only supported in Unity 5.2 and lower)..</param>
        /// <param name="enableLightBake">Enable lightmap baking (disabled by default since it is very slow and usually unnecessary).</param>
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity(string preExportMethod = default(string), string postExportMethod = default(string), string preBuildScript = default(string), string postBuildScript = default(string), string scriptingDefineSymbols = default(string), OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter playerExporter = default(OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter), OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerSettings playerSettings = default(OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerSettings), OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityEditorUserBuildSettings editorUserBuildSettings = default(OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityEditorUserBuildSettings), OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles assetBundles = default(OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles), bool? runUnitTests = default(bool?), bool? runEditModeTests = default(bool?), bool? runPlayModeTests = default(bool?), bool? failedUnitTestFailsBuild = default(bool?), string unitTestMethod = default(string), bool? enableLightBake = default(bool?))
        {
            this.PreExportMethod = preExportMethod;
            this.PostExportMethod = postExportMethod;
            this.PreBuildScript = preBuildScript;
            this.PostBuildScript = postBuildScript;
            this.ScriptingDefineSymbols = scriptingDefineSymbols;
            this.PlayerExporter = playerExporter;
            this.PlayerSettings = playerSettings;
            this.EditorUserBuildSettings = editorUserBuildSettings;
            this.AssetBundles = assetBundles;
            this.RunUnitTests = runUnitTests;
            this.RunEditModeTests = runEditModeTests;
            this.RunPlayModeTests = runPlayModeTests;
            this.FailedUnitTestFailsBuild = failedUnitTestFailsBuild;
            this.UnitTestMethod = unitTestMethod;
            this.EnableLightBake = enableLightBake;
        }
        
        /// <summary>
        /// The fully-qualified name of a public static method you want us to call before we start the Unity build process. For example: ClassName.NeatMethod or NameSpace.ClassName.NeatMethod. No trailing parenthesis, and it can&#39;t have the same name as your Post-Export method!
        /// </summary>
        /// <value>The fully-qualified name of a public static method you want us to call before we start the Unity build process. For example: ClassName.NeatMethod or NameSpace.ClassName.NeatMethod. No trailing parenthesis, and it can&#39;t have the same name as your Post-Export method!</value>
        [DataMember(Name="preExportMethod", EmitDefaultValue=false)]
        public string PreExportMethod { get; set; }

        /// <summary>
        /// The fully-qualified name of a public static method you want us to call after we finish the Unity build process (but before Xcode). For example: ClassName.CoolMethod or NameSpace.ClassName.CoolMethod. No trailing parenthesis, and it can&#39;t have the same name as your Post-Export method! This method must accept a string parameter, which will receive the path to the exported Unity player (or Xcode project in the case of iOS).
        /// </summary>
        /// <value>The fully-qualified name of a public static method you want us to call after we finish the Unity build process (but before Xcode). For example: ClassName.CoolMethod or NameSpace.ClassName.CoolMethod. No trailing parenthesis, and it can&#39;t have the same name as your Post-Export method! This method must accept a string parameter, which will receive the path to the exported Unity player (or Xcode project in the case of iOS).</value>
        [DataMember(Name="postExportMethod", EmitDefaultValue=false)]
        public string PostExportMethod { get; set; }

        /// <summary>
        /// Relative path to the script that should be run before the build process starts.
        /// </summary>
        /// <value>Relative path to the script that should be run before the build process starts.</value>
        [DataMember(Name="preBuildScript", EmitDefaultValue=false)]
        public string PreBuildScript { get; set; }

        /// <summary>
        /// Relative path to the script that should be run after the build process finishes.
        /// </summary>
        /// <value>Relative path to the script that should be run after the build process finishes.</value>
        [DataMember(Name="postBuildScript", EmitDefaultValue=false)]
        public string PostBuildScript { get; set; }

        /// <summary>
        /// Enter the names of the symbols you want to define for iOS. These symbols can then be used as the conditions for #if directives just like the built-in ones. (i.e. #IF MYDEFINE or #IF AMAZON)
        /// </summary>
        /// <value>Enter the names of the symbols you want to define for iOS. These symbols can then be used as the conditions for #if directives just like the built-in ones. (i.e. #IF MYDEFINE or #IF AMAZON)</value>
        [DataMember(Name="scriptingDefineSymbols", EmitDefaultValue=false)]
        public string ScriptingDefineSymbols { get; set; }

        /// <summary>
        /// Gets or Sets PlayerExporter
        /// </summary>
        [DataMember(Name="playerExporter", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter PlayerExporter { get; set; }

        /// <summary>
        /// Gets or Sets PlayerSettings
        /// </summary>
        [DataMember(Name="playerSettings", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerSettings PlayerSettings { get; set; }

        /// <summary>
        /// Gets or Sets EditorUserBuildSettings
        /// </summary>
        [DataMember(Name="editorUserBuildSettings", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityEditorUserBuildSettings EditorUserBuildSettings { get; set; }

        /// <summary>
        /// Gets or Sets AssetBundles
        /// </summary>
        [DataMember(Name="assetBundles", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles AssetBundles { get; set; }

        /// <summary>
        /// Run any unit tests your project has when a build happens.
        /// </summary>
        /// <value>Run any unit tests your project has when a build happens.</value>
        [DataMember(Name="runUnitTests", EmitDefaultValue=false)]
        public bool? RunUnitTests { get; set; }

        /// <summary>
        /// Should Edit Mode unit tests be run? NOTE: requires runUnitTests to be true and building with Unity 5.6 or newer.
        /// </summary>
        /// <value>Should Edit Mode unit tests be run? NOTE: requires runUnitTests to be true and building with Unity 5.6 or newer.</value>
        [DataMember(Name="runEditModeTests", EmitDefaultValue=false)]
        public bool? RunEditModeTests { get; set; }

        /// <summary>
        /// Should Play Mode unit tests be run? NOTE: requires runUnitTests to be true and building with Unity 5.6 or newer.
        /// </summary>
        /// <value>Should Play Mode unit tests be run? NOTE: requires runUnitTests to be true and building with Unity 5.6 or newer.</value>
        [DataMember(Name="runPlayModeTests", EmitDefaultValue=false)]
        public bool? RunPlayModeTests { get; set; }

        /// <summary>
        /// Mark builds as failed if the unit tests do not pass.
        /// </summary>
        /// <value>Mark builds as failed if the unit tests do not pass.</value>
        [DataMember(Name="failedUnitTestFailsBuild", EmitDefaultValue=false)]
        public bool? FailedUnitTestFailsBuild { get; set; }

        /// <summary>
        /// LEGACY - The Unity method to call when running unit tests (only supported in Unity 5.2 and lower).
        /// </summary>
        /// <value>LEGACY - The Unity method to call when running unit tests (only supported in Unity 5.2 and lower).</value>
        [DataMember(Name="unitTestMethod", EmitDefaultValue=false)]
        public string UnitTestMethod { get; set; }

        /// <summary>
        /// Enable lightmap baking (disabled by default since it is very slow and usually unnecessary)
        /// </summary>
        /// <value>Enable lightmap baking (disabled by default since it is very slow and usually unnecessary)</value>
        [DataMember(Name="enableLightBake", EmitDefaultValue=false)]
        public bool? EnableLightBake { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity {\n");
            sb.Append("  PreExportMethod: ").Append(PreExportMethod).Append("\n");
            sb.Append("  PostExportMethod: ").Append(PostExportMethod).Append("\n");
            sb.Append("  PreBuildScript: ").Append(PreBuildScript).Append("\n");
            sb.Append("  PostBuildScript: ").Append(PostBuildScript).Append("\n");
            sb.Append("  ScriptingDefineSymbols: ").Append(ScriptingDefineSymbols).Append("\n");
            sb.Append("  PlayerExporter: ").Append(PlayerExporter).Append("\n");
            sb.Append("  PlayerSettings: ").Append(PlayerSettings).Append("\n");
            sb.Append("  EditorUserBuildSettings: ").Append(EditorUserBuildSettings).Append("\n");
            sb.Append("  AssetBundles: ").Append(AssetBundles).Append("\n");
            sb.Append("  RunUnitTests: ").Append(RunUnitTests).Append("\n");
            sb.Append("  RunEditModeTests: ").Append(RunEditModeTests).Append("\n");
            sb.Append("  RunPlayModeTests: ").Append(RunPlayModeTests).Append("\n");
            sb.Append("  FailedUnitTestFailsBuild: ").Append(FailedUnitTestFailsBuild).Append("\n");
            sb.Append("  UnitTestMethod: ").Append(UnitTestMethod).Append("\n");
            sb.Append("  EnableLightBake: ").Append(EnableLightBake).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity instances are equal
        /// </summary>
        /// <param name="input">Instance of OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreExportMethod == input.PreExportMethod ||
                    (this.PreExportMethod != null &&
                    this.PreExportMethod.Equals(input.PreExportMethod))
                ) && 
                (
                    this.PostExportMethod == input.PostExportMethod ||
                    (this.PostExportMethod != null &&
                    this.PostExportMethod.Equals(input.PostExportMethod))
                ) && 
                (
                    this.PreBuildScript == input.PreBuildScript ||
                    (this.PreBuildScript != null &&
                    this.PreBuildScript.Equals(input.PreBuildScript))
                ) && 
                (
                    this.PostBuildScript == input.PostBuildScript ||
                    (this.PostBuildScript != null &&
                    this.PostBuildScript.Equals(input.PostBuildScript))
                ) && 
                (
                    this.ScriptingDefineSymbols == input.ScriptingDefineSymbols ||
                    (this.ScriptingDefineSymbols != null &&
                    this.ScriptingDefineSymbols.Equals(input.ScriptingDefineSymbols))
                ) && 
                (
                    this.PlayerExporter == input.PlayerExporter ||
                    (this.PlayerExporter != null &&
                    this.PlayerExporter.Equals(input.PlayerExporter))
                ) && 
                (
                    this.PlayerSettings == input.PlayerSettings ||
                    (this.PlayerSettings != null &&
                    this.PlayerSettings.Equals(input.PlayerSettings))
                ) && 
                (
                    this.EditorUserBuildSettings == input.EditorUserBuildSettings ||
                    (this.EditorUserBuildSettings != null &&
                    this.EditorUserBuildSettings.Equals(input.EditorUserBuildSettings))
                ) && 
                (
                    this.AssetBundles == input.AssetBundles ||
                    (this.AssetBundles != null &&
                    this.AssetBundles.Equals(input.AssetBundles))
                ) && 
                (
                    this.RunUnitTests == input.RunUnitTests ||
                    (this.RunUnitTests != null &&
                    this.RunUnitTests.Equals(input.RunUnitTests))
                ) && 
                (
                    this.RunEditModeTests == input.RunEditModeTests ||
                    (this.RunEditModeTests != null &&
                    this.RunEditModeTests.Equals(input.RunEditModeTests))
                ) && 
                (
                    this.RunPlayModeTests == input.RunPlayModeTests ||
                    (this.RunPlayModeTests != null &&
                    this.RunPlayModeTests.Equals(input.RunPlayModeTests))
                ) && 
                (
                    this.FailedUnitTestFailsBuild == input.FailedUnitTestFailsBuild ||
                    (this.FailedUnitTestFailsBuild != null &&
                    this.FailedUnitTestFailsBuild.Equals(input.FailedUnitTestFailsBuild))
                ) && 
                (
                    this.UnitTestMethod == input.UnitTestMethod ||
                    (this.UnitTestMethod != null &&
                    this.UnitTestMethod.Equals(input.UnitTestMethod))
                ) && 
                (
                    this.EnableLightBake == input.EnableLightBake ||
                    (this.EnableLightBake != null &&
                    this.EnableLightBake.Equals(input.EnableLightBake))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PreExportMethod != null)
                    hashCode = hashCode * 59 + this.PreExportMethod.GetHashCode();
                if (this.PostExportMethod != null)
                    hashCode = hashCode * 59 + this.PostExportMethod.GetHashCode();
                if (this.PreBuildScript != null)
                    hashCode = hashCode * 59 + this.PreBuildScript.GetHashCode();
                if (this.PostBuildScript != null)
                    hashCode = hashCode * 59 + this.PostBuildScript.GetHashCode();
                if (this.ScriptingDefineSymbols != null)
                    hashCode = hashCode * 59 + this.ScriptingDefineSymbols.GetHashCode();
                if (this.PlayerExporter != null)
                    hashCode = hashCode * 59 + this.PlayerExporter.GetHashCode();
                if (this.PlayerSettings != null)
                    hashCode = hashCode * 59 + this.PlayerSettings.GetHashCode();
                if (this.EditorUserBuildSettings != null)
                    hashCode = hashCode * 59 + this.EditorUserBuildSettings.GetHashCode();
                if (this.AssetBundles != null)
                    hashCode = hashCode * 59 + this.AssetBundles.GetHashCode();
                if (this.RunUnitTests != null)
                    hashCode = hashCode * 59 + this.RunUnitTests.GetHashCode();
                if (this.RunEditModeTests != null)
                    hashCode = hashCode * 59 + this.RunEditModeTests.GetHashCode();
                if (this.RunPlayModeTests != null)
                    hashCode = hashCode * 59 + this.RunPlayModeTests.GetHashCode();
                if (this.FailedUnitTestFailsBuild != null)
                    hashCode = hashCode * 59 + this.FailedUnitTestFailsBuild.GetHashCode();
                if (this.UnitTestMethod != null)
                    hashCode = hashCode * 59 + this.UnitTestMethod.GetHashCode();
                if (this.EnableLightBake != null)
                    hashCode = hashCode * 59 + this.EnableLightBake.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
