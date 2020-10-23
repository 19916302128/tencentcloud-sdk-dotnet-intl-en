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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogFilter : AbstractModel
    {
        
        /// <summary>
        /// Values of `filter.RetCode` include:
        /// not0, indicating that only logs of failed execution will be returned.
        /// is0, indicating that only logs of successful execution will be returned.
        /// TimeLimitExceeded, indicating that logs of function invocations which timed out will be returned.
        /// ResourceLimitExceeded, indicating that logs of function invocations during which resources exceeded the upper limit will be returned.
        /// UserCodeException, indicating that logs of function invocations during which a user code error occurred will be returned.
        /// Blank, indicating that all logs will be returned.
        /// </summary>
        [JsonProperty("RetCode")]
        public string RetCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RetCode", this.RetCode);
        }
    }
}

