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

    public class Rule : AbstractModel
    {
        
        /// <summary>
        /// Feature to be executed.
        /// </summary>
        [JsonProperty("Actions")]
        public Action[] Actions{ get; set; }

        /// <summary>
        /// Feature execution conditions.
        /// Note: If any condition in the array is met, the feature will run.
        /// </summary>
        [JsonProperty("Conditions")]
        public RuleAndConditions[] Conditions{ get; set; }

        /// <summary>
        /// The nested rule.
        /// </summary>
        [JsonProperty("SubRules")]
        public SubRuleItem[] SubRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Actions.", this.Actions);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamArrayObj(map, prefix + "SubRules.", this.SubRules);
        }
    }
}

