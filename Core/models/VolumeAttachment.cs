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
using Newtonsoft.Json.Linq;

namespace Oci.CoreService.Models
{
    /// <summary>
    /// A base object for all types of attachments between a storage volume and an instance.
    /// For specific details about iSCSI attachments, see
    /// {@link IScsiVolumeAttachment}.
    /// <br/>
    /// For general information about volume attachments, see
    /// [Overview of Block Volume Storage](https://docs.cloud.oracle.com/Content/Block/Concepts/overview.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you
    /// supply string values using the API.
    /// 
    /// </summary>
    [JsonConverter(typeof(VolumeAttachmentModelConverter))]
    public class VolumeAttachment 
    {
        
        
        /// <value>
        /// The availability domain of an instance.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The device name.
        /// </value>
        [JsonProperty(PropertyName = "device")]
        public string Device { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it cannot be changed.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My volume attachment
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the volume attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the instance the volume is attached to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceId is required.")]
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
        
        /// <value>
        /// Whether the attachment was created in read-only mode.
        /// </value>
        [JsonProperty(PropertyName = "isReadOnly")]
        public System.Nullable<bool> IsReadOnly { get; set; }
        
        /// <value>
        /// Whether the attachment should be created in shareable mode. If an attachment is created in shareable mode, then other instances can attach the same volume, provided that they also create their attachments in shareable mode. Only certain volume types can be attached in shareable mode. Defaults to false if not specified.
        /// </value>
        [JsonProperty(PropertyName = "isShareable")]
        public System.Nullable<bool> IsShareable { get; set; }
                ///
        /// <value>
        /// The current state of the volume attachment.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "ATTACHING")]
            Attaching,
            [EnumMember(Value = "ATTACHED")]
            Attached,
            [EnumMember(Value = "DETACHING")]
            Detaching,
            [EnumMember(Value = "DETACHED")]
            Detached
        };

        /// <value>
        /// The current state of the volume attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the volume was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The OCID of the volume.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VolumeId is required.")]
        [JsonProperty(PropertyName = "volumeId")]
        public string VolumeId { get; set; }
        
        /// <value>
        /// Whether in-transit encryption for the data volume's paravirtualized attachment is enabled or not.
        /// </value>
        [JsonProperty(PropertyName = "isPvEncryptionInTransitEnabled")]
        public System.Nullable<bool> IsPvEncryptionInTransitEnabled { get; set; }
        
    }

    public class VolumeAttachmentModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(VolumeAttachment);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(VolumeAttachment);
            var discriminator = jsonObject["attachmentType"].Value<string>();
            switch (discriminator)
            {
                case "iscsi":
                    obj = new IScsiVolumeAttachment();
                    break;
                case "emulated":
                    obj = new EmulatedVolumeAttachment();
                    break;
                case "paravirtualized":
                    obj = new ParavirtualizedVolumeAttachment();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
