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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Property details for uploading the specified compartment as the configuration source.
    /// 
    /// </summary>
    public class CreateCompartmentConfigSourceDetails : CreateConfigSourceDetails
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment to use for creating the stack.
        /// The new stack will include definitions for supported resource types in scope of the specified compartment OCID (tenancy level for root compartment, compartment level otherwise).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The region to use for creating the stack. The new stack will include definitions for
        /// supported resource types in this region.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Region is required.")]
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// Filter for [services to use with Resource Discovery](https://www.terraform.io/docs/providers/oci/guides/resource_discovery.html#services).
        /// For example, \"database\" limits resource discovery to resource types within the Database service.
        /// The specified services must be in scope of the given compartment OCID (tenancy level for root compartment, compartment level otherwise).
        /// If not specified, then all services at the scope of the given compartment OCID are used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "servicesToDiscover")]
        public System.Collections.Generic.List<string> ServicesToDiscover { get; set; }
        
        [JsonProperty(PropertyName = "configSourceType")]
        private readonly string configSourceType = "COMPARTMENT_CONFIG_SOURCE";
    }
}
