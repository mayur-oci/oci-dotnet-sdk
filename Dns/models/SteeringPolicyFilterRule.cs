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


namespace Oci.DnsService.Models
{
    
    public class SteeringPolicyFilterRule : SteeringPolicyRule
    {
        
        /// <value>
        /// An array of `caseConditions`. A rule may optionally include a sequence of cases defining alternate
        /// configurations for how it should behave during processing for any given DNS query. When a rule has
        /// no sequence of `cases`, it is always evaluated with the same configuration during processing. When
        /// a rule has an empty sequence of `cases`, it is always ignored during processing. When a rule has a
        /// non-empty sequence of `cases`, its behavior during processing is configured by the first matching
        /// `case` in the sequence. When a rule has no matching cases the rule is ignored. A rule case with no
        /// `caseCondition` always matches. A rule case with a `caseCondition` matches only when that expression
        /// evaluates to true for the given query.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cases")]
        public System.Collections.Generic.List<SteeringPolicyFilterRuleCase> Cases { get; set; }
        
        /// <value>
        /// Defines a default set of answer conditions and values that are applied to an answer when
        /// `cases` is not defined for the rule, or a matching case does not have any matching
        /// `answerCondition`s in its `answerData`. `defaultAnswerData` is not applied if `cases` is
        /// defined and there are no matching cases. In this scenario, the next rule will be processed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "defaultAnswerData")]
        public System.Collections.Generic.List<SteeringPolicyFilterAnswerData> DefaultAnswerData { get; set; }
        
        [JsonProperty(PropertyName = "ruleType")]
        private readonly string ruleType = "FILTER";
    }
}
