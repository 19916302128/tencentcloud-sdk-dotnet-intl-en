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

    public class AiReviewTaskTerrorismResult : AbstractModel
    {
        
        /// <summary>
        /// Task status. Valid values: PROCESSING, SUCCESS, FAIL.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Error code. 0: success; other values: failure.
        /// <li>40000: invalid input parameter. Please check it;</li>
        /// <li>60000: invalid source file (e.g., video data is corrupted). Please check whether the source file is normal;</li>
        /// <li>70000: internal service error. Please try again.</li>
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// Error message.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Input of terrorism information detection task in content audit.
        /// </summary>
        [JsonProperty("Input")]
        public AiReviewTerrorismTaskInput Input{ get; set; }

        /// <summary>
        /// Output of terrorism information detection task in content audit.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Output")]
        public AiReviewTerrorismTaskOutput Output{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "Input.", this.Input);
            this.SetParamObj(map, prefix + "Output.", this.Output);
        }
    }
}

