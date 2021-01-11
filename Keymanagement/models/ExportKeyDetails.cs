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
    /// <summary>
    /// The details of the key that you want to wrap and export.
    /// </summary>
    public class ExportKeyDetails 
    {
        
        /// <value>
        /// The OCID of the master encryption key associated with the key version you want to export.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyId is required.")]
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        
        /// <value>
        /// The OCID of the specific key version to export. If not specified, the service exports the current key version.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyVersionId")]
        public string KeyVersionId { get; set; }
                ///
        /// <value>
        /// The encryption algorithm to use to encrypt exportable key material from a software-backed key. Specifying `RSA_OAEP_AES_SHA256` 
        /// invokes the RSA AES key wrap mechanism, which generates a temporary AES key. The temporary AES key is wrapped by the RSA public 
        /// wrapping key provided along with the request, creating a wrapped temporary AES key. The temporary AES key is also used to wrap 
        /// the exportable key material. The wrapped temporary AES key and the wrapped exportable key material are concatenated, producing 
        /// concatenated blob output that jointly represents them. Specifying `RSA_OAEP_SHA256` means that the software key is wrapped by 
        /// the RSA public wrapping key provided along with the request.
        /// 
        /// </value>
        ///
        public enum AlgorithmEnum {
            [EnumMember(Value = "RSA_OAEP_AES_SHA256")]
            RsaOaepAesSha256,
            [EnumMember(Value = "RSA_OAEP_SHA256")]
            RsaOaepSha256
        };

        /// <value>
        /// The encryption algorithm to use to encrypt exportable key material from a software-backed key. Specifying `RSA_OAEP_AES_SHA256` 
        /// invokes the RSA AES key wrap mechanism, which generates a temporary AES key. The temporary AES key is wrapped by the RSA public 
        /// wrapping key provided along with the request, creating a wrapped temporary AES key. The temporary AES key is also used to wrap 
        /// the exportable key material. The wrapped temporary AES key and the wrapped exportable key material are concatenated, producing 
        /// concatenated blob output that jointly represents them. Specifying `RSA_OAEP_SHA256` means that the software key is wrapped by 
        /// the RSA public wrapping key provided along with the request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Algorithm is required.")]
        [JsonProperty(PropertyName = "algorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AlgorithmEnum> Algorithm { get; set; }
        
        /// <value>
        /// The PEM format of the 2048-bit, 3072-bit, or 4096-bit RSA wrapping key in your possession that you want to use to encrypt the key.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublicKey is required.")]
        [JsonProperty(PropertyName = "publicKey")]
        public string PublicKey { get; set; }
        
        /// <value>
        /// Information that provides context for audit logging. You can provide this additional
        /// data as key-value pairs to include in the audit logs when audit logging is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "loggingContext")]
        public System.Collections.Generic.Dictionary<string, string> LoggingContext { get; set; }
        
    }
}
