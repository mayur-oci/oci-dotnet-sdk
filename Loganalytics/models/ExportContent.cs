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
    /// ExportContent
    /// </summary>
    public class ExportContent 
    {
        
        /// <value>
        /// fieldNames
        /// </value>
        [JsonProperty(PropertyName = "fieldNames")]
        public System.Collections.Generic.List<string> FieldNames { get; set; }
        
        /// <value>
        /// parserNames
        /// </value>
        [JsonProperty(PropertyName = "parserNames")]
        public System.Collections.Generic.List<string> ParserNames { get; set; }
        
        /// <value>
        /// sourceNames
        /// </value>
        [JsonProperty(PropertyName = "sourceNames")]
        public System.Collections.Generic.List<string> SourceNames { get; set; }
        
    }
}
