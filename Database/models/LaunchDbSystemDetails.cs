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
    /// Used for creating a new DB system. Does not use backups or an existing database for the creation of the initial database.
    /// 
    /// </summary>
    public class LaunchDbSystemDetails : LaunchDbSystemBase
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbHome is required.")]
        [JsonProperty(PropertyName = "dbHome")]
        public CreateDbHomeDetails DbHome { get; set; }
                ///
        /// <value>
        /// The Oracle Database Edition that applies to all the databases on the DB system.
        /// Exadata DB systems and 2-node RAC DB systems require ENTERPRISE_EDITION_EXTREME_PERFORMANCE.
        /// 
        /// </value>
        ///
        public enum DatabaseEditionEnum {
            [EnumMember(Value = "STANDARD_EDITION")]
            StandardEdition,
            [EnumMember(Value = "ENTERPRISE_EDITION")]
            EnterpriseEdition,
            [EnumMember(Value = "ENTERPRISE_EDITION_HIGH_PERFORMANCE")]
            EnterpriseEditionHighPerformance,
            [EnumMember(Value = "ENTERPRISE_EDITION_EXTREME_PERFORMANCE")]
            EnterpriseEditionExtremePerformance
        };

        /// <value>
        /// The Oracle Database Edition that applies to all the databases on the DB system.
        /// Exadata DB systems and 2-node RAC DB systems require ENTERPRISE_EDITION_EXTREME_PERFORMANCE.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseEdition is required.")]
        [JsonProperty(PropertyName = "databaseEdition")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DatabaseEditionEnum> DatabaseEdition { get; set; }
                ///
        /// <value>
        /// The type of redundancy configured for the DB system.
        /// Normal is 2-way redundancy, recommended for test and development systems.
        /// High is 3-way redundancy, recommended for production systems.
        /// 
        /// </value>
        ///
        public enum DiskRedundancyEnum {
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "NORMAL")]
            Normal
        };

        /// <value>
        /// The type of redundancy configured for the DB system.
        /// Normal is 2-way redundancy, recommended for test and development systems.
        /// High is 3-way redundancy, recommended for production systems.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "diskRedundancy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DiskRedundancyEnum> DiskRedundancy { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to all the databases on the DB system. The default is LICENSE_INCLUDED.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to all the databases on the DB system. The default is LICENSE_INCLUDED.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindowDetails")]
        public MaintenanceWindow MaintenanceWindowDetails { get; set; }
        
        [JsonProperty(PropertyName = "source")]
        private readonly string source = "NONE";
    }
}
