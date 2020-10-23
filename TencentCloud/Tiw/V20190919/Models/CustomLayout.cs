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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomLayout : AbstractModel
    {
        
        /// <summary>
        /// Mixed stream canvas parameter
        /// </summary>
        [JsonProperty("Canvas")]
        public Canvas Canvas{ get; set; }

        /// <summary>
        /// Stream layout. The layout of each stream cannot exceed the canvas area.
        /// </summary>
        [JsonProperty("InputStreamList")]
        public StreamLayout[] InputStreamList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Canvas.", this.Canvas);
            this.SetParamArrayObj(map, prefix + "InputStreamList.", this.InputStreamList);
        }
    }
}

