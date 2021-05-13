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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserSqlAdviceResponse : AbstractModel
    {
        
        /// <summary>
        /// SQL statement optimization suggestions, which can be parsed into JSON arrays.
        /// </summary>
        [JsonProperty("Advices")]
        public string Advices{ get; set; }

        /// <summary>
        /// Notes of SQL statement optimization suggestions, which can be parsed into String arrays.
        /// </summary>
        [JsonProperty("Comments")]
        public string Comments{ get; set; }

        /// <summary>
        /// SQL statement.
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// Database name.
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// DDL information of related tables, which can be parsed into JSON arrays.
        /// </summary>
        [JsonProperty("Tables")]
        public string Tables{ get; set; }

        /// <summary>
        /// SQL execution plan, which can be parsed into JSON.
        /// </summary>
        [JsonProperty("SqlPlan")]
        public string SqlPlan{ get; set; }

        /// <summary>
        /// Cost saving details after SQL statement optimization, which can be parsed into JSON.
        /// </summary>
        [JsonProperty("Cost")]
        public string Cost{ get; set; }

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
            this.SetParamSimple(map, prefix + "Advices", this.Advices);
            this.SetParamSimple(map, prefix + "Comments", this.Comments);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "Tables", this.Tables);
            this.SetParamSimple(map, prefix + "SqlPlan", this.SqlPlan);
            this.SetParamSimple(map, prefix + "Cost", this.Cost);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

