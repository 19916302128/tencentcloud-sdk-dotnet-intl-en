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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BinlogItem : AbstractModel
    {
        
        /// <summary>
        /// Binlog filename
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// Transaction start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Transaction end time
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// Binlog file ID
        /// </summary>
        [JsonProperty("BinlogId")]
        public long? BinlogId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "BinlogId", this.BinlogId);
        }
    }
}

