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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// The device fingerprint challenge settings. The device fingerprint challenge generates hashed signatures of both virtual and real browsers to identify and block malicious bots.
    /// </summary>
    public class DeviceFingerprintChallenge 
    {
        
        /// <value>
        /// Enables or disables the device fingerprint challenge Web Application Firewall feature.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
                ///
        /// <value>
        /// The action to take on requests from detected bots. If unspecified, defaults to `DETECT`.
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "DETECT")]
            Detect,
            [EnumMember(Value = "BLOCK")]
            Block
        };

        /// <value>
        /// The action to take on requests from detected bots. If unspecified, defaults to `DETECT`.
        /// </value>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        /// <value>
        /// The number of failed requests allowed before taking action. If unspecified, defaults to `10`.
        /// </value>
        [JsonProperty(PropertyName = "failureThreshold")]
        public System.Nullable<int> FailureThreshold { get; set; }
        
        /// <value>
        /// The number of seconds between challenges for the same IP address. If unspecified, defaults to `60`.
        /// </value>
        [JsonProperty(PropertyName = "actionExpirationInSeconds")]
        public System.Nullable<int> ActionExpirationInSeconds { get; set; }
        
        /// <value>
        /// The number of seconds before the failure threshold resets. If unspecified, defaults to `60`.
        /// </value>
        [JsonProperty(PropertyName = "failureThresholdExpirationInSeconds")]
        public System.Nullable<int> FailureThresholdExpirationInSeconds { get; set; }
        
        /// <value>
        /// The maximum number of IP addresses permitted with the same device fingerprint. If unspecified, defaults to `20`.
        /// </value>
        [JsonProperty(PropertyName = "maxAddressCount")]
        public System.Nullable<int> MaxAddressCount { get; set; }
        
        /// <value>
        /// The number of seconds before the maximum addresses count resets. If unspecified, defaults to `60`.
        /// </value>
        [JsonProperty(PropertyName = "maxAddressCountExpirationInSeconds")]
        public System.Nullable<int> MaxAddressCountExpirationInSeconds { get; set; }
        
        [JsonProperty(PropertyName = "challengeSettings")]
        public BlockChallengeSettings ChallengeSettings { get; set; }
        
    }
}
