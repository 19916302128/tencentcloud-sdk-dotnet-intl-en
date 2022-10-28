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

    public class DescribeBinlogBackupOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// Total capacity of log backups in bytes (including remote log backups)
        /// </summary>
        [JsonProperty("BinlogBackupVolume")]
        public long? BinlogBackupVolume{ get; set; }

        /// <summary>
        /// Total number of log backups (include remote log backups)
        /// </summary>
        [JsonProperty("BinlogBackupCount")]
        public long? BinlogBackupCount{ get; set; }

        /// <summary>
        /// Capacity of remote log backups in bytes
        /// </summary>
        [JsonProperty("RemoteBinlogVolume")]
        public long? RemoteBinlogVolume{ get; set; }

        /// <summary>
        /// Number of remote backups
        /// </summary>
        [JsonProperty("RemoteBinlogCount")]
        public long? RemoteBinlogCount{ get; set; }

        /// <summary>
        /// Capacity of archive log backups in bytes
        /// </summary>
        [JsonProperty("BinlogArchiveVolume")]
        public long? BinlogArchiveVolume{ get; set; }

        /// <summary>
        /// Number of archived log backups
        /// </summary>
        [JsonProperty("BinlogArchiveCount")]
        public long? BinlogArchiveCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "BinlogBackupVolume", this.BinlogBackupVolume);
            this.SetParamSimple(map, prefix + "BinlogBackupCount", this.BinlogBackupCount);
            this.SetParamSimple(map, prefix + "RemoteBinlogVolume", this.RemoteBinlogVolume);
            this.SetParamSimple(map, prefix + "RemoteBinlogCount", this.RemoteBinlogCount);
            this.SetParamSimple(map, prefix + "BinlogArchiveVolume", this.BinlogArchiveVolume);
            this.SetParamSimple(map, prefix + "BinlogArchiveCount", this.BinlogArchiveCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

