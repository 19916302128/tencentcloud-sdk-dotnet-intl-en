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

    public class ModifyFlowLogAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// The VPC ID or the unified ID. We recommend you use the unified ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The unique ID of the flow log.
        /// </summary>
        [JsonProperty("FlowLogId")]
        public string FlowLogId{ get; set; }

        /// <summary>
        /// The name of the flow log instance.
        /// </summary>
        [JsonProperty("FlowLogName")]
        public string FlowLogName{ get; set; }

        /// <summary>
        /// The description of the flow log instance.
        /// </summary>
        [JsonProperty("FlowLogDescription")]
        public string FlowLogDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "FlowLogId", this.FlowLogId);
            this.SetParamSimple(map, prefix + "FlowLogName", this.FlowLogName);
            this.SetParamSimple(map, prefix + "FlowLogDescription", this.FlowLogDescription);
        }
    }
}

