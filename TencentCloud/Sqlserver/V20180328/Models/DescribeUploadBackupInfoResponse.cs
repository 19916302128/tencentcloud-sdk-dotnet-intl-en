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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUploadBackupInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Bucket name
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// Bucket location information
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Storage path
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Temporary key ID
        /// </summary>
        [JsonProperty("TmpSecretId")]
        public string TmpSecretId{ get; set; }

        /// <summary>
        /// Temporary key (Key)
        /// </summary>
        [JsonProperty("TmpSecretKey")]
        public string TmpSecretKey{ get; set; }

        /// <summary>
        /// Temporary key (Token)
        /// </summary>
        [JsonProperty("XCosSecurityToken")]
        public string XCosSecurityToken{ get; set; }

        /// <summary>
        /// Temporary key start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Temporary key expiration time
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "TmpSecretId", this.TmpSecretId);
            this.SetParamSimple(map, prefix + "TmpSecretKey", this.TmpSecretKey);
            this.SetParamSimple(map, prefix + "XCosSecurityToken", this.XCosSecurityToken);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

