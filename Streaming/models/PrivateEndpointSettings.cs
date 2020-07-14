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


namespace Oci.StreamingService.Models
{
    /// <summary>
    /// Optional settings if the stream pool is private.
    /// </summary>
    public class PrivateEndpointSettings 
    {
        
        /// <value>
        /// The subnet id from which the private stream pool can be accessed.
        /// Trying to access the streams from another network location will result in an error.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <value>
        /// The private IP associated with the stream pool in the associated subnetId.
        /// The stream pool's FQDN resolves to that IP and should be used - instead of the private IP - in order to not trigger any TLS issues.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointIp")]
        public string PrivateEndpointIp { get; set; }

        /// <value>
        /// The optional list of network security groups that are associated with the private endpoint of the stream pool.
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
    }
}