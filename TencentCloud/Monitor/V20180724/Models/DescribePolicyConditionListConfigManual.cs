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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyConditionListConfigManual : AbstractModel
    {
        
        /// <summary>
        /// Check method.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CalcType")]
        public DescribePolicyConditionListConfigManualCalcType CalcType{ get; set; }

        /// <summary>
        /// Threshold.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CalcValue")]
        public DescribePolicyConditionListConfigManualCalcValue CalcValue{ get; set; }

        /// <summary>
        /// Duration.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ContinueTime")]
        public DescribePolicyConditionListConfigManualContinueTime ContinueTime{ get; set; }

        /// <summary>
        /// Data period.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Period")]
        public DescribePolicyConditionListConfigManualPeriod Period{ get; set; }

        /// <summary>
        /// Number of periods.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PeriodNum")]
        public DescribePolicyConditionListConfigManualPeriodNum PeriodNum{ get; set; }

        /// <summary>
        /// Statistics method.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("StatType")]
        public DescribePolicyConditionListConfigManualStatType StatType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CalcType.", this.CalcType);
            this.SetParamObj(map, prefix + "CalcValue.", this.CalcValue);
            this.SetParamObj(map, prefix + "ContinueTime.", this.ContinueTime);
            this.SetParamObj(map, prefix + "Period.", this.Period);
            this.SetParamObj(map, prefix + "PeriodNum.", this.PeriodNum);
            this.SetParamObj(map, prefix + "StatType.", this.StatType);
        }
    }
}

