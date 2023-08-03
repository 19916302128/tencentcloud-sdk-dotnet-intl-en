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

    public class Hsts : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable the configuration. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// MaxAge (in seconds). The maximum value is 1 day. 
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxAge")]
        public long? MaxAge{ get; set; }

        /// <summary>
        /// Whether to contain subdomain names. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IncludeSubDomains")]
        public string IncludeSubDomains{ get; set; }

        /// <summary>
        /// Whether to enable preloading. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Preload")]
        public string Preload{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "MaxAge", this.MaxAge);
            this.SetParamSimple(map, prefix + "IncludeSubDomains", this.IncludeSubDomains);
            this.SetParamSimple(map, prefix + "Preload", this.Preload);
        }
    }
}

