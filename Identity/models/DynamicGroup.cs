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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// A dynamic group defines a matching rule. Every bare metal or virtual machine instance is deployed with an instance certificate.
    /// The certificate contains metadata about the instance. This includes the instance OCID and the compartment OCID, along
    /// with a few other optional properties. When an API call is made using this instance certificate as the authenticator,
    /// the certificate can be matched to one or multiple dynamic groups. The instance can then get access to the API
    /// based on the permissions granted in policies written for the dynamic groups.
    /// <br/>
    /// This works like regular user/group membership. But in that case, the membership is a static relationship, whereas
    /// in a dynamic group, the membership of an instance certificate to a dynamic group is determined during runtime.
    /// For more information, see [Managing Dynamic Groups](https://docs.cloud.oracle.com/Content/Identity/Tasks/managingdynamicgroups.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using 
    /// the API.
    /// 
    /// </summary>
    public class DynamicGroup 
    {
        
        /// <value>
        /// The OCID of the group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// The OCID of the tenancy containing the group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The name you assign to the group during creation. The name must be unique across all groups in
        /// the tenancy and cannot be changed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// The description you assign to the group. Does not have to be unique, and it's changeable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// A rule string that defines which instance certificates will be matched.
        /// For syntax, see [Managing Dynamic Groups](https://docs.cloud.oracle.com/Content/Identity/Tasks/managingdynamicgroups.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MatchingRule is required.")]
        [JsonProperty(PropertyName = "matchingRule")]
        public string MatchingRule { get; set; }

        /// <value>
        /// Date and time the group was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        ///
        /// <value>
        /// The group's current state. After creating a group, make sure its `lifecycleState` changes from CREATING to
        /// ACTIVE before using it.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The group's current state. After creating a group, make sure its `lifecycleState` changes from CREATING to
        /// ACTIVE before using it.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }

        /// <value>
        /// The detailed status of INACTIVE lifecycleState.
        /// </value>
        [JsonProperty(PropertyName = "inactiveStatus")]
        public System.Nullable<long> InactiveStatus { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
    }
}