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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CronHorizontalAutoscalerSchedule : AbstractModel
    {
        
        /// <summary>
        /// Triggering time, in the format of HH:MM
        /// Example:
        /// 00:00 (Trigger at midnight)
        /// </summary>
        [JsonProperty("StartAt")]
        public string StartAt{ get; set; }

        /// <summary>
        /// Number of target pods (less than 50)
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetReplicas")]
        public long? TargetReplicas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartAt", this.StartAt);
            this.SetParamSimple(map, prefix + "TargetReplicas", this.TargetReplicas);
        }
    }
}

