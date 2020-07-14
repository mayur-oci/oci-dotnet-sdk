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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// A single route that forwards requests to a particular backend and may contain some additional policies.
    /// 
    /// </summary>
    public class ApiSpecificationRoute 
    {
        
        /// <value>
        /// A URL path pattern that must be matched on this route. The path pattern may contain a subset of RFC 6570 identifiers
        /// to allow wildcard and parameterized matching.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Path is required.")]
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        ///
        ///
        public enum MethodsEnum {
            [EnumMember(Value = "ANY")]
            Any,
            [EnumMember(Value = "HEAD")]
            Head,
            [EnumMember(Value = "GET")]
            Get,
            [EnumMember(Value = "POST")]
            Post,
            [EnumMember(Value = "PUT")]
            Put,
            [EnumMember(Value = "PATCH")]
            Patch,
            [EnumMember(Value = "DELETE")]
            Delete,
            [EnumMember(Value = "OPTIONS")]
            Options
        };

        /// <value>
        /// A list of allowed methods on this route.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "methods", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<MethodsEnum> Methods { get; set; }

        [JsonProperty(PropertyName = "requestPolicies")]
        public ApiSpecificationRouteRequestPolicies RequestPolicies { get; set; }

        [JsonProperty(PropertyName = "loggingPolicies")]
        public ApiSpecificationLoggingPolicies LoggingPolicies { get; set; }

        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Backend is required.")]
        [JsonProperty(PropertyName = "backend")]
        public ApiSpecificationRouteBackend Backend { get; set; }
    }
}