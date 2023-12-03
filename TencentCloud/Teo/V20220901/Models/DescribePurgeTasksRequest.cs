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

    public class DescribePurgeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// ZoneId. 
        /// The parameter is required.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Start time of the query.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of the query.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Offset for paginated queries. Default value: `0`.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Limit on paginated queries. Default value: `20`. Maximum value: `1000`.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filtering condition. The maximum value of Filters.Values is 20. Detailed filtering conditions: <li>job-id<br>u2003u2003 Filter based on [<strong>task ID</strong>]. job-id format: 1379afjk91u32h. Multiple values are not supported. <br>u2003u2003 Type: String<br>u2003u2003 Required: No<br>u2003u2003 Fuzz query: Not supported.</li><li>target<br>u2003u2003 Filter based on: [strong>target resource information</strong>. target format: http://www.qq.com/1.txt or tag1. Multiple values are not supported.<br>u2003u2003 Type: String<br>u2003u2003 Required: No<br>u2003u2003 Fuzz query: Not supported.</li><li>domains<br>u2003u2003 Filter based on [<strong>domain name</strong>]. domains format: www.qq.com<br>u2003u2003 Type: String<br>u2003u2003 Required: No<br>u2003u2003 Fuzz query: Not supported. </li><li>statuses<br>u2003u2003 Filter based on <strong>task status</strong>.<br>u2003u2003 Required: No<br>u2003u2003 Fuzz query: Not supported. <br>u2003u2003 Options:<br>u2003u2003 processing: Processing<br>u2003u2003 success: Success<br>u2003u2003 failed: Failure<br>u2003u2003 timeout: Timeout</li><li>type<br>u2003u2003 Filter based on [<strong>cleared cache type</strong>]. Multiple values are not supported. <br>u2003u2003 Type: String<br>u2003u2003 Required: No<br>u2003u2003 Fuzz query: Not supported.<br>u2003u2003 Options:<br>u2003u2003 purge_url: URL<br>u2003u2003 purge_prefix: Prefix<br>u2003u2003 purge_all: All cache content<br>u2003u2003 purge_host: Hostname<br>u2003u2003 purge_cache_tag: CacheTag</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

