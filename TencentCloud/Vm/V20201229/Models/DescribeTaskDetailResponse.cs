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

namespace TencentCloud.Vm.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// This field is used to return the task ID (in the `Results` parameter) after a video moderation task is created. It is used to identify the moderation task for which to query the details.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// This field is used to return the data ID parameter passed in when the video moderation API is called for easier data identification and management.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// This field is used to return the `BizType` parameter passed in when the video moderation API is called for easier data identification and management.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// This field is used to return the task name in the `TaskInput` parameter passed in when the video moderation API is called for easier task identification and management.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// This field is used to return the task status of the queried content.
        /// <br>Valid values: **FINISH** (task completed), **PENDING** (task pending), **RUNNING** (task in progress), **ERROR** (task error), **CANCELLED** (task canceled).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// This field is used to return the video moderation type passed in when the video moderation API is called. Valid values: **VIDEO** (video on demand), **LIVE_VIDEO** (video live streaming). Default value: VIDEO.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// This field is used to return the operation suggestion for the maliciousness tag. When you get the determination result, the returned value indicates the operation suggested by the system. We recommend you handle different types of violations and suggestions according to your business needs. <br>Returned values: **Block**, **Review**, **Pass**.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// This field is used to return the maliciousness tag in the detection result.<br>Returned values: **Normal**: normal; **Porn**: pornographic; **Abuse**: abusive; **Ad**: advertising; **Custom**: custom type of non-compliant content and other offensive, unsafe, or inappropriate types of content.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Labels")]
        public TaskLabel[] Labels{ get; set; }

        /// <summary>
        /// This field is used to return the details of the input media file, including encoding/decoding formats and segment length. For details, see the description of the `MediaInfo` data structure.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MediaInfo")]
        public MediaInfo MediaInfo{ get; set; }

        /// <summary>
        /// This field is used to return the media content information of the moderation service, mainly including the input file type and access URL.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InputInfo")]
        public InputInfo InputInfo{ get; set; }

        /// <summary>
        /// This field is used to return the creation time of the queried task in ISO 8601 format.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// This field is used to return the last update time of the queried task in ISO 8601 format.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// This field is used to return the moderation result of the frames captured from the video. For the detailed returned content, see the description of the `ImageSegments` data structure.<br>Note: the data is valid for 24 hours. To extend the storage period, set it in the configured COS bucket.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageSegments")]
        public ImageSegments[] ImageSegments{ get; set; }

        /// <summary>
        /// This field is used to return the moderation result of the audio in the video. For the detailed returned content, see the description of the `AudioSegments` data structure.<br>Note: the data is valid for 24 hours. To extend the storage period, set it in the configured COS bucket.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AudioSegments")]
        public AudioSegments[] AudioSegments{ get; set; }

        /// <summary>
        /// When the task status is `Error`, the type of the error will be returned. Valid values: **DECODE_ERROR**: decoding failed (the input resource may contain video that cannot be decoded).
        /// **URL_ERROR**: download address verification failed.
        /// **TIMEOUT_ERROR**: processing timed out. When the task status is not `Error`, null will be returned by default.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorType")]
        public string ErrorType{ get; set; }

        /// <summary>
        /// If the task status is `Error`, this field will return the error message; otherwise, null will be returned by default.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorDescription")]
        public string ErrorDescription{ get; set; }

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
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamObj(map, prefix + "MediaInfo.", this.MediaInfo);
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamArrayObj(map, prefix + "ImageSegments.", this.ImageSegments);
            this.SetParamArrayObj(map, prefix + "AudioSegments.", this.AudioSegments);
            this.SetParamSimple(map, prefix + "ErrorType", this.ErrorType);
            this.SetParamSimple(map, prefix + "ErrorDescription", this.ErrorDescription);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

