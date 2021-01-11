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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Properties used in pattern update operations.
    /// </summary>
    public class UpdatePatternDetails 
    {
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of the Pattern.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The expression used in the pattern that may include qualifiers. Refer to the user documentation for details of the format and examples.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "expression")]
        public string Expression { get; set; }
        
        /// <value>
        /// List of file paths against which the expression can be tried, as a check. This documents, for reference
        /// purposes, some example objects a pattern is meant to work with. If isEnableCheckFailureLimit is set to true,
        /// this will be run as a validation during the request, such that if the check fails the request fails. If
        /// isEnableCheckFailureLimit instead is set to (the default) false, a pattern will still be created or updated even
        /// if the check fails, with a lifecycleState of FAILED.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "checkFilePathList")]
        public System.Collections.Generic.List<string> CheckFilePathList { get; set; }
        
        /// <value>
        /// Indicates whether the expression check, against the checkFilePathList, will fail the request if the count of
        /// UNMATCHED files is above the checkFailureLimit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEnableCheckFailureLimit")]
        public System.Nullable<bool> IsEnableCheckFailureLimit { get; set; }
        
        /// <value>
        /// The maximum number of UNMATCHED files, in checkFilePathList, above which the check fails. Optional, if
        /// checkFilePathList is provided - but if isEnableCheckFailureLimit is set to true it is required.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "checkFailureLimit")]
        public System.Nullable<int> CheckFailureLimit { get; set; }
        
        /// <value>
        /// A map of maps that contains the properties which are specific to the pattern type. Each pattern type
        /// definition defines it's set of required and optional properties.
        /// Example: {&quot;properties&quot;: { &quot;default&quot;: { &quot;tbd&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }
        
    }
}
