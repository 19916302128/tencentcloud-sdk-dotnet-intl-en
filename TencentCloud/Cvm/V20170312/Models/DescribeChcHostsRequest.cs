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

    public class DescribeChcHostsRequest : AbstractModel
    {
        
        /// <summary>
        /// CHC host ID. Up to 100 instances per request is allowed. `ChcIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("ChcIds")]
        public string[] ChcIds{ get; set; }

        /// <summary>
        /// <li><strong>zone</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>availability zone</strong>, such as `ap-guangzhou-1`.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p><p style="padding-left: 30px;">Valid values: See <a href="https://intl.cloud.tencent.com/document/product/213/6091?from_cn_redirect=1">Regions and Availability Zones</a></p>
        /// <li><strong>instance-name</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>instance name</strong>.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p>
        /// <li><strong>instance-state</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>instance status</strong>. For status details, see [InstanceStatus](https://intl.cloud.tencent.com/document/api/213/15753?from_cn_redirect=1#InstanceStatus).</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p>
        /// <li><strong>device-type</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>device type</strong>.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p>
        /// <li><strong>vpc-id</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>unique VPC ID</strong>.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p>
        /// <li><strong>subnet-id</strong></li>
        /// <p style="padding-left: 30px;">Filter by the <strong>unique VPC subnet ID</strong>.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Optional</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// The offset. Default value: `0`. For more information on `Offset`, see the relevant sections in API [Introduction](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// The number of returned results. Default value: `20`. Maximum value: `100`. For more information on `Limit`, see the relevant sections in API [Introduction](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ChcIds.", this.ChcIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

