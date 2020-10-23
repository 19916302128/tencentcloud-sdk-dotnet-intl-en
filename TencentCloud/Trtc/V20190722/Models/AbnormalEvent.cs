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

    public class AbnormalEvent : AbstractModel
    {
        
        /// <summary>
        /// Exception event ID. For specific values, please see Appendix. Exceptional Experience ID Mapping Table.
        /// </summary>
        [JsonProperty("AbnormalEventId")]
        public ulong? AbnormalEventId{ get; set; }

        /// <summary>
        /// Remote user ID. If this parameter is left empty, it indicates that the exception event is not caused by the remote user.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PeerId")]
        public string PeerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AbnormalEventId", this.AbnormalEventId);
            this.SetParamSimple(map, prefix + "PeerId", this.PeerId);
        }
    }
}

