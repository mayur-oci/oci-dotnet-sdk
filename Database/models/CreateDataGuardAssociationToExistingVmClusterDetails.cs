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
    /// The configuration details for creating a Data Guard association for a ExaCC Vmcluster database. For these types of vm cluster databases, the `creationType` should be `ExistingVmCluster`. A standby database will be created in the VM cluster you specify.
    /// 
    /// </summary>
    public class CreateDataGuardAssociationToExistingVmClusterDetails : CreateDataGuardAssociationDetails
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VM Cluster in which to create the standby database.
        /// You must supply this value if creationType is `ExistingVmCluster`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "peerVmClusterId")]
        public string PeerVmClusterId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the DB home in which to create the standby database.
        /// You must supply this value to create standby database with an existing DB home
        /// 
        /// </value>
        [JsonProperty(PropertyName = "peerDbHomeId")]
        public string PeerDbHomeId { get; set; }
        
        [JsonProperty(PropertyName = "creationType")]
        private readonly string creationType = "ExistingVmCluster";
    }
}
