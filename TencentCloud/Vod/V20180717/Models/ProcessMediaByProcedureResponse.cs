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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcessMediaByProcedureResponse : AbstractModel
    {
        
        /// <summary>
        /// The task ID for the task type `Procedure`, if the task flow specified by `ProcedureName` includes one or more of `MediaProcessTask`, `AiAnalysisTask`, `AiRecognitionTask`, the task specified by this parameter will be executed.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// The task ID for the task type `ReviewAudioVideo`, if the task flow specified by `ProcedureName` includes `ReviewAudioVideoTask`, the task specified by this parameter will be executed.
        /// </summary>
        [JsonProperty("ReviewAudioVideoTaskId")]
        public string ReviewAudioVideoTaskId{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "ReviewAudioVideoTaskId", this.ReviewAudioVideoTaskId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

