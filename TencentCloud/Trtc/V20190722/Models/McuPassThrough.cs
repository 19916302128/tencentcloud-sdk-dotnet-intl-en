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

    public class McuPassThrough : AbstractModel
    {
        
        /// <summary>
        /// The payload of the pass-through SEI.
        /// </summary>
        [JsonProperty("PayloadContent")]
        public string PayloadContent{ get; set; }

        /// <summary>
        /// The payload type of the SEI message. Value range: 5 and 100-254 (244 is used internally by Tencent Cloud for timestamps).
        /// </summary>
        [JsonProperty("PayloadType")]
        public ulong? PayloadType{ get; set; }

        /// <summary>
        /// This parameter is required only if `PayloadType` is 5. It must be a 32-character hexadecimal string. If `PayloadType` is not 5, this parameter will be ignored.
        /// </summary>
        [JsonProperty("PayloadUuid")]
        public string PayloadUuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayloadContent", this.PayloadContent);
            this.SetParamSimple(map, prefix + "PayloadType", this.PayloadType);
            this.SetParamSimple(map, prefix + "PayloadUuid", this.PayloadUuid);
        }
    }
}

