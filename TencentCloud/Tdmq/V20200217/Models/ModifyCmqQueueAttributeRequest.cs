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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCmqQueueAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Queue name, which must be unique under the same account in the same region. It can contain up to 64 letters, digits, and hyphens and must begin with a letter.
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// Maximum number of heaped messages. The value range is 1,000,000–10,000,000 during the beta test and can be 1,000,000–1,000,000,000 after the product is officially released. The default value is 10,000,000 during the beta test and will be 100,000,000 after the product is officially released.
        /// </summary>
        [JsonProperty("MaxMsgHeapNum")]
        public ulong? MaxMsgHeapNum{ get; set; }

        /// <summary>
        /// Long polling wait time for message reception. Value range: 0–30 seconds. Default value: 0.
        /// </summary>
        [JsonProperty("PollingWaitSeconds")]
        public ulong? PollingWaitSeconds{ get; set; }

        /// <summary>
        /// Message visibility timeout period. Value range: 1–43200 seconds (i.e., 12 hours). Default value: 30.
        /// </summary>
        [JsonProperty("VisibilityTimeout")]
        public ulong? VisibilityTimeout{ get; set; }

        /// <summary>
        /// Max message size, which defaults to 1,024 KB for the queue of TDMQ for CMQ and cannot be modified.
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize{ get; set; }

        /// <summary>
        /// The max period during which a message is retained before it is automatically acknowledged. Value range: 30-43,200 seconds (30 seconds to 12 hours). Default value: 3600 seconds (1 hour).
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds{ get; set; }

        /// <summary>
        /// Rewindable time of messages in the queue. Value range: 0-1,296,000s (if message rewind is enabled). The value “0” indicates that message rewind is not enabled.
        /// </summary>
        [JsonProperty("RewindSeconds")]
        public ulong? RewindSeconds{ get; set; }

        /// <summary>
        /// First query time
        /// </summary>
        [JsonProperty("FirstQueryInterval")]
        public ulong? FirstQueryInterval{ get; set; }

        /// <summary>
        /// Maximum number of queries
        /// </summary>
        [JsonProperty("MaxQueryCount")]
        public ulong? MaxQueryCount{ get; set; }

        /// <summary>
        /// Dead letter queue name
        /// </summary>
        [JsonProperty("DeadLetterQueueName")]
        public string DeadLetterQueueName{ get; set; }

        /// <summary>
        /// Maximum period in seconds before an unconsumed message expires, which is required if `MaxTimeToLivepolicy` is 1. Value range: 300–43200. This value should be smaller than `MsgRetentionSeconds` (maximum message retention period)
        /// </summary>
        [JsonProperty("MaxTimeToLive")]
        public ulong? MaxTimeToLive{ get; set; }

        /// <summary>
        /// Maximum number of receipts
        /// </summary>
        [JsonProperty("MaxReceiveCount")]
        public ulong? MaxReceiveCount{ get; set; }

        /// <summary>
        /// Dead letter queue policy
        /// </summary>
        [JsonProperty("Policy")]
        public ulong? Policy{ get; set; }

        /// <summary>
        /// Whether to enable message trace. true: yes; false: no. If this field is left empty, the feature will not be enabled.
        /// </summary>
        [JsonProperty("Trace")]
        public bool? Trace{ get; set; }

        /// <summary>
        /// Whether to enable transaction. 1: yes; 0: no
        /// </summary>
        [JsonProperty("Transaction")]
        public ulong? Transaction{ get; set; }

        /// <summary>
        /// Queue storage space configured for message rewind. Value range: 10,240-512,000 MB (if message rewind is enabled). The value “0” indicates that message rewind is not enabled.
        /// </summary>
        [JsonProperty("RetentionSizeInMB")]
        public ulong? RetentionSizeInMB{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "MaxMsgHeapNum", this.MaxMsgHeapNum);
            this.SetParamSimple(map, prefix + "PollingWaitSeconds", this.PollingWaitSeconds);
            this.SetParamSimple(map, prefix + "VisibilityTimeout", this.VisibilityTimeout);
            this.SetParamSimple(map, prefix + "MaxMsgSize", this.MaxMsgSize);
            this.SetParamSimple(map, prefix + "MsgRetentionSeconds", this.MsgRetentionSeconds);
            this.SetParamSimple(map, prefix + "RewindSeconds", this.RewindSeconds);
            this.SetParamSimple(map, prefix + "FirstQueryInterval", this.FirstQueryInterval);
            this.SetParamSimple(map, prefix + "MaxQueryCount", this.MaxQueryCount);
            this.SetParamSimple(map, prefix + "DeadLetterQueueName", this.DeadLetterQueueName);
            this.SetParamSimple(map, prefix + "MaxTimeToLive", this.MaxTimeToLive);
            this.SetParamSimple(map, prefix + "MaxReceiveCount", this.MaxReceiveCount);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "Trace", this.Trace);
            this.SetParamSimple(map, prefix + "Transaction", this.Transaction);
            this.SetParamSimple(map, prefix + "RetentionSizeInMB", this.RetentionSizeInMB);
        }
    }
}

