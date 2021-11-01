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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMachineGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// <br><li> machineGroupName
        /// 
        /// Filter by **machine group name**.
        /// Type: String
        /// 
        /// Required: no
        /// 
        /// <br><li> machineGroupId
        /// 
        /// Filter by **machine group ID**.
        /// Type: String
        /// 
        /// Required: no
        /// 
        /// <br><li> tagKey
        /// 
        /// Filter by **tag key**.
        /// 
        /// Type: String
        /// 
        /// Required: no
        /// 
        /// <br><li> tag:tagKey
        /// 
        /// Filter by **tag key-value pair**. The `tagKey` should be replaced with a specified tag key.
        /// Type: String
        /// 
        /// Required: no
        /// 
        /// 
        /// Each request can contain up to 10 `Filters` and 5 `Filter.Values`.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Page offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Maximum number of entries per page. Default value: 20. Maximum value: 100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

