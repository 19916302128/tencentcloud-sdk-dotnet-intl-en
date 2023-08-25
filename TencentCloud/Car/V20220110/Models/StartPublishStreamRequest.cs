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

namespace TencentCloud.Car.V20220110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartPublishStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique user ID, which is customized by you and is not understood by CAR. It will be used as the `StreamId` for pushing streams. For example, if the bound push domain is **abc.livepush.myqcloud.com**, the push address will be **rtmp://abc.livepush.myqcloud.com/live/UserId?txSecret=xxx&txTime=xxx**.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Push parameter, which is a custom parameter carried during stream pushing.
        /// </summary>
        [JsonProperty("PublishStreamArgs")]
        public string PublishStreamArgs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "PublishStreamArgs", this.PublishStreamArgs);
        }
    }
}

