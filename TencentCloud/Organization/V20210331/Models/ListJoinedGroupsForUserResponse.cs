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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListJoinedGroupsForUserResponse : AbstractModel
    {
        
        /// <summary>
        /// Token for querying the next page of returned results. Note: This parameter is displayed only when IsTruncated is true.
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// Total number of data entries that meet the request parameter conditions.
        /// </summary>
        [JsonProperty("TotalCounts")]
        public long? TotalCounts{ get; set; }

        /// <summary>
        /// Maximum number of data entries per page.
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// Whether the returned result is truncated. Valid values: true: truncated; false: not truncated.
        /// </summary>
        [JsonProperty("IsTruncated")]
        public bool? IsTruncated{ get; set; }

        /// <summary>
        /// List of user groups joined by the user.
        /// </summary>
        [JsonProperty("JoinedGroups")]
        public JoinedGroups[] JoinedGroups{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "TotalCounts", this.TotalCounts);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "IsTruncated", this.IsTruncated);
            this.SetParamArrayObj(map, prefix + "JoinedGroups.", this.JoinedGroups);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

