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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Candidate Responder Rule list in Detector rule
    /// </summary>
    public class CandidateResponderRule 
    {
        
        /// <value>
        /// The unique identifier of the Responder rule
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The display name of the Responder rule
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Preferred state
        /// </value>
        [JsonProperty(PropertyName = "isPreferred")]
        public System.Nullable<bool> IsPreferred { get; set; }
        
    }
}
