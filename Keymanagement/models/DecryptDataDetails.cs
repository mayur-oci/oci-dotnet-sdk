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


namespace Oci.KeymanagementService.Models
{
    
    public class DecryptDataDetails 
    {
        
        /// <value>
        /// Information that can be used to provide an encryption context for the encrypted data.
        /// The length of the string representation of the associated data must be fewer than 4096 characters.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "associatedData")]
        public System.Collections.Generic.Dictionary<string, string> AssociatedData { get; set; }
        
        /// <value>
        /// The encrypted data to decrypt.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ciphertext is required.")]
        [JsonProperty(PropertyName = "ciphertext")]
        public string Ciphertext { get; set; }
        
        /// <value>
        /// The OCID of the key used to encrypt the ciphertext.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyId is required.")]
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        
        /// <value>
        /// Information that provides context for audit logging. You can provide this additional
        /// data as key-value pairs to include in audit logs when audit logging is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "loggingContext")]
        public System.Collections.Generic.Dictionary<string, string> LoggingContext { get; set; }
        
    }
}
