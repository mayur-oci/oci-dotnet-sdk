/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CoreService.Models
{
    /// <summary>
    /// For a flexible shape, the number of VNIC attachments that are available for instances that use this shape.
    /// <br/>
    /// If this field is null, then this shape has a fixed maximum number of VNIC attachments equal to `maxVnicAttachments`.
    /// 
    /// </summary>
    public class ShapeMaxVnicAttachmentOptions 
    {
        
        /// <value>
        /// The lowest maximum value of VNIC attachments.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "min")]
        public System.Nullable<int> Min { get; set; }

        /// <value>
        /// The highest maximum value of VNIC attachments.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "max")]
        public System.Nullable<float> Max { get; set; }

        /// <value>
        /// The default number of VNIC attachments allowed per OCPU.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "defaultPerOcpu")]
        public System.Nullable<float> DefaultPerOcpu { get; set; }
    }
}