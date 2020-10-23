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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceTemplateGroup : AbstractModel
    {
        
        /// <summary>
        /// Protocol port template group instance ID, such as `ppmg-2klmrefu`.
        /// </summary>
        [JsonProperty("ServiceTemplateGroupId")]
        public string ServiceTemplateGroupId{ get; set; }

        /// <summary>
        /// Protocol port template group name.
        /// </summary>
        [JsonProperty("ServiceTemplateGroupName")]
        public string ServiceTemplateGroupName{ get; set; }

        /// <summary>
        /// Protocol port template instance ID.
        /// </summary>
        [JsonProperty("ServiceTemplateIdSet")]
        public string[] ServiceTemplateIdSet{ get; set; }

        /// <summary>
        /// Creation Time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Protocol port template instance information.
        /// </summary>
        [JsonProperty("ServiceTemplateSet")]
        public ServiceTemplate[] ServiceTemplateSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceTemplateGroupId", this.ServiceTemplateGroupId);
            this.SetParamSimple(map, prefix + "ServiceTemplateGroupName", this.ServiceTemplateGroupName);
            this.SetParamArraySimple(map, prefix + "ServiceTemplateIdSet.", this.ServiceTemplateIdSet);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "ServiceTemplateSet.", this.ServiceTemplateSet);
        }
    }
}

