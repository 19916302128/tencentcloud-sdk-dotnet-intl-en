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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindRealServer : AbstractModel
    {
        
        /// <summary>
        /// Origin server ID
        /// </summary>
        [JsonProperty("RealServerId")]
        public string RealServerId{ get; set; }

        /// <summary>
        /// Origin server IP or domain name
        /// </summary>
        [JsonProperty("RealServerIP")]
        public string RealServerIP{ get; set; }

        /// <summary>
        /// Origin server weight
        /// </summary>
        [JsonProperty("RealServerWeight")]
        public long? RealServerWeight{ get; set; }

        /// <summary>
        /// Origin server health check status. Valid values:
        /// 0: normal;
        /// 1: exceptional.
        /// If health check is not enabled, this status will always be normal.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealServerStatus")]
        public long? RealServerStatus{ get; set; }

        /// <summary>
        /// Origin server port number
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealServerPort")]
        public long? RealServerPort{ get; set; }

        /// <summary>
        /// If the origin server is a domain name, the domain name will be resolved to one or multiple IPs. This field indicates the exceptional IP list.
        /// </summary>
        [JsonProperty("DownIPList")]
        public string[] DownIPList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RealServerId", this.RealServerId);
            this.SetParamSimple(map, prefix + "RealServerIP", this.RealServerIP);
            this.SetParamSimple(map, prefix + "RealServerWeight", this.RealServerWeight);
            this.SetParamSimple(map, prefix + "RealServerStatus", this.RealServerStatus);
            this.SetParamSimple(map, prefix + "RealServerPort", this.RealServerPort);
            this.SetParamArraySimple(map, prefix + "DownIPList.", this.DownIPList);
        }
    }
}

