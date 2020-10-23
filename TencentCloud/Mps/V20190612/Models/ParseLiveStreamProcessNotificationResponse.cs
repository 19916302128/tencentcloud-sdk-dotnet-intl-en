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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParseLiveStreamProcessNotificationResponse : AbstractModel
    {
        
        /// <summary>
        /// Result type of live stream processing. Valid values:
        /// <li>AiReviewResult: Content audit result;</li>
        /// <li>ProcessEof: Live stream processing has been completed.</li>
        /// </summary>
        [JsonProperty("NotificationType")]
        public string NotificationType{ get; set; }

        /// <summary>
        /// Video processing task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Information of a live stream processing error, which is valid when `NotificationType` is `ProcessEof`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessEofInfo")]
        public LiveStreamProcessErrorInfo ProcessEofInfo{ get; set; }

        /// <summary>
        /// Content audit result, which is valid when `NotificationType` is `AiReviewResult`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AiReviewResultInfo")]
        public LiveStreamAiReviewResultInfo AiReviewResultInfo{ get; set; }

        /// <summary>
        /// Content recognition result, which is valid if `NotificationType` is `AiRecognitionResult`.
        /// </summary>
        [JsonProperty("AiRecognitionResultInfo")]
        public LiveStreamAiRecognitionResultInfo AiRecognitionResultInfo{ get; set; }

        /// <summary>
        /// The ID used for deduplication. If there was a request with the same ID in the last seven days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or an empty string is entered, no deduplication will be performed.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

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
            this.SetParamSimple(map, prefix + "NotificationType", this.NotificationType);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamObj(map, prefix + "ProcessEofInfo.", this.ProcessEofInfo);
            this.SetParamObj(map, prefix + "AiReviewResultInfo.", this.AiReviewResultInfo);
            this.SetParamObj(map, prefix + "AiRecognitionResultInfo.", this.AiRecognitionResultInfo);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

