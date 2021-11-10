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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordUsage : AbstractModel
    {
        
        /// <summary>
        /// Time point for the statistics, e.g., `2020-09-07` or `2020-09-07 00:05:05`
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// SD video duration (s)
        /// </summary>
        [JsonProperty("Class1VideoTime")]
        public ulong? Class1VideoTime{ get; set; }

        /// <summary>
        /// HD video duration (s)
        /// </summary>
        [JsonProperty("Class2VideoTime")]
        public ulong? Class2VideoTime{ get; set; }

        /// <summary>
        /// FHD video duration (s)
        /// </summary>
        [JsonProperty("Class3VideoTime")]
        public ulong? Class3VideoTime{ get; set; }

        /// <summary>
        /// Audio duration (s)
        /// </summary>
        [JsonProperty("AudioTime")]
        public ulong? AudioTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeKey", this.TimeKey);
            this.SetParamSimple(map, prefix + "Class1VideoTime", this.Class1VideoTime);
            this.SetParamSimple(map, prefix + "Class2VideoTime", this.Class2VideoTime);
            this.SetParamSimple(map, prefix + "Class3VideoTime", this.Class3VideoTime);
            this.SetParamSimple(map, prefix + "AudioTime", this.AudioTime);
        }
    }
}

