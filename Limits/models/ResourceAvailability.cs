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


namespace Oci.LimitsService.Models
{
    /// <summary>
    /// The availability of a given resource limit, based on the usage, tenant service limits and quotas set for the tenancy.
    /// Note: We cannot guarantee this data for all the limits. In those cases, these fields will be empty.
    /// 
    /// </summary>
    public class ResourceAvailability 
    {
        
        /// <value>
        /// The current usage in the given compartment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "used")]
        public System.Nullable<long> Used { get; set; }

        /// <value>
        /// The count of available resources.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "available")]
        public System.Nullable<long> Available { get; set; }
    }
}