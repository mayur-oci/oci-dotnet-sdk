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
    /// UiParserTestMetadata
    /// </summary>
    public class UiParserTestMetadata 
    {
        
        /// <value>
        /// Last modified time
        /// </value>
        [JsonProperty(PropertyName = "lastModifiedTime")]
        public string LastModifiedTime { get; set; }
        
        /// <value>
        /// Name of log file
        /// </value>
        [JsonProperty(PropertyName = "logFileName")]
        public string LogFileName { get; set; }
        
        /// <value>
        /// timeZone
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public System.Nullable<System.DateTime> TimeZone { get; set; }
        
    }
}
