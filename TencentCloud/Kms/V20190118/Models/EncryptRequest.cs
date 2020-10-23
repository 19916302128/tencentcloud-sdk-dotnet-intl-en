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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EncryptRequest : AbstractModel
    {
        
        /// <summary>
        /// Globally unique ID of the CMK generated by calling the `CreateKey` API
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Encrypted plaintext data. This field must be Base64-encoded. The maximum size of the original data is 4 KB
        /// </summary>
        [JsonProperty("Plaintext")]
        public string Plaintext{ get; set; }

        /// <summary>
        /// JSON string of key-value pair. If this parameter is specified, the same parameter needs to be provided when the `Decrypt` API is called. It is up to 1,024 characters
        /// </summary>
        [JsonProperty("EncryptionContext")]
        public string EncryptionContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "Plaintext", this.Plaintext);
            this.SetParamSimple(map, prefix + "EncryptionContext", this.EncryptionContext);
        }
    }
}

