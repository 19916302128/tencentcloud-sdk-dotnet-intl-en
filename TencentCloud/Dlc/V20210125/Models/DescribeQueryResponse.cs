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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeQueryResponse : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// The SQL being executed currently. A task contains one SQL.
        /// </summary>
        [JsonProperty("SQL")]
        public string SQL{ get; set; }

        /// <summary>
        /// The currently executed task types are divided into DDL, DML, and DQL.
        /// </summary>
        [JsonProperty("SQLType")]
        public string SQLType{ get; set; }

        /// <summary>
        /// The current status of the task is 0: initializing; 1: running; 2: executed; 3: writing data; 4: queuing; -1: task execution failed; -3: manually terminated. The task execution result is returned only when the task is successfully executed.
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// Default data set of query results
        /// </summary>
        [JsonProperty("DataSet")]
        public string DataSet{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SQL", this.SQL);
            this.SetParamSimple(map, prefix + "SQLType", this.SQLType);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "DataSet", this.DataSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

