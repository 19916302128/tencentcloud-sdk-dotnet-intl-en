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

    public class GetFaceIdResultIntlResponse : AbstractModel
    {
        
        /// <summary>
        /// The return code of the verification result.
        /// 0: Succeeded.
        /// 1001: System error.
        /// 1004: Liveness detection and face comparison failed.
        /// 2004: The image passed in is too large or too small.
        /// 2012: Several faces were detected.
        /// 2013: No face was detected, or the face detected was incomplete.
        /// 2014: The image resolution is too low or the quality does not meet the requirements.
        /// 2015: Face comparison failed.
        /// 2016: The similarity did not reach the standard passing threshold.
        /// -999: The verification process wasn't finished.
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// The description of the verification result.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The best frame screenshot (in Base64) obtained during the verification.
        /// </summary>
        [JsonProperty("BestFrame")]
        public string BestFrame{ get; set; }

        /// <summary>
        /// The video file (Base64) for verification.
        /// </summary>
        [JsonProperty("Video")]
        public string Video{ get; set; }

        /// <summary>
        /// The similarity, with a value range of 0-100. A greater value indicates higher similarity. This parameter is returned only in the `compare` (liveness detection and face comparison) mode.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Similarity")]
        public float? Similarity{ get; set; }

        /// <summary>
        /// The pass-through parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

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
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "BestFrame", this.BestFrame);
            this.SetParamSimple(map, prefix + "Video", this.Video);
            this.SetParamSimple(map, prefix + "Similarity", this.Similarity);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

