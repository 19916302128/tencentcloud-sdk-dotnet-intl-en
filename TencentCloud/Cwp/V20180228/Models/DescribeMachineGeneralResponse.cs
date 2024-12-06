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

    public class DescribeMachineGeneralResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of assets
        /// </summary>
        [JsonProperty("MachineCnt")]
        public ulong? MachineCnt{ get; set; }

        /// <summary>
        /// Number of Tencent Cloud machines
        /// </summary>
        [JsonProperty("TencentCloudMachineCnt")]
        [System.Obsolete]
        public ulong? TencentCloudMachineCnt{ get; set; }

        /// <summary>
        /// Number of Alibaba Cloud machines
        /// </summary>
        [JsonProperty("AliCloudMachineCnt")]
        [System.Obsolete]
        public ulong? AliCloudMachineCnt{ get; set; }

        /// <summary>
        /// Number of Baidu Cloud machines
        /// </summary>
        [JsonProperty("BaiduCloudMachineCnt")]
        [System.Obsolete]
        public ulong? BaiduCloudMachineCnt{ get; set; }

        /// <summary>
        /// Number of IDC machines
        /// </summary>
        [JsonProperty("IDCMachineCnt")]
        [System.Obsolete]
        public ulong? IDCMachineCnt{ get; set; }

        /// <summary>
        /// Number of machines from other cloud service vendors
        /// </summary>
        [JsonProperty("OtherCloudMachineCnt")]
        [System.Obsolete]
        public ulong? OtherCloudMachineCnt{ get; set; }

        /// <summary>
        /// Number of protected machines
        /// </summary>
        [JsonProperty("ProtectMachineCnt")]
        public ulong? ProtectMachineCnt{ get; set; }

        /// <summary>
        /// Number of protected Basic Edition machines
        /// </summary>
        [JsonProperty("BaseMachineCnt")]
        public ulong? BaseMachineCnt{ get; set; }

        /// <summary>
        /// Number of protected Pro Edition machines
        /// </summary>
        [JsonProperty("SpecialtyMachineCnt")]
        public ulong? SpecialtyMachineCnt{ get; set; }

        /// <summary>
        /// Number of protected Ultimate Edition machines
        /// </summary>
        [JsonProperty("FlagshipMachineCnt")]
        public ulong? FlagshipMachineCnt{ get; set; }

        /// <summary>
        /// Number of risky machines
        /// </summary>
        [JsonProperty("RiskMachineCnt")]
        public ulong? RiskMachineCnt{ get; set; }

        /// <summary>
        /// Number of new risky machines compared with that yesterday
        /// </summary>
        [JsonProperty("CompareYesterdayRiskMachineCnt")]
        public long? CompareYesterdayRiskMachineCnt{ get; set; }

        /// <summary>
        /// Number of new unprotected machines compared with that yesterday
        /// </summary>
        [JsonProperty("CompareYesterdayNotProtectMachineCnt")]
        public long? CompareYesterdayNotProtectMachineCnt{ get; set; }

        /// <summary>
        /// Number of new machines about to expire compared with that yesterday
        /// </summary>
        [JsonProperty("CompareYesterdayDeadlineMachineCnt")]
        public long? CompareYesterdayDeadlineMachineCnt{ get; set; }

        /// <summary>
        /// Number of machines about to expire
        /// </summary>
        [JsonProperty("DeadlineMachineCnt")]
        public ulong? DeadlineMachineCnt{ get; set; }

        /// <summary>
        /// Number of unprotected machines
        /// </summary>
        [JsonProperty("NotProtectMachineCnt")]
        public ulong? NotProtectMachineCnt{ get; set; }

        /// <summary>
        /// Number of protected Inclusive Edition machines (Lighthouse machines)
        /// </summary>
        [JsonProperty("LHGeneralDiscountCnt")]
        public ulong? LHGeneralDiscountCnt{ get; set; }

        /// <summary>
        /// Number of new hosts compared with that yesterday
        /// </summary>
        [JsonProperty("CompareYesterdayMachineCnt")]
        public long? CompareYesterdayMachineCnt{ get; set; }

        /// <summary>
        /// Auto-cleanup Time, maximum 720 hours, minimum 0, 0 by default, 0=OFF
        /// </summary>
        [JsonProperty("MachineDestroyAfterOfflineHours")]
        public ulong? MachineDestroyAfterOfflineHours{ get; set; }

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
            this.SetParamSimple(map, prefix + "MachineCnt", this.MachineCnt);
            this.SetParamSimple(map, prefix + "TencentCloudMachineCnt", this.TencentCloudMachineCnt);
            this.SetParamSimple(map, prefix + "AliCloudMachineCnt", this.AliCloudMachineCnt);
            this.SetParamSimple(map, prefix + "BaiduCloudMachineCnt", this.BaiduCloudMachineCnt);
            this.SetParamSimple(map, prefix + "IDCMachineCnt", this.IDCMachineCnt);
            this.SetParamSimple(map, prefix + "OtherCloudMachineCnt", this.OtherCloudMachineCnt);
            this.SetParamSimple(map, prefix + "ProtectMachineCnt", this.ProtectMachineCnt);
            this.SetParamSimple(map, prefix + "BaseMachineCnt", this.BaseMachineCnt);
            this.SetParamSimple(map, prefix + "SpecialtyMachineCnt", this.SpecialtyMachineCnt);
            this.SetParamSimple(map, prefix + "FlagshipMachineCnt", this.FlagshipMachineCnt);
            this.SetParamSimple(map, prefix + "RiskMachineCnt", this.RiskMachineCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayRiskMachineCnt", this.CompareYesterdayRiskMachineCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayNotProtectMachineCnt", this.CompareYesterdayNotProtectMachineCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayDeadlineMachineCnt", this.CompareYesterdayDeadlineMachineCnt);
            this.SetParamSimple(map, prefix + "DeadlineMachineCnt", this.DeadlineMachineCnt);
            this.SetParamSimple(map, prefix + "NotProtectMachineCnt", this.NotProtectMachineCnt);
            this.SetParamSimple(map, prefix + "LHGeneralDiscountCnt", this.LHGeneralDiscountCnt);
            this.SetParamSimple(map, prefix + "CompareYesterdayMachineCnt", this.CompareYesterdayMachineCnt);
            this.SetParamSimple(map, prefix + "MachineDestroyAfterOfflineHours", this.MachineDestroyAfterOfflineHours);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

