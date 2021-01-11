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
    /// LookupField
    /// </summary>
    public class LookupField 
    {
        
        /// <value>
        /// common field name
        /// </value>
        [JsonProperty(PropertyName = "commonFieldName")]
        public string CommonFieldName { get; set; }
        
        /// <value>
        /// default match value
        /// </value>
        [JsonProperty(PropertyName = "defaultMatchValue")]
        public string DefaultMatchValue { get; set; }
        
        /// <value>
        /// display name
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// is common field
        /// </value>
        [JsonProperty(PropertyName = "isCommonField")]
        public System.Nullable<bool> IsCommonField { get; set; }
        
        /// <value>
        /// match operator
        /// </value>
        [JsonProperty(PropertyName = "matchOperator")]
        public string MatchOperator { get; set; }
        
        /// <value>
        /// name
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// position
        /// </value>
        [JsonProperty(PropertyName = "position")]
        public System.Nullable<long> Position { get; set; }
        
    }
}
