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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupsRequest : AbstractModel
    {
        
        /// <summary>
        /// Start name (yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time (yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Instance ID in the format of mssql-njj2mtpl
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Number of results per page. Value range: 1-100. Default value: 20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Page number. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Filter by backup name. If this parameter is left empty, backup name will not be used in filtering.
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// Filter by backup policy. Valid values: 0 (instance backup), 1 (multi-database backup). If this parameter is left empty, backup policy will not be used in filtering.
        /// </summary>
        [JsonProperty("Strategy")]
        public long? Strategy{ get; set; }

        /// <summary>
        /// Filter by backup mode. Valid values: 0 (automatic backup on a regular basis), 1 (manual backup performed by the user at any time). If this parameter is left empty, backup mode will not be used in filtering.
        /// </summary>
        [JsonProperty("BackupWay")]
        public long? BackupWay{ get; set; }

        /// <summary>
        /// Filter by backup ID. If this parameter is left empty, backup ID will not be used in filtering.
        /// </summary>
        [JsonProperty("BackupId")]
        public ulong? BackupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "BackupWay", this.BackupWay);
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
        }
    }
}

