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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulDefenceSettingResponse : AbstractModel
    {
        
        /// <summary>
        /// Whether it is enabled. Valid values: `0` (disabled); `1` (enabled).
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// Scope of servers with exploit prevention enabled. Valid values: `0` (specified servers); `1` (all servers).
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// Number of servers with exploit prevention enabled
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// Number of abnormal servers with exploit prevention enabled
        /// </summary>
        [JsonProperty("ExceptionHostCount")]
        public long? ExceptionHostCount{ get; set; }

        /// <summary>
        /// Specified servers with exploit prevention enabled
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostIDs")]
        public string[] HostIDs{ get; set; }

        /// <summary>
        /// Total number of servers with TCSS activated
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostTotalCount")]
        public long? HostTotalCount{ get; set; }

        /// <summary>
        /// Number of vulnerabilities that can be prevented
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportDefenseVulCount")]
        public long? SupportDefenseVulCount{ get; set; }

        /// <summary>
        /// Number of normal nodes
        /// </summary>
        [JsonProperty("HostNodeCount")]
        public long? HostNodeCount{ get; set; }

        /// <summary>
        /// Super node scope
        /// </summary>
        [JsonProperty("SuperScope")]
        public long? SuperScope{ get; set; }

        /// <summary>
        /// Number of super nodes
        /// </summary>
        [JsonProperty("SuperNodeCount")]
        public long? SuperNodeCount{ get; set; }

        /// <summary>
        /// List of super node IDs
        /// </summary>
        [JsonProperty("SuperNodeIds")]
        public string[] SuperNodeIds{ get; set; }

        /// <summary>
        /// Total number of super nodes with TCSS activated
        /// </summary>
        [JsonProperty("NodeTotalCount")]
        public long? NodeTotalCount{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "ExceptionHostCount", this.ExceptionHostCount);
            this.SetParamArraySimple(map, prefix + "HostIDs.", this.HostIDs);
            this.SetParamSimple(map, prefix + "HostTotalCount", this.HostTotalCount);
            this.SetParamSimple(map, prefix + "SupportDefenseVulCount", this.SupportDefenseVulCount);
            this.SetParamSimple(map, prefix + "HostNodeCount", this.HostNodeCount);
            this.SetParamSimple(map, prefix + "SuperScope", this.SuperScope);
            this.SetParamSimple(map, prefix + "SuperNodeCount", this.SuperNodeCount);
            this.SetParamArraySimple(map, prefix + "SuperNodeIds.", this.SuperNodeIds);
            this.SetParamSimple(map, prefix + "NodeTotalCount", this.NodeTotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

