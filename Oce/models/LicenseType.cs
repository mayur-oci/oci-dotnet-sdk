/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OceService.Models
{
  /// <summary>
  /// license types can be NEW for new oracle content and experience cloud license,
    /// or BYOL for bring your own license
    /// 
  /// </summary>
  public enum LicenseType {
      [EnumMember(Value = "NEW")]
      New,
      [EnumMember(Value = "BYOL")]
      Byol
  }
}
