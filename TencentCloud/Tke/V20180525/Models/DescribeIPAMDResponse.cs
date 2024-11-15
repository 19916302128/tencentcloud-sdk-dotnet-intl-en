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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIPAMDResponse : AbstractModel
    {
        
        /// <summary>
        /// Is the eniipamd component installed?
        /// </summary>
        [JsonProperty("EnableIPAMD")]
        public bool? EnableIPAMD{ get; set; }

        /// <summary>
        /// Is custom podcidr enabled? It is false by default. It only matters if the eniipamd component is installed.
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EnableCustomizedPodCidr")]
        public bool? EnableCustomizedPodCidr{ get; set; }

        /// <summary>
        /// Is vpccni mode disabled? It is false by default. It only matters if the eniipamd component is installed.
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DisableVpcCniMode")]
        public bool? DisableVpcCniMode{ get; set; }

        /// <summary>
        /// Component status. The value is available only if the eniipamd component is installed.
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Phase")]
        public string Phase{ get; set; }

        /// <summary>
        /// Error message. It is available only if the eniipamd component is installed and the status is not running.
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// Subnet information. It is available only if the eniipamd component is installed.
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// Fixed IP recycling time. It is available only if the eniipamd component is installed.
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClaimExpiredDuration")]
        public string ClaimExpiredDuration{ get; set; }

        /// <summary>
        /// Is the relay network card mode enabled?
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EnableTrunkingENI")]
        public bool? EnableTrunkingENI{ get; set; }

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
            this.SetParamSimple(map, prefix + "EnableIPAMD", this.EnableIPAMD);
            this.SetParamSimple(map, prefix + "EnableCustomizedPodCidr", this.EnableCustomizedPodCidr);
            this.SetParamSimple(map, prefix + "DisableVpcCniMode", this.DisableVpcCniMode);
            this.SetParamSimple(map, prefix + "Phase", this.Phase);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "ClaimExpiredDuration", this.ClaimExpiredDuration);
            this.SetParamSimple(map, prefix + "EnableTrunkingENI", this.EnableTrunkingENI);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

