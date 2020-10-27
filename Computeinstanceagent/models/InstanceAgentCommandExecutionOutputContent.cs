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
using Newtonsoft.Json.Linq;

namespace Oci.ComputeinstanceagentService.Models
{
    /// <summary>
    /// command execution output.
    /// </summary>
    [JsonConverter(typeof(InstanceAgentCommandExecutionOutputContentModelConverter))]
    public class InstanceAgentCommandExecutionOutputContent 
    {
                ///
        /// <value>
        /// The response type where the command reponse is made available
        /// 
        /// </value>
        ///
        public enum OutputTypeEnum {
            [EnumMember(Value = "TEXT")]
            Text,
            [EnumMember(Value = "OBJECT_STORAGE_URI")]
            ObjectStorageUri,
            [EnumMember(Value = "OBJECT_STORAGE_TUPLE")]
            ObjectStorageTuple
        };

        /// <value>
        /// The response type where the command reponse is made available
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OutputType is required.")]
        [JsonProperty(PropertyName = "outputType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OutputTypeEnum> OutputType { get; set; }

        /// <value>
        /// command exit code.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExitCode is required.")]
        [JsonProperty(PropertyName = "exitCode")]
        public System.Nullable<int> ExitCode { get; set; }

        /// <value>
        /// optional status message that agent's can populate for additional troubleshooting.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }

    public class InstanceAgentCommandExecutionOutputContentModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(InstanceAgentCommandExecutionOutputContent);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(InstanceAgentCommandExecutionOutputContent);
            var discriminator = jsonObject["outputType"].Value<string>();
            switch (discriminator)
            {
                case "TEXT":
                    obj = new InstanceAgentCommandExecutionOutputViaTextDetails();
                    break;
                case "OBJECT_STORAGE_URI":
                    obj = new InstanceAgentCommandExecutionOutputViaObjectStorageUriDetails();
                    break;
                case "OBJECT_STORAGE_TUPLE":
                    obj = new InstanceAgentCommandExecutionOutputViaObjectStorageTupleDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
