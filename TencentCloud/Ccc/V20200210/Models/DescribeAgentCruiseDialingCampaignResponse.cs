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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAgentCruiseDialingCampaignResponse : AbstractModel
    {
        
        /// <summary>
        /// Task name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Agent account.
        /// </summary>
        [JsonProperty("Agent")]
        public string Agent{ get; set; }

        /// <summary>
        /// Single-Round concurrent call volume 1-20.
        /// </summary>
        [JsonProperty("ConcurrencyNumber")]
        public long? ConcurrencyNumber{ get; set; }

        /// <summary>
        /// Task start time. unix timestamp. the task will automatically start after this time.
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// Task termination time. unix timestamp. the task will automatically terminate after this time.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Being called sequence: 0 for random 1 for in order.
        /// </summary>
        [JsonProperty("CallOrder")]
        public long? CallOrder{ get; set; }

        /// <summary>
        /// Caller custom data, maximum length 1024.
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// Task status 0 not started 1 running 2 completed 3 terminated.
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// Total number of called parties.
        /// </summary>
        [JsonProperty("TotalCalleeCount")]
        public long? TotalCalleeCount{ get; set; }

        /// <summary>
        /// Number of calls made and received.
        /// </summary>
        [JsonProperty("CalledCalleeCount")]
        public long? CalledCalleeCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Agent", this.Agent);
            this.SetParamSimple(map, prefix + "ConcurrencyNumber", this.ConcurrencyNumber);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CallOrder", this.CallOrder);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "TotalCalleeCount", this.TotalCalleeCount);
            this.SetParamSimple(map, prefix + "CalledCalleeCount", this.CalledCalleeCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

