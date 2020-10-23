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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProIspPlaySumInfo : AbstractModel
    {
        
        /// <summary>
        /// District/ISP/country/region.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Total traffic in MB.
        /// </summary>
        [JsonProperty("TotalFlux")]
        public float? TotalFlux{ get; set; }

        /// <summary>
        /// Total number of requests.
        /// </summary>
        [JsonProperty("TotalRequest")]
        public ulong? TotalRequest{ get; set; }

        /// <summary>
        /// Average download traffic in MB/s.
        /// </summary>
        [JsonProperty("AvgFluxPerSecond")]
        public float? AvgFluxPerSecond{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TotalFlux", this.TotalFlux);
            this.SetParamSimple(map, prefix + "TotalRequest", this.TotalRequest);
            this.SetParamSimple(map, prefix + "AvgFluxPerSecond", this.AvgFluxPerSecond);
        }
    }
}

