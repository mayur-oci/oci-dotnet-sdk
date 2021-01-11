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
    /// A virtual cloud network (VCN). For more information, see
    /// [Overview of the Networking Service](https://docs.cloud.oracle.com/Content/Network/Concepts/overview.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you
    /// supply string values using the API.
    /// 
    /// </summary>
    public class Vcn 
    {
        
        /// <value>
        /// Deprecated. The first CIDR IP address from cidrBlocks.
        /// <br/>
        /// Example: 172.16.0.0/16
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CidrBlock is required.")]
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }
        
        /// <value>
        /// The list of IPv4 CIDR blocks the VCN will use.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CidrBlocks is required.")]
        [JsonProperty(PropertyName = "cidrBlocks")]
        public System.Collections.Generic.List<string> CidrBlocks { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the VCN.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID for the VCN's default set of DHCP options.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "defaultDhcpOptionsId")]
        public string DefaultDhcpOptionsId { get; set; }
        
        /// <value>
        /// The OCID for the VCN's default route table.
        /// </value>
        [JsonProperty(PropertyName = "defaultRouteTableId")]
        public string DefaultRouteTableId { get; set; }
        
        /// <value>
        /// The OCID for the VCN's default security list.
        /// </value>
        [JsonProperty(PropertyName = "defaultSecurityListId")]
        public string DefaultSecurityListId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A DNS label for the VCN, used in conjunction with the VNIC's hostname and
        /// subnet's DNS label to form a fully qualified domain name (FQDN) for each VNIC
        /// within this subnet (for example, `bminstance-1.subnet123.vcn1.oraclevcn.com`).
        /// Must be an alphanumeric string that begins with a letter.
        /// The value cannot be changed.
        /// <br/>
        /// The absence of this parameter means the Internet and VCN Resolver will
        /// not work for this VCN.
        /// <br/>
        /// For more information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// Example: vcn1
        /// </value>
        [JsonProperty(PropertyName = "dnsLabel")]
        public string DnsLabel { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The VCN's Oracle ID (OCID).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// For an IPv6-enabled VCN, this is the IPv6 CIDR block for the VCN's private IP address space.
        /// The VCN size is always /48. If you don't provide a value when creating the VCN, Oracle
        /// provides one and uses that *same* CIDR for the `ipv6PublicCidrBlock`. If you do provide a
        /// value, Oracle provides a *different* CIDR for the `ipv6PublicCidrBlock`. Note that IPv6
        /// addressing is currently supported only in certain regions. See
        /// [IPv6 Addresses](https://docs.cloud.oracle.com/Content/Network/Concepts/ipv6.htm).
        /// <br/>
        /// Example: 2001:0db8:0123::/48
        /// </value>
        [JsonProperty(PropertyName = "ipv6CidrBlock")]
        public string Ipv6CidrBlock { get; set; }
        
        /// <value>
        /// For an IPv6-enabled VCN, this is the IPv6 CIDR block for the VCN's public IP address space.
        /// The VCN size is always /48. This CIDR is always provided by Oracle. If you don't provide a
        /// custom CIDR for the `ipv6CidrBlock` when creating the VCN, Oracle assigns that value and also
        /// uses it for `ipv6PublicCidrBlock`. Oracle uses addresses from this block for the `publicIpAddress`
        /// attribute of an {@link Ipv6} that has internet access allowed.
        /// <br/>
        /// Example: 2001:0db8:0123::/48
        /// </value>
        [JsonProperty(PropertyName = "ipv6PublicCidrBlock")]
        public string Ipv6PublicCidrBlock { get; set; }
                ///
        /// <value>
        /// The VCN's current state.
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
            Terminated,
            [EnumMember(Value = "UPDATING")]
            Updating
        };

        /// <value>
        /// The VCN's current state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the VCN was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The VCN's domain name, which consists of the VCN's DNS label, and the
        /// `oraclevcn.com` domain.
        /// <br/>
        /// For more information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// Example: vcn1.oraclevcn.com
        /// </value>
        [JsonProperty(PropertyName = "vcnDomainName")]
        public string VcnDomainName { get; set; }
        
    }
}
