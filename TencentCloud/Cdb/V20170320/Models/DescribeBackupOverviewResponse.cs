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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of backups of a user in the current region (including data backups and log backups).
        /// </summary>
        [JsonProperty("BackupCount")]
        public long? BackupCount{ get; set; }

        /// <summary>
        /// Total capacity of backups of a user in the current region.
        /// </summary>
        [JsonProperty("BackupVolume")]
        public long? BackupVolume{ get; set; }

        /// <summary>
        /// Paid capacity of backups of a user in the current region, i.e., capacity that exceeds the free tier.
        /// </summary>
        [JsonProperty("BillingVolume")]
        public long? BillingVolume{ get; set; }

        /// <summary>
        /// Backup capacity in the free tier of a user in the current region.
        /// </summary>
        [JsonProperty("FreeVolume")]
        public long? FreeVolume{ get; set; }

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
            this.SetParamSimple(map, prefix + "BackupCount", this.BackupCount);
            this.SetParamSimple(map, prefix + "BackupVolume", this.BackupVolume);
            this.SetParamSimple(map, prefix + "BillingVolume", this.BillingVolume);
            this.SetParamSimple(map, prefix + "FreeVolume", this.FreeVolume);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

