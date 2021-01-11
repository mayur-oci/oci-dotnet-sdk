/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabaseService.Models;

namespace Oci.DatabaseService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/database/GetAutonomousContainerDatabaseDataguardAssociation.cs.html">here</a> to see an example of how to use GetAutonomousContainerDatabaseDataguardAssociation request.
    /// </example>
    public class GetAutonomousContainerDatabaseDataguardAssociationRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Autonomous Container Database [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AutonomousContainerDatabaseId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "autonomousContainerDatabaseId")]
        public string AutonomousContainerDatabaseId { get; set; }
        
        /// <value>
        /// The Autonomous Container Database-Autonomous Data Guard association [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AutonomousContainerDatabaseDataguardAssociationId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "autonomousContainerDatabaseDataguardAssociationId")]
        public string AutonomousContainerDatabaseDataguardAssociationId { get; set; }
    }
}
