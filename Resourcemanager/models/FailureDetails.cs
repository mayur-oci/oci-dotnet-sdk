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
    
    public class FailureDetails 
    {
                ///
        /// <value>
        /// Job failure reason.
        /// </value>
        ///
        public enum CodeEnum {
            [EnumMember(Value = "INTERNAL_SERVICE_ERROR")]
            InternalServiceError,
            [EnumMember(Value = "TERRAFORM_EXECUTION_ERROR")]
            TerraformExecutionError,
            [EnumMember(Value = "TERRAFORM_CONFIG_UNZIP_FAILED")]
            TerraformConfigUnzipFailed,
            [EnumMember(Value = "INVALID_WORKING_DIRECTORY")]
            InvalidWorkingDirectory,
            [EnumMember(Value = "JOB_TIMEOUT")]
            JobTimeout,
            [EnumMember(Value = "TERRAFORM_CONFIG_VIRUS_FOUND")]
            TerraformConfigVirusFound,
            [EnumMember(Value = "TERRAFORM_GIT_CLONE_FAILURE")]
            TerraformGitCloneFailure,
            [EnumMember(Value = "TERRAFORM_GIT_CHECKOUT_FAILURE")]
            TerraformGitCheckoutFailure
        };

        /// <value>
        /// Job failure reason.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Code is required.")]
        [JsonProperty(PropertyName = "code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CodeEnum> Code { get; set; }
        
        /// <value>
        /// A human-readable error string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Message is required.")]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
    }
}
