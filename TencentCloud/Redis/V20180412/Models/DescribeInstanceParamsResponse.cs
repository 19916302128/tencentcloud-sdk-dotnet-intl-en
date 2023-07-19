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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceParamsResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of the parameter lists
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// Instance parameter in Enum type
        /// </summary>
        [JsonProperty("InstanceEnumParam")]
        public InstanceEnumParam[] InstanceEnumParam{ get; set; }

        /// <summary>
        /// Instance parameter in Integer type
        /// </summary>
        [JsonProperty("InstanceIntegerParam")]
        public InstanceIntegerParam[] InstanceIntegerParam{ get; set; }

        /// <summary>
        /// Instance parameter in Char type
        /// </summary>
        [JsonProperty("InstanceTextParam")]
        public InstanceTextParam[] InstanceTextParam{ get; set; }

        /// <summary>
        /// Instance parameter in Multi type
        /// </summary>
        [JsonProperty("InstanceMultiParam")]
        public InstanceMultiParam[] InstanceMultiParam{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "InstanceEnumParam.", this.InstanceEnumParam);
            this.SetParamArrayObj(map, prefix + "InstanceIntegerParam.", this.InstanceIntegerParam);
            this.SetParamArrayObj(map, prefix + "InstanceTextParam.", this.InstanceTextParam);
            this.SetParamArrayObj(map, prefix + "InstanceMultiParam.", this.InstanceMultiParam);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

