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
    /// Information about a single tunnel in an IPSec connection. This object does not include the tunnel's
    /// shared secret (pre-shared key). That is in the
    /// {@link IPSecConnectionTunnelSharedSecret} object.
    /// 
    /// </summary>
    public class IPSecConnectionTunnel 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment containing the tunnel.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the tunnel.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The IP address of Oracle's VPN headend.
        /// <br/>
        /// Example: 203.0.113.21
        /// </value>
        [JsonProperty(PropertyName = "vpnIp")]
        public string VpnIp { get; set; }
        
        /// <value>
        /// The IP address of the CPE's VPN headend.
        /// <br/>
        /// Example: 203.0.113.22
        /// </value>
        [JsonProperty(PropertyName = "cpeIp")]
        public string CpeIp { get; set; }
                ///
        /// <value>
        /// The status of the tunnel based on IPSec protocol characteristics.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "UP")]
            Up,
            [EnumMember(Value = "DOWN")]
            Down,
            [EnumMember(Value = "DOWN_FOR_MAINTENANCE")]
            DownForMaintenance
        };

        /// <value>
        /// The status of the tunnel based on IPSec protocol characteristics.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
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
                ///
        /// <value>
        /// The tunnel's lifecycle state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated
        };

        /// <value>
        /// The tunnel's lifecycle state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid
        /// entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Information for establishing the tunnel's BGP session.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bgpSessionInfo")]
        public BgpSessionInfo BgpSessionInfo { get; set; }
                ///
        /// <value>
        /// The type of routing used for this tunnel (either BGP dynamic routing or static routing).
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
        /// The type of routing used for this tunnel (either BGP dynamic routing or static routing).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routing")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RoutingEnum> Routing { get; set; }
        
        /// <value>
        /// The date and time the IPSec connection tunnel was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// When the status of the tunnel last changed, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeStatusUpdated")]
        public System.Nullable<System.DateTime> TimeStatusUpdated { get; set; }
        
    }
}
