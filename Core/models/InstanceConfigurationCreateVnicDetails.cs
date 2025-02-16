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
    /// Contains the properties of the VNIC for an instance configuration. See {@link CreateVnicDetails}
    /// and [Instance Configurations](https://docs.cloud.oracle.com/iaas/Content/Compute/Concepts/instancemanagement.htm#config) for more information.
    /// 
    /// </summary>
    public class InstanceConfigurationCreateVnicDetails 
    {
        
        /// <value>
        /// Whether the VNIC should be assigned a public IP address. See the `assignPublicIp` attribute of {@link CreateVnicDetails}
        /// for more information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "assignPublicIp")]
        public System.Nullable<bool> AssignPublicIp { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name for the VNIC. Does not have to be unique.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The hostname for the VNIC's primary private IP.
        /// See the `hostnameLabel` attribute of {@link CreateVnicDetails} for more information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostnameLabel")]
        public string HostnameLabel { get; set; }
        
        /// <value>
        /// A list of the OCIDs of the network security groups (NSGs) to add the VNIC to. For more
        /// information about NSGs, see
        /// {@link NetworkSecurityGroup}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// A private IP address of your choice to assign to the VNIC.
        /// See the `privateIp` attribute of {@link CreateVnicDetails} for more information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateIp")]
        public string PrivateIp { get; set; }
        
        /// <value>
        /// Whether the source/destination check is disabled on the VNIC.
        /// See the `skipSourceDestCheck` attribute of {@link CreateVnicDetails} for more information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "skipSourceDestCheck")]
        public System.Nullable<bool> SkipSourceDestCheck { get; set; }
        
        /// <value>
        /// The OCID of the subnet to create the VNIC in.
        /// See the `subnetId` attribute of {@link CreateVnicDetails} for more information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
    }
}
