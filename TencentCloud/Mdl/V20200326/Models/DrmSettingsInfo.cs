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
        /// Whether to enable DRM encryption. Valid value: CLOSE/OPEN. Default value: CLOSE.
        /// Currently, this is supported only for HLS/DASH/HLS_ARCHIVE/DASH_ARCHIVE.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// `ContentId` of DRM encryption, which will be automatically created if this parameter is left empty.
        /// For more information on the custom creation method, please visit https://cloud.tencent.com/document/product/1000/40960
        /// </summary>
        [JsonProperty("ContentId")]
        public string ContentId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "ContentId", this.ContentId);
        }
    }
}

