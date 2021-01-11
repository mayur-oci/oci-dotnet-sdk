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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// SQL Plan details
    /// 
    /// </summary>
    public class SqlPlanSummary 
    {
        
        /// <value>
        /// Plan hash value for the SQL Execution Plan
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanHash is required.")]
        [JsonProperty(PropertyName = "planHash")]
        public System.Nullable<long> PlanHash { get; set; }
        
        /// <value>
        /// Plan XML Content
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanContent is required.")]
        [JsonProperty(PropertyName = "planContent")]
        public string PlanContent { get; set; }
        
    }
}
