/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DataflowService.Models
{
    /// <summary>
    /// The create run details. The following properties are optional and override the default values
    /// set in the associated application:
    ///   - arguments
    ///   - configuration
    ///   - definedTags
    ///   - driverShape
    ///   - executorShape
    ///   - freeformTags
    ///   - logsBucketUri
    ///   - numExecutors
    ///   - parameters
    ///   - warehouseBucketUri
    /// If the optional properties are not specified, they are copied over from the parent application.
    /// Once a run is created, its properties (except for definedTags and freeformTags) cannot be changed.
    /// If the parent application's properties (including definedTags and freeformTags) are updated,
    /// the corresponding properties of the run will not update.
    /// 
    /// </summary>
    public class CreateRunDetails 
    {
        
        /// <value>
        /// The application ID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApplicationId is required.")]
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }
        
        /// <value>
        /// The arguments passed to the running application as command line arguments.  An argument is
        /// either a plain text or a placeholder. Placeholders are replaced using values from the parameters
        /// map.  Each placeholder specified must be represented in the parameters map else the request
        /// (POST or PUT) will fail with a HTTP 400 status code.  Placeholders are specified as
        /// `Service Api Spec`, where `name` is the name of the parameter.
        /// Example: [ &quot;--input&quot;, &quot;${input_file}&quot;, &quot;--name&quot;, &quot;John Doe&quot; ]If &quot;input_file&quot; has a value of &quot;mydata.xml&quot;, then the value above will be translated to--input mydata.xml --name &quot;John Doe&quot;
        /// </value>
        [JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.List<string> Arguments { get; set; }
        
        /// <value>
        /// The OCID of a compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The Spark configuration passed to the running process.
        /// See https://spark.apache.org/docs/latest/configuration.html#available-properties.
        /// Example: { &quot;spark.app.name&quot; : &quot;My App Name&quot;, &quot;spark.shuffle.io.maxRetries&quot; : &quot;4&quot; }Note: Not all Spark properties are permitted to be set.  Attempting to set a property that isnot allowed to be overwritten will cause a 400 status to be returned.
        /// </value>
        [JsonProperty(PropertyName = "configuration")]
        public System.Collections.Generic.Dictionary<string, string> Configuration { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. It does not have to be unique. Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The VM shape for the driver. Sets the driver cores and memory.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "driverShape")]
        public string DriverShape { get; set; }
        
        /// <value>
        /// The VM shape for the executors. Sets the executor cores and memory.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "executorShape")]
        public string ExecutorShape { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// An Oracle Cloud Infrastructure URI of the bucket where the Spark job logs are to be uploaded.
        /// See https://docs.cloud.oracle.com/iaas/Content/API/SDKDocs/hdfsconnector.htm#uriformat.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logsBucketUri")]
        public string LogsBucketUri { get; set; }
        
        /// <value>
        /// The number of executor VMs requested.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "numExecutors")]
        public System.Nullable<int> NumExecutors { get; set; }
        
        /// <value>
        /// An array of name/value pairs used to fill placeholders found in properties like
        /// `Application.arguments`.  The name must be a string of one or more word characters
        /// (a-z, A-Z, 0-9, _).  The value can be a string of 0 or more characters of any kind.
        /// Example: [ { name: &quot;iterations&quot;, value: &quot;10&quot;}, { name: &quot;input_file&quot;, value: &quot;mydata.xml&quot; }, { name: &quot;variable_x&quot;, value: &quot;${x}&quot;} ]
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<ApplicationParameter> Parameters { get; set; }
        
        /// <value>
        /// An Oracle Cloud Infrastructure URI of the bucket to be used as default warehouse directory
        /// for BATCH SQL runs.
        /// See https://docs.cloud.oracle.com/iaas/Content/API/SDKDocs/hdfsconnector.htm#uriformat.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "warehouseBucketUri")]
        public string WarehouseBucketUri { get; set; }
        
    }
}
