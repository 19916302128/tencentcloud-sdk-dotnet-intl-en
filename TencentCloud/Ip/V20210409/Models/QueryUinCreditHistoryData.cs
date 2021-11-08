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

namespace TencentCloud.Ip.V20210409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryUinCreditHistoryData : AbstractModel
    {
        
        /// <summary>
        /// Credit allocatee UIN
        /// </summary>
        [JsonProperty("CreditAssignUin")]
        public ulong? CreditAssignUin{ get; set; }

        /// <summary>
        /// Allocation time
        /// </summary>
        [JsonProperty("AssginTime")]
        public string AssginTime{ get; set; }

        /// <summary>
        /// Operator
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Allocated credit value
        /// </summary>
        [JsonProperty("CreditAmount")]
        public float? CreditAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreditAssignUin", this.CreditAssignUin);
            this.SetParamSimple(map, prefix + "AssginTime", this.AssginTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "CreditAmount", this.CreditAmount);
        }
    }
}

