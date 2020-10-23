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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHostsRequest : AbstractModel
    {
        
        /// <summary>
        /// <li><strong>zone</strong></li>
        /// <p style="padding-left: 30px;">Filter results by **<strong>availability zones</strong>**. For example, availability zone: ap-guangzhou-1;</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p><p style="padding-left: 30px;">Valid values: <a href="https://intl.cloud.tencent.com/document/product/213/6091?from_cn_redirect=1">list of availability zones</a></p>
        /// <li><strong>project-id</strong></li>
        /// <p style="padding-left: 30px;">Filter results by **<strong>project ID</strong>**. You can query the existing project list through the [DescribeProject](https://intl.cloud.tencent.com/document/api/378/4400?from_cn_redirect=1) API or [CVM console](https://console.cloud.tencent.com/cvm/index), or create a project by calling the [AddProject](https://intl.cloud.tencent.com/document/api/378/4398?from_cn_redirect=1) API. For example, project ID: 1002189;</p><p style="padding-left: 30px;">Type: Integer</p><p style="padding-left: 30px;">Required: no</p>
        /// <li><strong>host-id</strong></li>
        /// <p style="padding-left: 30px;">Filter results by **<strong>[CDH](https://intl.cloud.tencent.com/document/product/416?from_cn_redirect=1) ID</strong>**. For example, [CDH](https://intl.cloud.tencent.com/document/product/416?from_cn_redirect=1) ID: host-xxxxxxxx;</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p>
        /// <li><strong>state</strong></li>
        /// <p style="padding-left: 30px;">Filter results by **<strong>CDH instance name</strong>**. </p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p>
        /// <li><strong>state</strong></li>
        /// <p style="padding-left: 30px;">Filter results by **<strong>CDH instance status </strong>**. (PENDING: creating | LAUNCH_FAILURE: creation failed | RUNNING: running | EXPIRED: expired)</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p>
        /// Each request can have up to 10 `Filters` and 5 `Filters.Values`.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset; default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of results returned; default value: 20; maximum: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


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

