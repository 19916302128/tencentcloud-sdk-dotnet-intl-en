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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetFlagRequest : AbstractModel
    {
        
        /// <summary>
        /// Set user UIN
        /// </summary>
        [JsonProperty("OpUin")]
        public ulong? OpUin{ get; set; }

        /// <summary>
        /// Login settings
        /// </summary>
        [JsonProperty("LoginFlag")]
        public LoginActionFlag LoginFlag{ get; set; }

        /// <summary>
        /// Sensitive operation settings
        /// </summary>
        [JsonProperty("ActionFlag")]
        public LoginActionFlag ActionFlag{ get; set; }

        /// <summary>
        /// Remote login settings
        /// </summary>
        [JsonProperty("OffsiteFlag")]
        public OffsiteFlag OffsiteFlag{ get; set; }

        /// <summary>
        /// If MFA requires top-up
        /// </summary>
        [JsonProperty("NeedResetMfa")]
        public ulong? NeedResetMfa{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpUin", this.OpUin);
            this.SetParamObj(map, prefix + "LoginFlag.", this.LoginFlag);
            this.SetParamObj(map, prefix + "ActionFlag.", this.ActionFlag);
            this.SetParamObj(map, prefix + "OffsiteFlag.", this.OffsiteFlag);
            this.SetParamSimple(map, prefix + "NeedResetMfa", this.NeedResetMfa);
        }
    }
}

