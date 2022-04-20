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

namespace TencentCloud.Tag.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TagResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// Six-segment resource description list. Tencent Cloud uses a six-segment value to describe a resource. For more information, see [CAM](https://intl.cloud.tencent.com/document/product/598/67350?from_cn_redirect=1) > Overview > API List > Six-Segment Resource Information.
        /// For example, ResourceList.1 = qcs::${ServiceType}:${Region}:${Account}:${ResourcePreifx}/${ResourceId}.
        /// Value range of N: 0–9
        /// </summary>
        [JsonProperty("ResourceList")]
        public string[] ResourceList{ get; set; }

        /// <summary>
        /// Tag key and value.
        /// If multiple tags are specified, all such tags will be created and bound to the specified resources.
        /// For each resource, each tag key can have only one value. If you try to add an existing tag key, the corresponding tag value will be updated to the new value.
        /// Non-existent tags will be automatically created.
        /// Value range of N: 0–9
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ResourceList.", this.ResourceList);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

