/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFunctionResponse : AbstractModel
    {
        
        /// <summary>
        /// Latest modification time of the function
        /// </summary>
        [JsonProperty("ModTime")]
        public string ModTime{ get; set; }

        /// <summary>
        /// Function code
        /// </summary>
        [JsonProperty("CodeInfo")]
        public string CodeInfo{ get; set; }

        /// <summary>
        /// Function description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Function trigger list
        /// </summary>
        [JsonProperty("Triggers")]
        public Trigger[] Triggers{ get; set; }

        /// <summary>
        /// Function entry
        /// </summary>
        [JsonProperty("Handler")]
        public string Handler{ get; set; }

        /// <summary>
        /// Function code size
        /// </summary>
        [JsonProperty("CodeSize")]
        public long? CodeSize{ get; set; }

        /// <summary>
        /// Function timeout
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// Function version
        /// </summary>
        [JsonProperty("FunctionVersion")]
        public string FunctionVersion{ get; set; }

        /// <summary>
        /// Maximum available memory of the function
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// Function running environment
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// Function name
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Function VPC
        /// </summary>
        [JsonProperty("VpcConfig")]
        public VpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// Whether to use GPU
        /// </summary>
        [JsonProperty("UseGpu")]
        public string UseGpu{ get; set; }

        /// <summary>
        /// Function environment variable
        /// </summary>
        [JsonProperty("Environment")]
        public Environment Environment{ get; set; }

        /// <summary>
        /// Whether the code is correct
        /// </summary>
        [JsonProperty("CodeResult")]
        public string CodeResult{ get; set; }

        /// <summary>
        /// Code error information
        /// </summary>
        [JsonProperty("CodeError")]
        public string CodeError{ get; set; }

        /// <summary>
        /// Error code
        /// </summary>
        [JsonProperty("ErrNo")]
        public long? ErrNo{ get; set; }

        /// <summary>
        /// Function namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Role bound to the function
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// Whether to install dependencies automatically
        /// </summary>
        [JsonProperty("InstallDependency")]
        public string InstallDependency{ get; set; }

        /// <summary>
        /// Function status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Status description
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// CLS logset to which logs are shipped
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// CLS Topic to which logs are shipped
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// Function ID
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// Function tag list
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// EipConfig configuration
        /// </summary>
        [JsonProperty("EipConfig")]
        public EipOutConfig EipConfig{ get; set; }

        /// <summary>
        /// Domain name information
        /// </summary>
        [JsonProperty("AccessInfo")]
        public AccessInfo AccessInfo{ get; set; }

        /// <summary>
        /// Function type. The value is `HTTP` or `Event`.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Whether to enable L5
        /// </summary>
        [JsonProperty("L5Enable")]
        public string L5Enable{ get; set; }

        /// <summary>
        /// Version information of a layer associated with a function
        /// </summary>
        [JsonProperty("Layers")]
        public LayerVersionInfo[] Layers{ get; set; }

        /// <summary>
        /// Information of a dead letter queue associated with a function
        /// </summary>
        [JsonProperty("DeadLetterConfig")]
        public DeadLetterConfig DeadLetterConfig{ get; set; }

        /// <summary>
        /// Function creation time
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// Public network access configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicNetConfig")]
        public PublicNetConfigOut PublicNetConfig{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OnsEnable")]
        public string OnsEnable{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModTime", this.ModTime);
            this.SetParamSimple(map, prefix + "CodeInfo", this.CodeInfo);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Triggers.", this.Triggers);
            this.SetParamSimple(map, prefix + "Handler", this.Handler);
            this.SetParamSimple(map, prefix + "CodeSize", this.CodeSize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "FunctionVersion", this.FunctionVersion);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "UseGpu", this.UseGpu);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamSimple(map, prefix + "CodeResult", this.CodeResult);
            this.SetParamSimple(map, prefix + "CodeError", this.CodeError);
            this.SetParamSimple(map, prefix + "ErrNo", this.ErrNo);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "InstallDependency", this.InstallDependency);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "EipConfig.", this.EipConfig);
            this.SetParamObj(map, prefix + "AccessInfo.", this.AccessInfo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "L5Enable", this.L5Enable);
            this.SetParamArrayObj(map, prefix + "Layers.", this.Layers);
            this.SetParamObj(map, prefix + "DeadLetterConfig.", this.DeadLetterConfig);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamObj(map, prefix + "PublicNetConfig.", this.PublicNetConfig);
            this.SetParamSimple(map, prefix + "OnsEnable", this.OnsEnable);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

