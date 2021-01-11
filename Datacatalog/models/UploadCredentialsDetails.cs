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
    /// Upload credential file and connection metadata.
    /// </summary>
    public class UploadCredentialsDetails 
    {
        
        [JsonProperty(PropertyName = "connectionDetail")]
        public UpdateConnectionDetails ConnectionDetail { get; set; }
        
        /// <value>
        /// Information used in updating connection credentials.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CredentialPayload is required.")]
        [JsonProperty(PropertyName = "credentialPayload")]
        public System.Byte[] CredentialPayload { get; set; }
        
    }
}
