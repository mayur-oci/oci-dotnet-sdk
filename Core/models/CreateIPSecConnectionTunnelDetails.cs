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
    
    public class CreateIPSecConnectionTunnelDetails 
    {
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid
        /// entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The type of routing to use for this tunnel (either BGP dynamic routing or static routing).
        /// 
        /// </value>
        ///
        public enum RoutingEnum {
            [EnumMember(Value = "BGP")]
            Bgp,
            [EnumMember(Value = "STATIC")]
            Static
        };

        /// <value>
        /// The type of routing to use for this tunnel (either BGP dynamic routing or static routing).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routing")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RoutingEnum> Routing { get; set; }
                ///
        /// <value>
        /// Internet Key Exchange protocol version.
        /// 
        /// </value>
        ///
        public enum IkeVersionEnum {
            [EnumMember(Value = "V1")]
            V1,
            [EnumMember(Value = "V2")]
            V2
        };

        /// <value>
        /// Internet Key Exchange protocol version.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ikeVersion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IkeVersionEnum> IkeVersion { get; set; }
        
        /// <value>
        /// The shared secret (pre-shared key) to use for the IPSec tunnel. Only numbers, letters, and
        /// spaces are allowed. If you don't provide a value,
        /// Oracle generates a value for you. You can specify your own shared secret later if
        /// you like with {@link #updateIPSecConnectionTunnelSharedSecret(UpdateIPSecConnectionTunnelSharedSecretRequest) updateIPSecConnectionTunnelSharedSecret}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sharedSecret")]
        public string SharedSecret { get; set; }
        
        [JsonProperty(PropertyName = "bgpSessionConfig")]
        public CreateIPSecTunnelBgpSessionDetails BgpSessionConfig { get; set; }
        
    }
}
