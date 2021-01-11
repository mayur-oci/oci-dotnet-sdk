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
    /// A set of static public keys that will be used to verify the JWT signature.
    /// </summary>
    public class StaticPublicKeySet : PublicKeySet
    {
        
        /// <value>
        /// The set of static public keys.
        /// </value>
        [JsonProperty(PropertyName = "keys")]
        public System.Collections.Generic.List<StaticPublicKey> Keys { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "STATIC_KEYS";
    }
}
