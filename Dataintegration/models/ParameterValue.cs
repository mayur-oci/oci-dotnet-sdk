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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// A parameter value.
    /// </summary>
    public class ParameterValue 
    {
        
        /// <value>
        /// A simple value for the parameter.
        /// </value>
        [JsonProperty(PropertyName = "simpleValue")]
        public System.Object SimpleValue { get; set; }

        /// <value>
        /// This can be any object such as a file entity, or a schema or a table.
        /// </value>
        [JsonProperty(PropertyName = "rootObjectValue")]
        public System.Object RootObjectValue { get; set; }
    }
}