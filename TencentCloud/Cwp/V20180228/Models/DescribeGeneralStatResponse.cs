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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGeneralStatResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of hosts
        /// </summary>
        [JsonProperty("MachinesAll")]
        public ulong? MachinesAll{ get; set; }

        /// <summary>
        /// Total number of hosts not installed with the CWPP client
        /// </summary>
        [JsonProperty("MachinesUninstalled")]
        public ulong? MachinesUninstalled{ get; set; }

        /// <summary>
        /// Total number of CWPP clients
        /// </summary>
        [JsonProperty("AgentsAll")]
        public ulong? AgentsAll{ get; set; }

        /// <summary>
        /// Total number of online CWPP clients
        /// </summary>
        [JsonProperty("AgentsOnline")]
        public ulong? AgentsOnline{ get; set; }

        /// <summary>
        /// Total number of CWPP clients that are offline and shut down
        /// </summary>
        [JsonProperty("AgentsOffline")]
        public ulong? AgentsOffline{ get; set; }

        /// <summary>
        /// Total number of Pro Edition CWPP clients
        /// </summary>
        [JsonProperty("AgentsPro")]
        public ulong? AgentsPro{ get; set; }

        /// <summary>
        /// Total number of Basic Edition CWPP clients
        /// </summary>
        [JsonProperty("AgentsBasic")]
        public ulong? AgentsBasic{ get; set; }

        /// <summary>
        /// Total number of prepaid Pro Edition CWPP clients that will expire in 7 days
        /// </summary>
        [JsonProperty("AgentsProExpireWithInSevenDays")]
        public ulong? AgentsProExpireWithInSevenDays{ get; set; }

        /// <summary>
        /// Total number of risky hosts
        /// </summary>
        [JsonProperty("RiskMachine")]
        public ulong? RiskMachine{ get; set; }

        /// <summary>
        /// Total number of hosts that are shut down
        /// </summary>
        [JsonProperty("Shutdown")]
        public ulong? Shutdown{ get; set; }

        /// <summary>
        /// Total number of offline hosts
        /// </summary>
        [JsonProperty("Offline")]
        public ulong? Offline{ get; set; }

        /// <summary>
        /// Number of Ultimate Edition hosts
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FlagshipMachineCnt")]
        public ulong? FlagshipMachineCnt{ get; set; }

        /// <summary>
        /// Protection duration, in days
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProtectDays")]
        public ulong? ProtectDays{ get; set; }

        /// <summary>
        /// Number of hosts added in the last 15 days
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AddedOnTheFifteen")]
        public ulong? AddedOnTheFifteen{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachinesAll", this.MachinesAll);
            this.SetParamSimple(map, prefix + "MachinesUninstalled", this.MachinesUninstalled);
            this.SetParamSimple(map, prefix + "AgentsAll", this.AgentsAll);
            this.SetParamSimple(map, prefix + "AgentsOnline", this.AgentsOnline);
            this.SetParamSimple(map, prefix + "AgentsOffline", this.AgentsOffline);
            this.SetParamSimple(map, prefix + "AgentsPro", this.AgentsPro);
            this.SetParamSimple(map, prefix + "AgentsBasic", this.AgentsBasic);
            this.SetParamSimple(map, prefix + "AgentsProExpireWithInSevenDays", this.AgentsProExpireWithInSevenDays);
            this.SetParamSimple(map, prefix + "RiskMachine", this.RiskMachine);
            this.SetParamSimple(map, prefix + "Shutdown", this.Shutdown);
            this.SetParamSimple(map, prefix + "Offline", this.Offline);
            this.SetParamSimple(map, prefix + "FlagshipMachineCnt", this.FlagshipMachineCnt);
            this.SetParamSimple(map, prefix + "ProtectDays", this.ProtectDays);
            this.SetParamSimple(map, prefix + "AddedOnTheFifteen", this.AddedOnTheFifteen);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

