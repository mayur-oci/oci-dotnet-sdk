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


namespace Oci.OceService.Models
{
    /// <summary>
    /// Details of OceInstance.
    /// </summary>
    public class OceInstance 
    {
        
        /// <value>
        /// Unique identifier that is immutable on creation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// Unique GUID identifier that is immutable on creation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Guid is required.")]
        [JsonProperty(PropertyName = "guid")]
        public string Guid { get; set; }

        /// <value>
        /// OceInstance description, can be updated
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// Compartment Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// OceInstance Name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// Tenancy Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenancyId is required.")]
        [JsonProperty(PropertyName = "tenancyId")]
        public string TenancyId { get; set; }

        /// <value>
        /// IDCS Tenancy Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdcsTenancy is required.")]
        [JsonProperty(PropertyName = "idcsTenancy")]
        public string IdcsTenancy { get; set; }

        /// <value>
        /// Tenancy Name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenancyName is required.")]
        [JsonProperty(PropertyName = "tenancyName")]
        public string TenancyName { get; set; }
        ///
        /// <value>
        /// Upgrade schedule type representing service to be upgraded immediately whenever latest version is released
        /// or delay upgrade of the service to previous released version
        /// 
        /// </value>
        ///
        public enum UpgradeScheduleEnum {
            [EnumMember(Value = "UPGRADE_IMMEDIATELY")]
            UpgradeImmediately,
            [EnumMember(Value = "DELAYED_UPGRADE")]
            DelayedUpgrade
        };

        /// <value>
        /// Upgrade schedule type representing service to be upgraded immediately whenever latest version is released
        /// or delay upgrade of the service to previous released version
        /// 
        /// </value>
        [JsonProperty(PropertyName = "upgradeSchedule")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UpgradeScheduleEnum> UpgradeSchedule { get; set; }

        [JsonProperty(PropertyName = "identityStripe")]
        public IdentityStripeDetails IdentityStripe { get; set; }
        ///
        /// <value>
        /// Instance type based on its usage
        /// </value>
        ///
        public enum InstanceUsageTypeEnum {
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "NONPRIMARY")]
            Nonprimary
        };

        /// <value>
        /// Instance type based on its usage
        /// </value>
        [JsonProperty(PropertyName = "instanceUsageType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InstanceUsageTypeEnum> InstanceUsageType { get; set; }

        /// <value>
        /// Object Storage Namespace of tenancy
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectStorageNamespace is required.")]
        [JsonProperty(PropertyName = "objectStorageNamespace")]
        public string ObjectStorageNamespace { get; set; }

        /// <value>
        /// Admin Email for Notification
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AdminEmail is required.")]
        [JsonProperty(PropertyName = "adminEmail")]
        public string AdminEmail { get; set; }

        /// <value>
        /// Web Application Firewall(WAF) primary domain
        /// </value>
        [JsonProperty(PropertyName = "wafPrimaryDomain")]
        public string WafPrimaryDomain { get; set; }
        ///
        /// <value>
        /// Flag indicating whether the instance access is private or public
        /// </value>
        ///
        public enum InstanceAccessTypeEnum {
            [EnumMember(Value = "PUBLIC")]
            Public,
            [EnumMember(Value = "PRIVATE")]
            Private
        };

        /// <value>
        /// Flag indicating whether the instance access is private or public
        /// </value>
        [JsonProperty(PropertyName = "instanceAccessType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InstanceAccessTypeEnum> InstanceAccessType { get; set; }

        /// <value>
        /// The time the the OceInstance was created. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The time the OceInstance was updated. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        ///
        /// <value>
        /// The current state of the file system.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the file system.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }

        /// <value>
        /// An message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "stateMessage")]
        public string StateMessage { get; set; }

        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }

        /// <value>
        /// SERVICE data.
        /// Example: {&quot;service&quot;: {&quot;IDCS&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "service")]
        public System.Collections.Generic.Dictionary<string, System.Object> Service { get; set; }
    }
}