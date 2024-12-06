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

    public class DescribeVirusSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// ID of the last scan task
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Number of containers affected by the trojan
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskContainerCnt")]
        public ulong? RiskContainerCnt{ get; set; }

        /// <summary>
        /// Number of pending risks
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

        /// <summary>
        /// Update time of the virus library
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VirusDataBaseModifyTime")]
        public string VirusDataBaseModifyTime{ get; set; }

        /// <summary>
        /// Increase in the number of containers affected by trojans from yesterday
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskContainerIncrease")]
        public long? RiskContainerIncrease{ get; set; }

        /// <summary>
        /// Increase in the number of pending risks from yesterday
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskIncrease")]
        public long? RiskIncrease{ get; set; }

        /// <summary>
        /// Increase in the number of isolated events from yesterday
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsolateIncrease")]
        public long? IsolateIncrease{ get; set; }

        /// <summary>
        /// Total number of isolated events
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsolateCnt")]
        public long? IsolateCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "RiskContainerCnt", this.RiskContainerCnt);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "VirusDataBaseModifyTime", this.VirusDataBaseModifyTime);
            this.SetParamSimple(map, prefix + "RiskContainerIncrease", this.RiskContainerIncrease);
            this.SetParamSimple(map, prefix + "RiskIncrease", this.RiskIncrease);
            this.SetParamSimple(map, prefix + "IsolateIncrease", this.IsolateIncrease);
            this.SetParamSimple(map, prefix + "IsolateCnt", this.IsolateCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

