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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The information about additionaly added nodes
    /// </summary>
    public class ChangeShapeDetails 
    {
        
        /// <value>
        /// Base-64 encoded password for Cloudera Manager admin user
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterAdminPassword is required.")]
        [JsonProperty(PropertyName = "clusterAdminPassword")]
        public string ClusterAdminPassword { get; set; }

        /// <value>
        /// Inidividial worker nodes groups details
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Nodes is required.")]
        [JsonProperty(PropertyName = "nodes")]
        public ChangeShapeNodes Nodes { get; set; }
    }
}
