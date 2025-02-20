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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CacheConfigParameters : AbstractModel
    {
        
        /// <summary>
        /// Follow origin server cache configuration. only one of followorigin, nocache, customtime can have switch set to on.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("FollowOrigin")]
        public FollowOrigin FollowOrigin{ get; set; }

        /// <summary>
        /// No cache configuration. only one of followorigin, nocache, customtime can have switch set to on.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("NoCache")]
        public NoCache NoCache{ get; set; }

        /// <summary>
        /// Custom cache time configuration. only one of followorigin, nocache, customtime can have switch set to on.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("CustomTime")]
        public CacheConfigCustomTime CustomTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FollowOrigin.", this.FollowOrigin);
            this.SetParamObj(map, prefix + "NoCache.", this.NoCache);
            this.SetParamObj(map, prefix + "CustomTime.", this.CustomTime);
        }
    }
}

