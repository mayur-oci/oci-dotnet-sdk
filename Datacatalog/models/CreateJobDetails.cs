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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Properties used to create a job.
    /// </summary>
    public class CreateJobDetails 
    {
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of the job.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Schedule specified in the cron expression format that has seven fields for second, minute, hour, day-of-month, month, day-of-week, year.
        /// It can also include special characters like * for all and ? for any. There are also pre-defined schedules that can be specified using
        /// special strings. For example, @hourly will run the job every hour.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scheduleCronExpression")]
        public string ScheduleCronExpression { get; set; }
        
        /// <value>
        /// Date that the schedule should be operational. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeScheduleBegin")]
        public System.Nullable<System.DateTime> TimeScheduleBegin { get; set; }
        
        /// <value>
        /// Date that the schedule should end from being operational. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeScheduleEnd")]
        public System.Nullable<System.DateTime> TimeScheduleEnd { get; set; }
        
        /// <value>
        /// The key of the connection used by the job. This connection will override the default connection specified in
        /// the associated job definition. All executions will use this connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionKey")]
        public string ConnectionKey { get; set; }
        
        /// <value>
        /// The unique key of the job definition that defined the scope of this job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobDefinitionKey is required.")]
        [JsonProperty(PropertyName = "jobDefinitionKey")]
        public string JobDefinitionKey { get; set; }
        
    }
}
