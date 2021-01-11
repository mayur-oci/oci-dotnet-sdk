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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// This is used to specify runtime parameters for data entities such as files that need both the data entity and the format.
    /// </summary>
    public class EnrichedEntity 
    {
        
        [JsonProperty(PropertyName = "entity")]
        public DataEntity Entity { get; set; }
        
        [JsonProperty(PropertyName = "dataFormat")]
        public DataFormat DataFormat { get; set; }
        
    }
}
