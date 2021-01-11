/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CoreService.Models;

namespace Oci.CoreService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/core/GetAppCatalogListingAgreements.cs.html">here</a> to see an example of how to use GetAppCatalogListingAgreements request.
    /// </example>
    public class GetAppCatalogListingAgreementsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the listing.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ListingId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "listingId")]
        public string ListingId { get; set; }
        
        /// <value>
        /// Listing Resource Version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceVersion is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "resourceVersion")]
        public string ResourceVersion { get; set; }
    }
}
