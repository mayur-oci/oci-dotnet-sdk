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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The details of a message.
    /// </summary>
    public class Message 
    {
                ///
        /// <value>
        /// The type of message (error, warning, or info).
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "INFO")]
            Info
        };

        /// <value>
        /// The type of message (error, warning, or info).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The message code.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Code is required.")]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        
        /// <value>
        /// The message text.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MessageProp is required.")]
        [JsonProperty(PropertyName = "message")]
        public string MessageProp { get; set; }
        
    }
}
