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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChcHostDeniedActions : AbstractModel
    {
        
        /// <summary>
        /// CHC instance ID
        /// </summary>
        [JsonProperty("ChcId")]
        public string ChcId{ get; set; }

        /// <summary>
        /// CHC instance status
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Actions not allowed for the current CHC instance
        /// </summary>
        [JsonProperty("DenyActions")]
        public string[] DenyActions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChcId", this.ChcId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArraySimple(map, prefix + "DenyActions.", this.DenyActions);
        }
    }
}

