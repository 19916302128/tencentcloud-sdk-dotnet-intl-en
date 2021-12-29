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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DynamicDiskConfig : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StepForwardPercentage")]
        public long? StepForwardPercentage{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DiskQuotaPercentage")]
        public long? DiskQuotaPercentage{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MaxDiskSpace")]
        public long? MaxDiskSpace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "StepForwardPercentage", this.StepForwardPercentage);
            this.SetParamSimple(map, prefix + "DiskQuotaPercentage", this.DiskQuotaPercentage);
            this.SetParamSimple(map, prefix + "MaxDiskSpace", this.MaxDiskSpace);
        }
    }
}

