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

    public class CreatePurgeTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the site.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Purging mode. Valid values: 
        /// <li>`purge_url`: Purge by URL;</li>
        /// <li>`purge_prefix`: Purge by directory;</li>
        /// <li>`purge_host`: Purge by hostname;</li>
        /// <li>`purge_all`: Puege all cache;</li>
        /// <li>`purge_cache_tag`: Purge by cache tag.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Resource to be purged, which depends on the `Type` field. 
        /// 1. When `Type = purge_host`: 
        /// Enter the hostname, such as www.example.com and foo.bar.example.com. 
        /// 2. When `Type = purge_prefix`: 
        /// Enter the prefix, such as http://www.example.com/example/. 
        /// 3. When `Type = purge_url`: 
        /// Enter the URL, such as https://www.example.com/example.jpg. 
        /// 4. When `Type = purge_all`: 
        /// `Targets` can be left empty. 
        /// 5. When `Type = purge_cache_tag`: 
        /// Enter the cache tag, such as tag1. 
        /// Note: The number of submitted tasks is limited by the quota of the plan. For details, see [Billing Overview](https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Targets")]
        public string[] Targets{ get; set; }

        /// <summary>
        /// Specifies whether to transcode non-ASCII URLs according to RFC3986.
        /// Note that if it’s enabled, the purging is based on the converted URLs.
        /// </summary>
        [JsonProperty("EncodeUrl")]
        [System.Obsolete]
        public bool? EncodeUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamArraySimple(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "EncodeUrl", this.EncodeUrl);
        }
    }
}

