/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.EventsService.Models;

namespace Oci.EventsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/events/ListRules.cs.html">here</a> to see an example of how to use ListRules request.
    /// </example>
    public class ListRulesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment to which this rule belongs.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The maximum number of items to return. 1 is the minimum, 50 is the maximum.
        /// Default: 10
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The value of the opc-next-page response header from the previous
        /// \"List\" call. For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// A filter to return only rules that match the lifecycle state in this parameter.
        /// <br/>
        /// Example: Creating
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<Rule.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A filter to return only rules with descriptions that match the displayName string
        /// in this parameter.
        /// <br/>
        /// Example: &quot;This rule sends a notification upon completion of DbaaS backup.&quot;
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        ///
        /// <value>
        /// Specifies the attribute with which to sort the rules.
        /// <br/>
        /// Default: `timeCreated`
        /// <br/>
        /// * **TIME_CREATED:** Sorts by timeCreated.
        /// * **DISPLAY_NAME:** Sorts by displayName.
        /// * **ID:** Sorts by id.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIME_CREATED")]
            TimeCreated,
            [EnumMember(Value = "ID")]
            Id,
            [EnumMember(Value = "DISPLAY_NAME")]
            DisplayName
        };

        /// <value>
        /// Specifies the attribute with which to sort the rules.
        /// <br/>
        /// Default: `timeCreated`
        /// <br/>
        /// * **TIME_CREATED:** Sorts by timeCreated.
        /// * **DISPLAY_NAME:** Sorts by displayName.
        /// * **ID:** Sorts by id.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// Specifies sort order.
        /// <br/>
        /// * **ASC:** Ascending sort order.
        /// * **DESC:** Descending sort order.
        /// 
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// Specifies sort order.
        /// <br/>
        /// * **ASC:** Ascending sort order.
        /// * **DESC:** Descending sort order.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
