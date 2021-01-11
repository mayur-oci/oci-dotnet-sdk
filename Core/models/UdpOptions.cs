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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Optional object to specify ports for a UDP rule. If you specify UDP as the
    /// protocol but omit this object, then all ports are allowed.
    /// 
    /// </summary>
    public class UdpOptions 
    {
        
        /// <value>
        /// An inclusive range of allowed destination ports. Use the same number for the min and max
        /// to indicate a single port. Defaults to all ports if not specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "destinationPortRange")]
        public PortRange DestinationPortRange { get; set; }
        
        /// <value>
        /// An inclusive range of allowed source ports. Use the same number for the min and max to
        /// indicate a single port. Defaults to all ports if not specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourcePortRange")]
        public PortRange SourcePortRange { get; set; }
        
    }
}
