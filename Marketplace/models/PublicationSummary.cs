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


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// The model for a summary of an Oracle Cloud Infrastructure publication
    /// </summary>
    public class PublicationSummary 
    {
        
        /// <value>
        /// the lifecycleState of the listing
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Publication.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The Compartment id where the listings exists
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The unique identifier for the listing in Marketplace.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the listing.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A short description of the listing.
        /// </value>
        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; set; }
        
        [JsonProperty(PropertyName = "icon")]
        public UploadData Icon { get; set; }
        
        /// <value>
        /// The listing's package type.
        /// </value>
        [JsonProperty(PropertyName = "packageType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PackageTypeEnum> PackageType { get; set; }
        
        /// <value>
        /// List of operating systems supprted.
        /// </value>
        [JsonProperty(PropertyName = "supportedOperatingSystems")]
        public System.Collections.Generic.List<OperatingSystem> SupportedOperatingSystems { get; set; }
        
        /// <value>
        /// In which catalog the listing should exist.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ListingType is required.")]
        [JsonProperty(PropertyName = "listingType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ListingType> ListingType { get; set; }
        
        /// <value>
        /// The date and time this publication was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}