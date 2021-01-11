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


namespace Oci.ApplicationmigrationService.Models
{
    /// <summary>
    /// Credentials to access the Oracle SOA Cloud Service application in the source environment. When you create and update a migration,
    /// Application Migration connects to the application in the source environment with the supplied credentials and exports the domain
    /// configuration.
    /// 
    /// </summary>
    public class SoacsDiscoveryDetails : DiscoveryDetails
    {
        
        /// <value>
        /// WebLogic administrator username for the Oracle SOA Cloud Service application in the source environment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WeblogicUser is required.")]
        [JsonProperty(PropertyName = "weblogicUser")]
        public string WeblogicUser { get; set; }
        
        /// <value>
        /// Password for this user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WeblogicPassword is required.")]
        [JsonProperty(PropertyName = "weblogicPassword")]
        public string WeblogicPassword { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SOACS";
    }
}
