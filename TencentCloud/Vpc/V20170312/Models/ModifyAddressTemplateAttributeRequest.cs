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

    public class ModifyAddressTemplateAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// IP address template instance ID, such as `ipm-mdunqeb6`.
        /// </summary>
        [JsonProperty("AddressTemplateId")]
        public string AddressTemplateId{ get; set; }

        /// <summary>
        /// IP address template name.
        /// </summary>
        [JsonProperty("AddressTemplateName")]
        public string AddressTemplateName{ get; set; }

        /// <summary>
        /// Address information, including IP, CIDR and IP address range.
        /// </summary>
        [JsonProperty("Addresses")]
        public string[] Addresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressTemplateId", this.AddressTemplateId);
            this.SetParamSimple(map, prefix + "AddressTemplateName", this.AddressTemplateName);
            this.SetParamArraySimple(map, prefix + "Addresses.", this.Addresses);
        }
    }
}

