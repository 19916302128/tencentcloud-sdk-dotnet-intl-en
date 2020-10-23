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

    public class DescribeResourceTagsByResourceIdsRequest : AbstractModel
    {
        
        /// <summary>
        /// Service type.
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// Resource prefix.
        /// </summary>
        [JsonProperty("ResourcePrefix")]
        public string ResourcePrefix{ get; set; }

        /// <summary>
        /// Unique resource ID.
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string[] ResourceIds{ get; set; }

        /// <summary>
        /// The resource's region.
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// Data offset. The default value is 0. Must be an integral multiple of the `Limit` parameter.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Page size. The default value is 0.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ResourcePrefix", this.ResourcePrefix);
            this.SetParamArraySimple(map, prefix + "ResourceIds.", this.ResourceIds);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

