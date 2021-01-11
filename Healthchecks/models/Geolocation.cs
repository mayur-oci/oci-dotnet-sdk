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


namespace Oci.HealthchecksService.Models
{
    /// <summary>
    /// Geographic information about a vantage point.
    /// </summary>
    public class Geolocation 
    {
        
        /// <value>
        /// An opaque identifier for the geographic location of the vantage point.
        /// </value>
        [JsonProperty(PropertyName = "geoKey")]
        public string GeoKey { get; set; }
        
        /// <value>
        /// The ISO 3166-2 code for this location's first-level administrative
        /// division, either a US state or Canadian province. Only included for locations
        /// in the US or Canada. For a list of codes, see
        /// [Country Codes](https://www.iso.org/obp/ui/#search).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "adminDivCode")]
        public string AdminDivCode { get; set; }
        
        /// <value>
        /// Common English-language name for the city.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cityName")]
        public string CityName { get; set; }
        
        /// <value>
        /// The ISO 3166-1 alpha-2 country code. For a list of codes,
        /// see [Country Codes](https://www.iso.org/obp/ui/#search).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }
        
        /// <value>
        /// The common English-language name for the country.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "countryName")]
        public string CountryName { get; set; }
        
        /// <value>
        /// Degrees north of the Equator.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "latitude")]
        public System.Nullable<float> Latitude { get; set; }
        
        /// <value>
        /// Degrees east of the prime meridian.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "longitude")]
        public System.Nullable<float> Longitude { get; set; }
        
    }
}
