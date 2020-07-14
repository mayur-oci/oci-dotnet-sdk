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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Represents the load balancer Backend that is configured for an instance pool instance.
    /// </summary>
    public class InstancePoolInstanceLoadBalancerBackend 
    {
        
        /// <value>
        /// The OCID of the load balancer attached to the instance pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LoadBalancerId is required.")]
        [JsonProperty(PropertyName = "loadBalancerId")]
        public string LoadBalancerId { get; set; }

        /// <value>
        /// The name of the backend set on the load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackendSetName is required.")]
        [JsonProperty(PropertyName = "backendSetName")]
        public string BackendSetName { get; set; }

        /// <value>
        /// The name of the backend in the backend set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackendName is required.")]
        [JsonProperty(PropertyName = "backendName")]
        public string BackendName { get; set; }
        ///
        /// <value>
        /// The health of the backend as observed by the load balancer.
        /// </value>
        ///
        public enum BackendHealthStatusEnum {
            [EnumMember(Value = "OK")]
            Ok,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "CRITICAL")]
            Critical,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// The health of the backend as observed by the load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackendHealthStatus is required.")]
        [JsonProperty(PropertyName = "backendHealthStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BackendHealthStatusEnum> BackendHealthStatus { get; set; }
    }
}