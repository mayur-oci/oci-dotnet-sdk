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


namespace Oci.CoreService.Models
{
    
    public class InstanceConfigurationInstanceSourceViaBootVolumeDetails : InstanceConfigurationInstanceSourceDetails
    {
        
        /// <value>
        /// The OCID of the boot volume used to boot the instance.
        /// </value>
        [JsonProperty(PropertyName = "bootVolumeId")]
        public string BootVolumeId { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "bootVolume";
    }
}
