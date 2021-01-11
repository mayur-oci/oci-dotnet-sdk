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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of Database Software Image for upgrading a database.
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class DatabaseUpgradeWithDatabaseSoftwareImageDetails : DatabaseUpgradeSourceBase
    {
        
        /// <value>
        /// the database software id used for upgrading the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseSoftwareImageId is required.")]
        [JsonProperty(PropertyName = "databaseSoftwareImageId")]
        public string DatabaseSoftwareImageId { get; set; }
        
        [JsonProperty(PropertyName = "source")]
        private readonly string source = "DB_SOFTWARE_IMAGE";
    }
}
