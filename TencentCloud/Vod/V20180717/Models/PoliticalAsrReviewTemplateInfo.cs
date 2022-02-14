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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PoliticalAsrReviewTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable ASR-based recognition of politically sensitive content. Valid values:
        /// <li>ON</li>
        /// <li>OFF</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Confidence score threshold for human review. If this threshold is reached, human review is needed. If this parameter is left empty, `75` will be used by default. Value range: 0-100
        /// </summary>
        [JsonProperty("ReviewConfidence")]
        public long? ReviewConfidence{ get; set; }

        /// <summary>
        /// Confidence score threshold for determining that something should be blocked. If this threshold is reached, VOD will suggest that the content be blocked. If this parameter is left empty, `100` will be used by default. Value range: 0-100
        /// </summary>
        [JsonProperty("BlockConfidence")]
        public long? BlockConfidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "ReviewConfidence", this.ReviewConfidence);
            this.SetParamSimple(map, prefix + "BlockConfidence", this.BlockConfidence);
        }
    }
}

