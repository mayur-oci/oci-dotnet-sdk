/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OptimizerService.Models
{
  /// <summary>
  /// Specifies which tag value types in the TagValues field result in overrides of the recommendation criteria. Allowed values are ANY and VALUE.
    /// <br/>
    /// When the TagValueType field value is ANY, the TagValues field should be empty which will in turn enforce overrides to the recommendation for resources with any tag values attached to them.
    /// When the TagValueType field value is VALUE, the TagValues field must include a specific value or list of values. Overrides to the recommendation criteria only occur for resources that match the values in the TagKey and in the TagValues fields.
    /// <br/>
    /// For example, if the TagKey value is B, the TagValueType value is ANY, and the TagValues field is empty, overrides to the recommendation criteria occur for any resources that have the tag key B.
    /// If the TagKey value is B, the TagValueType value is VALUE, and the TagValues value is s1, overrides to the recommendation criteria only occur for resources that have the tag key B with the associated tag value s1.
    /// 
  /// </summary>
  public enum TagValueType {
      [EnumMember(Value = "VALUE")]
      Value,
      [EnumMember(Value = "ANY")]
      Any
  }
}