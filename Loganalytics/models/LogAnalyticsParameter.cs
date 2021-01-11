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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsParameter
    /// </summary>
    public class LogAnalyticsParameter 
    {
        
        /// <value>
        /// default value
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }
        
        /// <value>
        /// description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// is active flag
        /// </value>
        [JsonProperty(PropertyName = "isActive")]
        public System.Nullable<bool> IsActive { get; set; }
        
        /// <value>
        /// parameter name
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// source Id
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public System.Nullable<long> SourceId { get; set; }
        
    }
}
