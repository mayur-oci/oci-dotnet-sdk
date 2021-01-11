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


namespace Oci.IntegrationService.Models
{
    /// <summary>
    /// The information to be updated.
    /// </summary>
    public class UpdateIntegrationInstanceDetails 
    {
        
        /// <value>
        /// Integration Instance Identifier.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// Standard or Enterprise type
        /// </value>
        ///
        public enum IntegrationInstanceTypeEnum {
            [EnumMember(Value = "STANDARD")]
            Standard,
            [EnumMember(Value = "ENTERPRISE")]
            Enterprise
        };

        /// <value>
        /// Standard or Enterprise type
        /// </value>
        [JsonProperty(PropertyName = "integrationInstanceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IntegrationInstanceTypeEnum> IntegrationInstanceType { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name,
        /// type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to
        /// namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Bring your own license.
        /// </value>
        [JsonProperty(PropertyName = "isByol")]
        public System.Nullable<bool> IsByol { get; set; }
        
        /// <value>
        /// The number of configured message packs
        /// </value>
        [JsonProperty(PropertyName = "messagePacks")]
        public System.Nullable<int> MessagePacks { get; set; }
        
        /// <value>
        /// The file server is enabled or not.
        /// </value>
        [JsonProperty(PropertyName = "isFileServerEnabled")]
        public System.Nullable<bool> IsFileServerEnabled { get; set; }
        
        /// <value>
        /// Visual Builder is enabled or not.
        /// </value>
        [JsonProperty(PropertyName = "isVisualBuilderEnabled")]
        public System.Nullable<bool> IsVisualBuilderEnabled { get; set; }
        
        [JsonProperty(PropertyName = "customEndpoint")]
        public UpdateCustomEndpointDetails CustomEndpoint { get; set; }
        
        /// <value>
        /// A list of alternate custom endpoints to be used for the integration instance URL
        /// (contact Oracle for alternateCustomEndpoints availability for a specific instance).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "alternateCustomEndpoints")]
        public System.Collections.Generic.List<UpdateCustomEndpointDetails> AlternateCustomEndpoints { get; set; }
        
    }
}
