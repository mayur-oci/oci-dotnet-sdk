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


namespace Oci.StreamingService.Models
{
    /// <summary>
    /// Optional parameters if a private stream pool is requested.
    /// </summary>
    public class PrivateEndpointDetails 
    {
        
        /// <value>
        /// If specified, the stream pool will be private and only accessible from inside that subnet.
        /// Producing-to and consuming-from a stream inside a private stream pool can also only be done from inside the subnet.
        /// That value cannot be changed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The optional private IP you want to be associated with your private stream pool.
        /// That parameter can only be specified when the subnetId parameter is set. It cannot be changed.
        /// The private IP needs to be part of the CIDR range of the specified subnetId or the creation will fail.
        /// If not specified a random IP inside the subnet will be chosen.
        /// After the stream pool is created, a custom FQDN, pointing to this private IP, is created.
        /// The FQDN is then used to access the service instead of the private IP.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointIp")]
        public string PrivateEndpointIp { get; set; }
        
        /// <value>
        /// The optional list of network security groups to be used with the private endpoint of the stream pool.
        /// That value cannot be changed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
    }
}
