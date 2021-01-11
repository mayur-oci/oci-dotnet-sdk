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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// This is the input used to recall archived data
    /// 
    /// </summary>
    public class RecallArchivedDataDetails 
    {
        
        /// <value>
        /// This is the compartment OCID for permission checking
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// This is the end of the time interval
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeDataEnded is required.")]
        [JsonProperty(PropertyName = "timeDataEnded")]
        public System.Nullable<System.DateTime> TimeDataEnded { get; set; }
        
        /// <value>
        /// This is the start of the time interval
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeDataStarted is required.")]
        [JsonProperty(PropertyName = "timeDataStarted")]
        public System.Nullable<System.DateTime> TimeDataStarted { get; set; }
        
        /// <value>
        /// This is the type of the log data to be recalled
        /// </value>
        [JsonProperty(PropertyName = "dataType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StorageDataType> DataType { get; set; }
        
    }
}
