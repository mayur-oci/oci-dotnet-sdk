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
    /// LogAnalyticsWarning
    /// </summary>
    public class LogAnalyticsWarning 
    {
        
        /// <value>
        /// The unique identifier of the agent associated with the warning
        /// </value>
        [JsonProperty(PropertyName = "agentId")]
        public string AgentId { get; set; }
        
        /// <value>
        /// The host containing the agent associated with the warning
        /// </value>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// The display name of the rule which triggered the warning
        /// </value>
        [JsonProperty(PropertyName = "ruleDisplayName")]
        public string RuleDisplayName { get; set; }
        
        /// <value>
        /// The name of the source associated with the warning
        /// </value>
        [JsonProperty(PropertyName = "sourceName")]
        public string SourceName { get; set; }
        
        /// <value>
        /// The entity compartment ID.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the source associated with the warning
        /// </value>
        [JsonProperty(PropertyName = "sourceDisplayName")]
        public string SourceDisplayName { get; set; }
        
        /// <value>
        /// The name of the entity associated with the warning
        /// </value>
        [JsonProperty(PropertyName = "entityName")]
        public string EntityName { get; set; }
        
        /// <value>
        /// The time at which the warning was most recently collected
        /// </value>
        [JsonProperty(PropertyName = "timeCollected")]
        public System.Nullable<System.DateTime> TimeCollected { get; set; }
        
        /// <value>
        /// The unique identifier of the warning
        /// </value>
        [JsonProperty(PropertyName = "warningId")]
        public string WarningId { get; set; }
        
        /// <value>
        /// The date at which the warning was initially triggered
        /// </value>
        [JsonProperty(PropertyName = "timeOfInitialWarning")]
        public System.Nullable<System.DateTime> TimeOfInitialWarning { get; set; }
        
        /// <value>
        /// A flag indicating if the warning is currently active
        /// </value>
        [JsonProperty(PropertyName = "isActive")]
        public System.Nullable<bool> IsActive { get; set; }
        
        /// <value>
        /// A flag indicating if the warning is currently suppressed
        /// </value>
        [JsonProperty(PropertyName = "isSuppressed")]
        public System.Nullable<bool> IsSuppressed { get; set; }
        
        /// <value>
        /// The most recent date on which the warning was triggered
        /// </value>
        [JsonProperty(PropertyName = "timeOfLatestWarning")]
        public System.Nullable<System.DateTime> TimeOfLatestWarning { get; set; }
        
        /// <value>
        /// The warning level - either pattern, rule, or source.
        /// </value>
        [JsonProperty(PropertyName = "warningLevel")]
        public string WarningLevel { get; set; }
        
        /// <value>
        /// A description of the warning intended for the consumer of the warning.  It will
        /// usually detail the cause of the warning, may suggest a remedy, and can contain any
        /// other relevant information the consumer might find useful
        /// 
        /// </value>
        [JsonProperty(PropertyName = "warningMessage")]
        public string WarningMessage { get; set; }
        
        /// <value>
        /// The unique identifier of the warning pattern
        /// </value>
        [JsonProperty(PropertyName = "patternId")]
        public string PatternId { get; set; }
        
        /// <value>
        /// The text of the pattern used by the warning
        /// </value>
        [JsonProperty(PropertyName = "patternText")]
        public string PatternText { get; set; }
        
        /// <value>
        /// The unique identifier of the rule associated with the warning
        /// </value>
        [JsonProperty(PropertyName = "ruleId")]
        public string RuleId { get; set; }
        
        /// <value>
        /// The unique identifier of the source associated with the warning
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        
        /// <value>
        /// The user who suppressed the warning, or empty if the warning is not suppressed
        /// </value>
        [JsonProperty(PropertyName = "suppressedBy")]
        public string SuppressedBy { get; set; }
        
        /// <value>
        /// The unique identifier of the entity associated with the warning
        /// </value>
        [JsonProperty(PropertyName = "entityId")]
        public string EntityId { get; set; }
        
        /// <value>
        /// The type of the entity associated with the warning
        /// </value>
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
        
        /// <value>
        /// The display name of the entity type associated with the warning
        /// </value>
        [JsonProperty(PropertyName = "entityTypeDisplayName")]
        public string EntityTypeDisplayName { get; set; }
        
        /// <value>
        /// The display name of the warning type
        /// </value>
        [JsonProperty(PropertyName = "typeDisplayName")]
        public string TypeDisplayName { get; set; }
        
        /// <value>
        /// The internal name of the warning
        /// </value>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }
        
        /// <value>
        /// The warning severity
        /// </value>
        [JsonProperty(PropertyName = "severity")]
        public System.Nullable<int> Severity { get; set; }
        
    }
}