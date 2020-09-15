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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Details of Target ResponderRecipe
    /// </summary>
    public class TargetResponderRecipe 
    {
        
        /// <value>
        /// Unique identifier of TargetResponderRecipe that is immutable on creation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// Unique identifier for Responder Recipe of which this is an extension
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResponderRecipeId is required.")]
        [JsonProperty(PropertyName = "responderRecipeId")]
        public string ResponderRecipeId { get; set; }

        /// <value>
        /// Compartment Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// ResponderRecipe Identifier Name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// ResponderRecipe Description
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// Owner of ResponderRecipe
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Owner is required.")]
        [JsonProperty(PropertyName = "owner")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OwnerType> Owner { get; set; }

        /// <value>
        /// The date and time the target responder recipe rule was created. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The date and time the target responder recipe rule was updated. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }

        /// <value>
        /// List of responder rules associated with the recipe - user input
        /// </value>
        [JsonProperty(PropertyName = "responderRules")]
        public System.Collections.Generic.List<TargetResponderRecipeResponderRule> ResponderRules { get; set; }

        /// <value>
        /// List of responder rules associated with the recipe after applying all defaults
        /// </value>
        [JsonProperty(PropertyName = "effectiveResponderRules")]
        public System.Collections.Generic.List<TargetResponderRecipeResponderRule> EffectiveResponderRules { get; set; }
    }
}