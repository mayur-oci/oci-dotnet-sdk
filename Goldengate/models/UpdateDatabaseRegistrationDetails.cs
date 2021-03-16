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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The information to update for a DatabaseRegistration.
    /// 
    /// </summary>
    public class UpdateDatabaseRegistrationDetails 
    {
        
        /// <value>
        /// An object's Display Name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Metadata about this specific object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// A simple key-value pair that is applied without any predefined name, type, or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Tags defined for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A three-label Fully Qualified Domain Name (FQDN) for a resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }
        
        /// <value>
        /// The username Oracle GoldenGate uses to connect the associated RDBMS.  This username must already exist and be available for use by the database.  It must conform to the security requirements implemented by the database including length, case sensitivity, and so on.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The password Oracle GoldenGate uses to connect the associated RDBMS.  It must conform to the specific security requirements implemented by the database including length, case sensitivity, and so on.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// Connect descriptor or Easy Connect Naming method that Oracle GoldenGate uses to connect to a database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
        
        /// <value>
        /// The wallet contents Oracle GoldenGate uses to make connections to a database.  This attribute is expected to be base64 encoded.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "wallet")]
        public string Wallet { get; set; }
        
        /// <value>
        /// Credential store alias.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "aliasName")]
        public string AliasName { get; set; }
        
    }
}