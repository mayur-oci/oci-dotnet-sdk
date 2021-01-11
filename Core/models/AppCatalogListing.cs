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
    /// <summary>
    /// Listing details.
    /// </summary>
    public class AppCatalogListing 
    {
        
        /// <value>
        /// Listing's contact URL.
        /// </value>
        [JsonProperty(PropertyName = "contactUrl")]
        public string ContactUrl { get; set; }
        
        /// <value>
        /// Description of the listing.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The OCID of the listing.
        /// </value>
        [JsonProperty(PropertyName = "listingId")]
        public string ListingId { get; set; }
        
        /// <value>
        /// Name of the listing.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Date and time the listing was published, in [RFC3339](https://tools.ietf.org/html/rfc3339) format.
        /// Example: 2018-03-20T12:32:53.532Z
        /// </value>
        [JsonProperty(PropertyName = "timePublished")]
        public System.Nullable<System.DateTime> TimePublished { get; set; }
        
        /// <value>
        /// Publisher's logo URL.
        /// </value>
        [JsonProperty(PropertyName = "publisherLogoUrl")]
        public string PublisherLogoUrl { get; set; }
        
        /// <value>
        /// Name of the publisher who published this listing.
        /// </value>
        [JsonProperty(PropertyName = "publisherName")]
        public string PublisherName { get; set; }
        
        /// <value>
        /// Summary of the listing.
        /// </value>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
        
    }
}
