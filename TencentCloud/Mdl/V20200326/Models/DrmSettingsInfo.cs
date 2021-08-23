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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DrmSettingsInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable DRM encryption. Valid values: `CLOSE` (disable), `OPEN` (enable). Default value: `CLOSE`
        /// DRM encryption is supported only for HLS, DASH, HLS_ARCHIVE, DASH_ARCHIVE, HLS_MEDIAPACKAGE, and DASH_MEDIAPACKAGE outputs.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// This parameter can be set to `CustomDRMKeys` or left empty.
        /// CustomDRMKeys means encryption keys customized by users.
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// If `Scheme` is set to `CustomDRMKeys`, this parameter is required and should be specified by the user.
        /// </summary>
        [JsonProperty("ContentId")]
        public string ContentId{ get; set; }

        /// <summary>
        /// The key customized by the content user, which is required when `Scheme` is set to CustomDRMKeys.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Keys")]
        public DrmKey[] Keys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamSimple(map, prefix + "ContentId", this.ContentId);
            this.SetParamArrayObj(map, prefix + "Keys.", this.Keys);
        }
    }
}

