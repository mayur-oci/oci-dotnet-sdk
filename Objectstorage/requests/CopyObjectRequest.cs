/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/objectstorage/CopyObject.cs.html">here</a> to see an example of how to use CopyObject request.
    /// </example>
    public class CopyObjectRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Object Storage namespace used for the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// The name of the bucket. Avoid entering confidential information.
        /// Example: my-new-bucket1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// The source and destination of the object to be copied.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CopyObjectDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public CopyObjectDetails CopyObjectDetails { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }
        
        /// <value>
        /// The optional header that specifies \"AES256\" as the encryption algorithm. For more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-sse-customer-algorithm")]
        public string OpcSseCustomerAlgorithm { get; set; }
        
        /// <value>
        /// The optional header that specifies the base64-encoded 256-bit encryption key to use to encrypt or
        /// decrypt the data. For more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-sse-customer-key")]
        public string OpcSseCustomerKey { get; set; }
        
        /// <value>
        /// The optional header that specifies the base64-encoded SHA256 hash of the encryption key. This
        /// value is used to check the integrity of the encryption key. For more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-sse-customer-key-sha256")]
        public string OpcSseCustomerKeySha256 { get; set; }
        
        /// <value>
        /// The optional header that specifies \"AES256\" as the encryption algorithm to use to decrypt the source
        /// object. For more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-source-sse-customer-algorithm")]
        public string OpcSourceSseCustomerAlgorithm { get; set; }
        
        /// <value>
        /// The optional header that specifies the base64-encoded 256-bit encryption key to use to decrypt
        /// the source object. For more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-source-sse-customer-key")]
        public string OpcSourceSseCustomerKey { get; set; }
        
        /// <value>
        /// The optional header that specifies the base64-encoded SHA256 hash of the encryption key used to
        /// decrypt the source object. This value is used to check the integrity of the encryption key. For
        /// more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-source-sse-customer-key-sha256")]
        public string OpcSourceSseCustomerKeySha256 { get; set; }
    }
}
