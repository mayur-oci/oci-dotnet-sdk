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


namespace Oci.EmailService.Models
{
    /// <summary>
    /// The details needed for creating a single suppression.
    /// </summary>
    public class CreateSuppressionDetails 
    {
        
        /// <value>
        /// The OCID of the compartment to contain the suppression. Since
        /// suppressions are at the customer level, this must be the tenancy
        /// OCID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The recipient email address of the suppression.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EmailAddress is required.")]
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }
        
    }
}
