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

    public class ModifyBackupStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Backup mode, which supports daily backup only. Valid value: daily.
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// Backup time. Value range: an integer from 0 to 23.
        /// </summary>
        [JsonProperty("BackupTime")]
        public ulong? BackupTime{ get; set; }

        /// <summary>
        /// Backup interval in days when the `BackupType` is `daily`. Valid value: 1.
        /// </summary>
        [JsonProperty("BackupDay")]
        public ulong? BackupDay{ get; set; }

        /// <summary>
        /// Backup mode. Valid values: `master_pkg` (archive the backup files of the primary node), `master_no_pkg` (do not archive the backup files of the primary node), `slave_pkg` (archive the backup files of the replica node), `slave_no_pkg` (do not archive the backup files of the replica node). Backup files of the replica node are supported only when Always On disaster recovery is enabled.
        /// </summary>
        [JsonProperty("BackupModel")]
        public string BackupModel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "BackupDay", this.BackupDay);
            this.SetParamSimple(map, prefix + "BackupModel", this.BackupModel);
        }
    }
}

