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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Resource usage summation for the current time period
    /// </summary>
    public class SummarizeDatabaseInsightResourceUsageAggregation 
    {
        
        /// <value>
        /// The start timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalStart is required.")]
        [JsonProperty(PropertyName = "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }

        /// <value>
        /// The end timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalEnd is required.")]
        [JsonProperty(PropertyName = "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }
        ///
        /// <value>
        /// Defines the type of resource metric (CPU, STORAGE)
        /// 
        /// </value>
        ///
        public enum ResourceMetricEnum {
            [EnumMember(Value = "CPU")]
            Cpu,
            [EnumMember(Value = "STORAGE")]
            Storage
        };

        /// <value>
        /// Defines the type of resource metric (CPU, STORAGE)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceMetric is required.")]
        [JsonProperty(PropertyName = "resourceMetric")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ResourceMetricEnum> ResourceMetric { get; set; }

        /// <value>
        /// Displays usage unit (CORES, GB)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageUnit is required.")]
        [JsonProperty(PropertyName = "usageUnit")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UsageUnit> UsageUnit { get; set; }

        /// <value>
        /// Total amount used of the resource metric type (CPU, STORAGE).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Usage is required.")]
        [JsonProperty(PropertyName = "usage")]
        public System.Double Usage { get; set; }

        /// <value>
        /// The maximum allocated amount of the resource metric type  (CPU, STORAGE).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Capacity is required.")]
        [JsonProperty(PropertyName = "capacity")]
        public System.Double Capacity { get; set; }

        /// <value>
        /// Percentage change in resource usage during the current period calculated using linear regression functions
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageChangePercent is required.")]
        [JsonProperty(PropertyName = "usageChangePercent")]
        public System.Double UsageChangePercent { get; set; }
    }
}