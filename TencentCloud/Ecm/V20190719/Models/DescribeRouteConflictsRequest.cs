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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRouteConflictsRequest : AbstractModel
    {
        
        /// <summary>
        /// Route table instance ID, such as `rtb-azd4dt1c`.
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// List of conflicting destination ports to be checked.
        /// </summary>
        [JsonProperty("DestinationCidrBlocks")]
        public string[] DestinationCidrBlocks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamArraySimple(map, prefix + "DestinationCidrBlocks.", this.DestinationCidrBlocks);
        }
    }
}

