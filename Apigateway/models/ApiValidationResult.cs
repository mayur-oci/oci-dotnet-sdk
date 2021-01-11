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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// The result of single validation.
    /// </summary>
    public class ApiValidationResult 
    {
        
        /// <value>
        /// Name of the validation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// Result of the validation.
        /// </value>
        ///
        public enum ResultEnum {
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "OK")]
            Ok,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Result of the validation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Result is required.")]
        [JsonProperty(PropertyName = "result")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ResultEnum> Result { get; set; }
        
    }
}
