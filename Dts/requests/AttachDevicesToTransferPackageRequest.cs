/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DtsService.Models;

namespace Oci.DtsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dts/AttachDevicesToTransferPackage.cs.html">here</a> to see an example of how to use AttachDevicesToTransferPackage request.
    /// </example>
    public class AttachDevicesToTransferPackageRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// ID of the Transfer Job
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Label of the Transfer Package
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TransferPackageLabel is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "transferPackageLabel")]
        public string TransferPackageLabel { get; set; }
        
        /// <value>
        /// Labels of Transfer Devices to attach
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttachDevicesDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public AttachDevicesDetails AttachDevicesDetails { get; set; }
    }
}
