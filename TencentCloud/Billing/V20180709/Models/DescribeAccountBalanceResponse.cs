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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccountBalanceResponse : AbstractModel
    {
        
        /// <summary>
        /// Available account balance in cents, which takes the same calculation rules as `RealBalance`, `CreditBalance`, and `RealCreditBalance`.
        /// </summary>
        [JsonProperty("Balance")]
        public long? Balance{ get; set; }

        /// <summary>
        /// The UIN to query.
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// Available account balance in cents, which takes the same calculation rules as `Balance`, `CreditBalance`, and `RealCreditBalance`.
        /// </summary>
        [JsonProperty("RealBalance")]
        public float? RealBalance{ get; set; }

        /// <summary>
        /// Cash account balance in cents. Currently, this field is not applied.
        /// </summary>
        [JsonProperty("CashAccountBalance")]
        public float? CashAccountBalance{ get; set; }

        /// <summary>
        /// Income account balance in cents. Currently, this field is not applied.
        /// </summary>
        [JsonProperty("IncomeIntoAccountBalance")]
        public float? IncomeIntoAccountBalance{ get; set; }

        /// <summary>
        /// Present account balance in cents. Currently, this field is not applied.
        /// </summary>
        [JsonProperty("PresentAccountBalance")]
        public float? PresentAccountBalance{ get; set; }

        /// <summary>
        /// Frozen amount in cents.
        /// </summary>
        [JsonProperty("FreezeAmount")]
        public float? FreezeAmount{ get; set; }

        /// <summary>
        /// Overdue amount in cents, which is when the available credit balance is negative.
        /// </summary>
        [JsonProperty("OweAmount")]
        public float? OweAmount{ get; set; }

        /// <summary>
        /// Whether overdue payments are allowed. Currently, this field is not applied.
        /// </summary>
        [JsonProperty("IsAllowArrears")]
        public bool? IsAllowArrears{ get; set; }

        /// <summary>
        /// Whether you have a credit limit. Currently, this field is not applied.
        /// </summary>
        [JsonProperty("IsCreditLimited")]
        public bool? IsCreditLimited{ get; set; }

        /// <summary>
        /// Credit limit in cents. Credit limit－available credit balance = consumption amount
        /// </summary>
        [JsonProperty("CreditAmount")]
        public float? CreditAmount{ get; set; }

        /// <summary>
        /// Available credit balance in cents, which takes the same calculation rules as `Balance`, `RealBalance`, and `RealCreditBalance`.
        /// </summary>
        [JsonProperty("CreditBalance")]
        public float? CreditBalance{ get; set; }

        /// <summary>
        /// Available account balance in cents, which takes the same calculation rules as `Balance`, `RealBalance`, and `CreditBalance`.
        /// </summary>
        [JsonProperty("RealCreditBalance")]
        public float? RealCreditBalance{ get; set; }

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
            this.SetParamSimple(map, prefix + "Balance", this.Balance);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "RealBalance", this.RealBalance);
            this.SetParamSimple(map, prefix + "CashAccountBalance", this.CashAccountBalance);
            this.SetParamSimple(map, prefix + "IncomeIntoAccountBalance", this.IncomeIntoAccountBalance);
            this.SetParamSimple(map, prefix + "PresentAccountBalance", this.PresentAccountBalance);
            this.SetParamSimple(map, prefix + "FreezeAmount", this.FreezeAmount);
            this.SetParamSimple(map, prefix + "OweAmount", this.OweAmount);
            this.SetParamSimple(map, prefix + "IsAllowArrears", this.IsAllowArrears);
            this.SetParamSimple(map, prefix + "IsCreditLimited", this.IsCreditLimited);
            this.SetParamSimple(map, prefix + "CreditAmount", this.CreditAmount);
            this.SetParamSimple(map, prefix + "CreditBalance", this.CreditBalance);
            this.SetParamSimple(map, prefix + "RealCreditBalance", this.RealCreditBalance);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

