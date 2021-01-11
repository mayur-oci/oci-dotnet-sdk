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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsConfigWorkRequestSummary
    /// </summary>
    public class LogAnalyticsConfigWorkRequestSummary 
    {
        
        /// <value>
        /// workrequest id
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// compartment id
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// operation type
        /// </value>
        ///
        public enum OperationTypeEnum {
            [EnumMember(Value = "CREATE_ASSOCIATIONS")]
            CreateAssociations,
            [EnumMember(Value = "DELETE_ASSOCIATIONS")]
            DeleteAssociations
        };

        /// <value>
        /// operation type
        /// </value>
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
        
        /// <value>
        /// percentage complete
        /// </value>
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<long> PercentComplete { get; set; }
        
        /// <value>
        /// when the work request finished
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        /// <value>
        /// when the work request accepted
        /// </value>
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
                ///
        /// <value>
        /// status
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// status
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
    }
}
