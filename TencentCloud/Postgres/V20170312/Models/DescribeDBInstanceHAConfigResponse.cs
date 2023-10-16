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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstanceHAConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// Primary-standby sync mode. Valid values:
        /// <li>`Semi-sync`
        /// <li>`Async`
        /// </summary>
        [JsonProperty("SyncMode")]
        public string SyncMode{ get; set; }

        /// <summary>
        /// Maximum data lag for high-availability standby server. The standby node can be promoted to the primary node when its data lag and the delay time are both less than the value of `MaxStandbyLatency` and `MaxStandbyLag` respectively.
        /// <li>Unit: byte
        /// <li>Value range: 1073741824-322122547200
        /// </summary>
        [JsonProperty("MaxStandbyLatency")]
        public ulong? MaxStandbyLatency{ get; set; }

        /// <summary>
        /// The maximum delay for high-availability standby server The standby node can be promoted to the primary node when its data lag and the delay time are both less than or equals to the value of `MaxStandbyLatency` and `MaxStandbyLag` respectively.
        /// <li>Unit: s
        /// <li>Value range: 5-10
        /// </summary>
        [JsonProperty("MaxStandbyLag")]
        public ulong? MaxStandbyLag{ get; set; }

        /// <summary>
        /// Maximum data sync lag for u200du200dstandby server. If data lag of the standby node and the delay time are both less than or equals to the values of `MaxSyncStandbyLatency` and `MaxSyncStandbyLag` respectively, the standby server adopts semi-sync replication; if not, it adopts async replication.
        /// This value is only valid for the instance with `SyncMode` set to `Semi-sync`.
        /// This field returns null for async instance
        /// and semi-sync (non-downgradable to async) instance.
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxSyncStandbyLatency")]
        public ulong? MaxSyncStandbyLatency{ get; set; }

        /// <summary>
        /// Maximum sync delay time for u200dstandby server. If the delay time for u200dstandby server and the data lag are both less than or equals to the values of `MaxSyncStandbyLag` and `MaxSyncStandbyLatency` respectively, the standby server adopts sync replication mode; if not, it adopts async replication.
        /// This value is only valid for the instance with `SyncMode` set to `Semi-sync`.
        /// This field will not return for async instance
        /// and semi-sync (non-downgradable to async) instance.
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxSyncStandbyLag")]
        public ulong? MaxSyncStandbyLag{ get; set; }

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
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "MaxStandbyLatency", this.MaxStandbyLatency);
            this.SetParamSimple(map, prefix + "MaxStandbyLag", this.MaxStandbyLag);
            this.SetParamSimple(map, prefix + "MaxSyncStandbyLatency", this.MaxSyncStandbyLatency);
            this.SetParamSimple(map, prefix + "MaxSyncStandbyLag", this.MaxSyncStandbyLag);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

