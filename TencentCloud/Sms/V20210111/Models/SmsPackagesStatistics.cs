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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmsPackagesStatistics : AbstractModel
    {
        
        /// <summary>
        /// The creation time of the package in seconds in the format of UNIX timestamp.
        /// </summary>
        [JsonProperty("PackageCreateTime")]
        public ulong? PackageCreateTime{ get; set; }

        /// <summary>
        /// The effective time of the package in seconds in the format of UNIX timestamp.
        /// </summary>
        [JsonProperty("PackageEffectiveTime")]
        public ulong? PackageEffectiveTime{ get; set; }

        /// <summary>
        /// The expiration time of the package in seconds in the format of UNIX timestamp.
        /// </summary>
        [JsonProperty("PackageExpiredTime")]
        public ulong? PackageExpiredTime{ get; set; }

        /// <summary>
        /// Number of SMS messages in the package
        /// </summary>
        [JsonProperty("PackageAmount")]
        public ulong? PackageAmount{ get; set; }

        /// <summary>
        /// Package type. 0: gifted package; 1: purchased package.
        /// </summary>
        [JsonProperty("PackageType")]
        public ulong? PackageType{ get; set; }

        /// <summary>
        /// Package ID.
        /// </summary>
        [JsonProperty("PackageId")]
        public ulong? PackageId{ get; set; }

        /// <summary>
        /// Current number of used messages in the package.
        /// </summary>
        [JsonProperty("CurrentUsage")]
        public ulong? CurrentUsage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageCreateTime", this.PackageCreateTime);
            this.SetParamSimple(map, prefix + "PackageEffectiveTime", this.PackageEffectiveTime);
            this.SetParamSimple(map, prefix + "PackageExpiredTime", this.PackageExpiredTime);
            this.SetParamSimple(map, prefix + "PackageAmount", this.PackageAmount);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "CurrentUsage", this.CurrentUsage);
        }
    }
}

