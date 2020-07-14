/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CimsService.Models
{
    /// <summary>
    /// Details of Ticket Item
    /// </summary>
    public class CreateResourceDetails 
    {
        
        [JsonProperty(PropertyName = "item")]
        public CreateItemDetails Item { get; set; }

        /// <value>
        /// List of OCI regions
        /// </value>
        [JsonProperty(PropertyName = "region")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Region> Region { get; set; }

        /// <value>
        /// List of OCI ADs
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AvailabilityDomain> AvailabilityDomain { get; set; }
    }
}