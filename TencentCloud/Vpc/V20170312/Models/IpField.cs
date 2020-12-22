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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpField : AbstractModel
    {
        
        /// <summary>
        /// Country/region field
        /// </summary>
        [JsonProperty("Country")]
        public bool? Country{ get; set; }

        /// <summary>
        /// Province/municipality field
        /// </summary>
        [JsonProperty("Province")]
        public bool? Province{ get; set; }

        /// <summary>
        /// City field
        /// </summary>
        [JsonProperty("City")]
        public bool? City{ get; set; }

        /// <summary>
        /// Urban area field
        /// </summary>
        [JsonProperty("Region")]
        public bool? Region{ get; set; }

        /// <summary>
        /// Access ISP field
        /// </summary>
        [JsonProperty("Isp")]
        public bool? Isp{ get; set; }

        /// <summary>
        /// ISP backbone network’s AS field
        /// </summary>
        [JsonProperty("AsName")]
        public bool? AsName{ get; set; }

        /// <summary>
        /// AS ID
        /// </summary>
        [JsonProperty("AsId")]
        public bool? AsId{ get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [JsonProperty("Comment")]
        public bool? Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "AsName", this.AsName);
            this.SetParamSimple(map, prefix + "AsId", this.AsId);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

