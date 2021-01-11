/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DnsService.Models;

namespace Oci.DnsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dns/GetZoneRecords.cs.html">here</a> to see an example of how to use GetZoneRecords request.
    /// </example>
    public class GetZoneRecordsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The name or OCID of the target zone.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ZoneNameOrId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "zoneNameOrId")]
        public string ZoneNameOrId { get; set; }
        
        /// <value>
        /// The `If-None-Match` header field makes the request method conditional on
        /// the absence of any current representation of the target resource, when
        /// the field-value is `*`, or having a selected representation with an
        /// entity-tag that does not match any of those listed in the field-value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "If-None-Match")]
        public string IfNoneMatch { get; set; }
        
        /// <value>
        /// The `If-Modified-Since` header field makes a GET or HEAD request method
        /// conditional on the selected representation's modification date being more
        /// recent than the date provided in the field-value.  Transfer of the
        /// selected representation's data is avoided if that data has not changed.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "If-Modified-Since")]
        public string IfModifiedSince { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need
        /// to contact Oracle about a particular request, please provide
        /// the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a page of the collection.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<long> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The version of the zone for which data is requested.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "zoneVersion")]
        public string ZoneVersion { get; set; }
        
        /// <value>
        /// Search by domain.
        /// Will match any record whose domain (case-insensitive) equals the provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "domain")]
        public string Domain { get; set; }
        
        /// <value>
        /// Search by domain.
        /// Will match any record whose domain (case-insensitive) contains the provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "domainContains")]
        public string DomainContains { get; set; }
        
        /// <value>
        /// Search by record type.
        /// Will match any record whose [type](https://www.iana.org/assignments/dns-parameters/dns-parameters.xhtml#dns-parameters-4) (case-insensitive) equals the provided value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "rtype")]
        public string Rtype { get; set; }
        
        ///
        /// <value>
        /// The field by which to sort records.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "domain")]
            Domain,
            [EnumMember(Value = "rtype")]
            Rtype,
            [EnumMember(Value = "ttl")]
            Ttl
        };

        /// <value>
        /// The field by which to sort records.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The order to sort the resources.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        /// <value>
        /// The OCID of the compartment the resource belongs to.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Specifies to operate only on resources that have a matching DNS scope.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "scope")]
        public System.Nullable<Scope> Scope { get; set; }
        
        /// <value>
        /// The OCID of the view the resource is associated with.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "viewId")]
        public string ViewId { get; set; }
    }
}
