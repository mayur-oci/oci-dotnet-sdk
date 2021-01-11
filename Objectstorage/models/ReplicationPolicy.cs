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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// The details of a replication policy.
    /// </summary>
    public class ReplicationPolicy 
    {
        
        /// <value>
        /// The id of the replication policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The destination region to replicate to, for example \"us-ashburn-1\".
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationRegionName is required.")]
        [JsonProperty(PropertyName = "destinationRegionName")]
        public string DestinationRegionName { get; set; }
        
        /// <value>
        /// The bucket to replicate to in the destination region. Replication policy creation does not automatically
        /// create a destination bucket. Create the destination bucket before creating the policy.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationBucketName is required.")]
        [JsonProperty(PropertyName = "destinationBucketName")]
        public string DestinationBucketName { get; set; }
        
        /// <value>
        /// The date when the replication policy was created as per [RFC 3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Changes made to the source bucket before this time has been replicated.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLastSync is required.")]
        [JsonProperty(PropertyName = "timeLastSync")]
        public System.Nullable<System.DateTime> TimeLastSync { get; set; }
                ///
        /// <value>
        /// The replication status of the policy. If the status is CLIENT_ERROR, once the user fixes the issue
        /// described in the status message, the status will become ACTIVE.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "CLIENT_ERROR")]
            ClientError
        };

        /// <value>
        /// The replication status of the policy. If the status is CLIENT_ERROR, once the user fixes the issue
        /// described in the status message, the status will become ACTIVE.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// A human-readable description of the status.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StatusMessage is required.")]
        [JsonProperty(PropertyName = "statusMessage")]
        public string StatusMessage { get; set; }
        
    }
}
