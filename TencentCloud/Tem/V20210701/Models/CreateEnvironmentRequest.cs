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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEnvironmentRequest : AbstractModel
    {
        
        /// <summary>
        /// Environment name
        /// </summary>
        [JsonProperty("EnvironmentName")]
        public string EnvironmentName{ get; set; }

        /// <summary>
        /// VPC name
        /// </summary>
        [JsonProperty("Vpc")]
        public string Vpc{ get; set; }

        /// <summary>
        /// List of subnets
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// Environment description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Kubernetes version
        /// </summary>
        [JsonProperty("K8sVersion")]
        public string K8sVersion{ get; set; }

        /// <summary>
        /// Source channel
        /// </summary>
        [JsonProperty("SourceChannel")]
        public long? SourceChannel{ get; set; }

        /// <summary>
        /// Whether to enable the TSW service
        /// </summary>
        [JsonProperty("EnableTswTraceService")]
        public bool? EnableTswTraceService{ get; set; }

        /// <summary>
        /// Tag
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Environment type. Values: `test`, `pre`, `prod`
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// The region to create the environment
        /// </summary>
        [JsonProperty("CreateRegion")]
        public string CreateRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentName", this.EnvironmentName);
            this.SetParamSimple(map, prefix + "Vpc", this.Vpc);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "K8sVersion", this.K8sVersion);
            this.SetParamSimple(map, prefix + "SourceChannel", this.SourceChannel);
            this.SetParamSimple(map, prefix + "EnableTswTraceService", this.EnableTswTraceService);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamSimple(map, prefix + "CreateRegion", this.CreateRegion);
        }
    }
}

