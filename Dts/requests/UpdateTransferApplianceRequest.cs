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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dts/UpdateTransferAppliance.cs.html">here</a> to see an example of how to use UpdateTransferAppliance request.
    /// </example>
    public class UpdateTransferApplianceRequest : Oci.Common.IOciRequest
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
        /// Label of the Transfer Appliance
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TransferApplianceLabel is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "transferApplianceLabel")]
        public string TransferApplianceLabel { get; set; }
        
        /// <value>
        /// fields to update
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateTransferApplianceDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public UpdateTransferApplianceDetails UpdateTransferApplianceDetails { get; set; }
        
        /// <value>
        /// The entity tag to match. Optional, if set, the update will be successful only if the
        /// object's tag matches the tag specified in the request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
    }
}
