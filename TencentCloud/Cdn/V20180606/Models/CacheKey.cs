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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CacheKey : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable full-path cache
        /// `on`: enables full-path cache (i.e., disables Ignore Query String)
        /// `off`: disables full-path cache (i.e., enables Ignore Query String)
        /// </summary>
        [JsonProperty("FullUrlCache")]
        public string FullUrlCache{ get; set; }

        /// <summary>
        /// Whether caches are case insensitive
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public string IgnoreCase{ get; set; }

        /// <summary>
        /// Request parameter contained in `CacheKey`
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QueryString")]
        public QueryStringKey QueryString{ get; set; }

        /// <summary>
        /// Cookie contained in `CacheKey`
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Cookie")]
        public CookieKey Cookie{ get; set; }

        /// <summary>
        /// Request header contained in `CacheKey`
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Header")]
        public HeaderKey Header{ get; set; }

        /// <summary>
        /// Custom string contained in `CacheKey`
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CacheTag")]
        public CacheTagKey CacheTag{ get; set; }

        /// <summary>
        /// Request protocol contained in `CacheKey`
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Scheme")]
        public SchemeKey Scheme{ get; set; }

        /// <summary>
        /// Path-based cache key configuration
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("KeyRules")]
        public KeyRule[] KeyRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullUrlCache", this.FullUrlCache);
            this.SetParamSimple(map, prefix + "IgnoreCase", this.IgnoreCase);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
            this.SetParamObj(map, prefix + "Cookie.", this.Cookie);
            this.SetParamObj(map, prefix + "Header.", this.Header);
            this.SetParamObj(map, prefix + "CacheTag.", this.CacheTag);
            this.SetParamObj(map, prefix + "Scheme.", this.Scheme);
            this.SetParamArrayObj(map, prefix + "KeyRules.", this.KeyRules);
        }
    }
}

