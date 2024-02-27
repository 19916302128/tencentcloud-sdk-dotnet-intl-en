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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetCardVerificationResultResponse : AbstractModel
    {
        
        /// <summary>
        /// Pass status. When Warning and Rejected are returned, please check the specific reasons in the WarnInfo structure return. Example values are as follows:
        /// Passed
        /// Warning
        /// Rejected
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Warning information returned by document verification.
        /// </summary>
        [JsonProperty("WarnInfo")]
        public string[] WarnInfo{ get; set; }

        /// <summary>
        /// Nationality code. Complies with standard ISO 3166-1 alpha-3. 
        /// 
        /// Example value: IDN
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// Card Type. The supported options are:
        /// ID_CARD
        /// PASSPORT
        /// DRIVING_LICENSE
        /// AUTO
        /// 
        /// Example value: ID_CARD
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }

        /// <summary>
        /// Subtype of the ID document.
        /// </summary>
        [JsonProperty("CardSubType")]
        public string CardSubType{ get; set; }

        /// <summary>
        /// Recognition results of the ID document.
        /// </summary>
        [JsonProperty("CardInfo")]
        public CardInfo CardInfo{ get; set; }

        /// <summary>
        /// The token used to identify an verification process. It can be used to get the verification result after the process is completed.
        /// </summary>
        [JsonProperty("IDVerificationToken")]
        public string IDVerificationToken{ get; set; }

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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "WarnInfo.", this.WarnInfo);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "CardSubType", this.CardSubType);
            this.SetParamObj(map, prefix + "CardInfo.", this.CardInfo);
            this.SetParamSimple(map, prefix + "IDVerificationToken", this.IDVerificationToken);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

