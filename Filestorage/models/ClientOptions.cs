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


namespace Oci.FilestorageService.Models
{
    /// <summary>
    /// NFS export options applied to a specified set of
    /// clients. Only governs access through the associated
    /// export. Access to the same file system through a different
    /// export (on the same or different mount target) will be governed
    /// by that export's export options.
    /// 
    /// </summary>
    public class ClientOptions 
    {
        
        /// <value>
        /// Clients these options should apply to. Must be a either
        /// single IPv4 address or single IPv4 CIDR block.
        /// <br/>
        /// **Note:** Access will also be limited by any applicable VCN
        /// security rules and the ability to route IP packets to the
        /// mount target. Mount targets do not have Internet-routable IP addresses.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <value>
        /// If `true`, clients accessing the file system through this
        /// export must connect from a privileged source port. If
        /// unspecified, defaults to `true`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "requirePrivilegedSourcePort")]
        public System.Nullable<bool> RequirePrivilegedSourcePort { get; set; }
        ///
        /// <value>
        /// Type of access to grant clients using the file system
        /// through this export. If unspecified defaults to `READ_ONLY`.
        /// 
        /// </value>
        ///
        public enum AccessEnum {
            [EnumMember(Value = "READ_WRITE")]
            ReadWrite,
            [EnumMember(Value = "READ_ONLY")]
            ReadOnly
        };

        /// <value>
        /// Type of access to grant clients using the file system
        /// through this export. If unspecified defaults to `READ_ONLY`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "access")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AccessEnum> Access { get; set; }
        ///
        /// <value>
        /// Used when clients accessing the file system through this export
        /// have their UID and GID remapped to 'anonymousUid' and
        /// 'anonymousGid'. If `ALL`, all users and groups are remapped;
        /// if `ROOT`, only the root user and group (UID/GID 0) are
        /// remapped; if `NONE`, no remapping is done. If unspecified,
        /// defaults to `ROOT`.
        /// 
        /// </value>
        ///
        public enum IdentitySquashEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "ROOT")]
            Root,
            [EnumMember(Value = "ALL")]
            All
        };

        /// <value>
        /// Used when clients accessing the file system through this export
        /// have their UID and GID remapped to 'anonymousUid' and
        /// 'anonymousGid'. If `ALL`, all users and groups are remapped;
        /// if `ROOT`, only the root user and group (UID/GID 0) are
        /// remapped; if `NONE`, no remapping is done. If unspecified,
        /// defaults to `ROOT`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "identitySquash")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IdentitySquashEnum> IdentitySquash { get; set; }

        /// <value>
        /// UID value to remap to when squashing a client UID (see
        /// identitySquash for more details.) If unspecified, defaults
        /// to `65534`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "anonymousUid")]
        public System.Nullable<long> AnonymousUid { get; set; }

        /// <value>
        /// GID value to remap to when squashing a client GID (see
        /// identitySquash for more details.) If unspecified defaults
        /// to `65534`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "anonymousGid")]
        public System.Nullable<long> AnonymousGid { get; set; }
    }
}