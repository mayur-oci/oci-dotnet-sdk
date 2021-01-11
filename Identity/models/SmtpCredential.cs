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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// Simple Mail Transfer Protocol (SMTP) credentials are needed to send email through Email Delivery.
    /// The SMTP credentials are used for SMTP authentication with the service. The credentials never expire.
    /// A user can have up to 2 SMTP credentials at a time.
    /// <br/>
    /// **Note:** The credential set is always an Oracle-generated SMTP user name and password pair;
    /// you cannot designate the SMTP user name or the SMTP password.
    /// <br/>
    /// For more information, see [Managing User Credentials](https://docs.cloud.oracle.com/Content/Identity/Tasks/managingcredentials.htm#SMTP).
    /// 
    /// </summary>
    public class SmtpCredential 
    {
        
        /// <value>
        /// The SMTP user name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The SMTP password.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// The OCID of the SMTP credential.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the user the SMTP credential belongs to.
        /// </value>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        
        /// <value>
        /// The description you assign to the SMTP credential. Does not have to be unique, and it's changeable.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Date and time the `SmtpCredential` object was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Date and time when this credential will expire, in the format defined by RFC3339.
        /// Null if it never expires.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeExpires")]
        public System.Nullable<System.DateTime> TimeExpires { get; set; }
                ///
        /// <value>
        /// The credential's current state. After creating a SMTP credential, make sure its `lifecycleState` changes from
        /// CREATING to ACTIVE before using it.
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
        /// The credential's current state. After creating a SMTP credential, make sure its `lifecycleState` changes from
        /// CREATING to ACTIVE before using it.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The detailed status of INACTIVE lifecycleState.
        /// </value>
        [JsonProperty(PropertyName = "inactiveStatus")]
        public System.Nullable<long> InactiveStatus { get; set; }
        
    }
}
